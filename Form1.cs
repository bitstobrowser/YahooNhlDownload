using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhlDownload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum RowType
        {
            WatchList,
            Player,
            AddDrop,
            Owner,
            GamesPlayed,
            PreSeasonRanking,
            CurrentRanking,
            OwnedPercentage,
            TimeOnIce,
            Goals,
            Assists,
            Points,
            PlusMinus,
            PenaltyMinutes,
            PowerPlayPoints,
            ShortHandedPoints,
            ShotsOnGoal,
            FaceoffWins,
            Hits,
            Blocks
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int playerCounter = 0;
            for (int pages=0; pages < 26; pages++)
            {
                String baseUrl = "https://hockey.fantasysports.yahoo.com/hockey/2561/players?status=ALL&pos=P&cut_type=33&stat1=S_S_2017&myteam=0&sort=AR&sdir=1";
                String pageUrl;
                if (pages ==0)
                {
                    pageUrl = baseUrl; 
                } else
                {
                    pageUrl = baseUrl + "&count=" + (pages * 25);
                }

                HtmlAgilityPack.HtmlWeb getHtmlWeb = new HtmlAgilityPack.HtmlWeb();
                HtmlAgilityPack.HtmlDocument document = getHtmlWeb.Load(pageUrl);

                // Page is loaded, go through the stats for each player
                var players = document.DocumentNode.SelectNodes("//div[@id='players-table']//div[@class='players']//table//tbody//tr");
                Debug.WriteLine("Players found =" + players.Count());
                foreach (HtmlAgilityPack.HtmlNode player in players)
                {
                    var items = player.Descendants("td");
                    int rowTypeCounter = 0;
                    foreach (HtmlAgilityPack.HtmlNode item in items)
                    {
                        switch ((RowType)rowTypeCounter)
                        {
                            case RowType.WatchList:
                                break;

                            case RowType.Player:
                                string playerName = item.SelectSingleNode(".//a[@class='Nowrap name F-link']").InnerText;
                                string teamPosition = item.SelectSingleNode(".//span[@class='Fz-xxs']").InnerText;
                                string[] tm = teamPosition.Split('-');
                                string team = tm[0].Trim();
                                string position = tm[1].Replace(",", "-").Trim();
                                Debug.Write((pages*25) + ": " + playerName + "," + team + "," + position);
                                break;
                        }
                        rowTypeCounter++;
                    }
                    Debug.WriteLine("");
                }
            }
        }
    }
}
