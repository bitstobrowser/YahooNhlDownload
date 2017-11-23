namespace NhlDownload
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.labelLeagueNumber = new System.Windows.Forms.Label();
            this.textBoxLeagueNumber = new System.Windows.Forms.TextBox();
            this.checkBoxPointsLeague = new System.Windows.Forms.CheckBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(221, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Build CSV File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelLeagueNumber
            // 
            this.labelLeagueNumber.AutoSize = true;
            this.labelLeagueNumber.Location = new System.Drawing.Point(13, 13);
            this.labelLeagueNumber.Name = "labelLeagueNumber";
            this.labelLeagueNumber.Size = new System.Drawing.Size(83, 13);
            this.labelLeagueNumber.TabIndex = 1;
            this.labelLeagueNumber.Text = "League Number";
            // 
            // textBoxLeagueNumber
            // 
            this.textBoxLeagueNumber.Location = new System.Drawing.Point(102, 10);
            this.textBoxLeagueNumber.Name = "textBoxLeagueNumber";
            this.textBoxLeagueNumber.Size = new System.Drawing.Size(126, 20);
            this.textBoxLeagueNumber.TabIndex = 2;
            // 
            // checkBoxPointsLeague
            // 
            this.checkBoxPointsLeague.AutoSize = true;
            this.checkBoxPointsLeague.Checked = true;
            this.checkBoxPointsLeague.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPointsLeague.Location = new System.Drawing.Point(102, 36);
            this.checkBoxPointsLeague.Name = "checkBoxPointsLeague";
            this.checkBoxPointsLeague.Size = new System.Drawing.Size(126, 17);
            this.checkBoxPointsLeague.TabIndex = 3;
            this.checkBoxPointsLeague.Text = "Points-based League";
            this.checkBoxPointsLeague.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(13, 103);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(35, 13);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 133);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.checkBoxPointsLeague);
            this.Controls.Add(this.textBoxLeagueNumber);
            this.Controls.Add(this.labelLeagueNumber);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Yahoo Fantasy NHL Downloader v0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelLeagueNumber;
        private System.Windows.Forms.TextBox textBoxLeagueNumber;
        private System.Windows.Forms.CheckBox checkBoxPointsLeague;
        private System.Windows.Forms.Label labelStatus;
    }
}

