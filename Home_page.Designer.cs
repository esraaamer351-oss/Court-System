namespace project
{
    partial class Home_page
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getCourtInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getCaseInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getAccusedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getMaxAgeOfAccusedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getSpecificAccusedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getAccusedReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.getJudgmentReportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Koufi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(54, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(758, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Court System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCaseToolStripMenuItem,
            this.updateCaseToolStripMenuItem,
            this.getCourtInformationToolStripMenuItem,
            this.getCaseInformationToolStripMenuItem,
            this.getAccusedToolStripMenuItem,
            this.getAccusedReportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(922, 60);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addCaseToolStripMenuItem
            // 
            this.addCaseToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.addCaseToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCaseToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addCaseToolStripMenuItem.Name = "addCaseToolStripMenuItem";
            this.addCaseToolStripMenuItem.Size = new System.Drawing.Size(110, 54);
            this.addCaseToolStripMenuItem.Text = "Add Case";
            this.addCaseToolStripMenuItem.Click += new System.EventHandler(this.addCaseToolStripMenuItem_Click_1);
            // 
            // updateCaseToolStripMenuItem
            // 
            this.updateCaseToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCaseToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateCaseToolStripMenuItem.Name = "updateCaseToolStripMenuItem";
            this.updateCaseToolStripMenuItem.Size = new System.Drawing.Size(137, 54);
            this.updateCaseToolStripMenuItem.Text = "Update Case";
            this.updateCaseToolStripMenuItem.Click += new System.EventHandler(this.updateCaseToolStripMenuItem_Click);
            // 
            // getCourtInformationToolStripMenuItem
            // 
            this.getCourtInformationToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.getCourtInformationToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getCourtInformationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.getCourtInformationToolStripMenuItem.Name = "getCourtInformationToolStripMenuItem";
            this.getCourtInformationToolStripMenuItem.Size = new System.Drawing.Size(233, 54);
            this.getCourtInformationToolStripMenuItem.Text = "Get  Court Information";
            this.getCourtInformationToolStripMenuItem.Click += new System.EventHandler(this.getCourtInformationToolStripMenuItem_Click);
            // 
            // getCaseInformationToolStripMenuItem
            // 
            this.getCaseInformationToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getCaseInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.getCaseInformationToolStripMenuItem.Name = "getCaseInformationToolStripMenuItem";
            this.getCaseInformationToolStripMenuItem.Size = new System.Drawing.Size(183, 54);
            this.getCaseInformationToolStripMenuItem.Text = "Get Case Information";
            this.getCaseInformationToolStripMenuItem.Click += new System.EventHandler(this.getCaseInformationToolStripMenuItem_Click);
            // 
            // getAccusedToolStripMenuItem
            // 
            this.getAccusedToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.getAccusedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getMaxAgeOfAccusedToolStripMenuItem,
            this.getSpecificAccusedToolStripMenuItem});
            this.getAccusedToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAccusedToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.getAccusedToolStripMenuItem.Name = "getAccusedToolStripMenuItem";
            this.getAccusedToolStripMenuItem.Size = new System.Drawing.Size(134, 54);
            this.getAccusedToolStripMenuItem.Text = "Get Accused";
            this.getAccusedToolStripMenuItem.Click += new System.EventHandler(this.getAccusedToolStripMenuItem_Click);
            // 
            // getMaxAgeOfAccusedToolStripMenuItem
            // 
            this.getMaxAgeOfAccusedToolStripMenuItem.Name = "getMaxAgeOfAccusedToolStripMenuItem";
            this.getMaxAgeOfAccusedToolStripMenuItem.Size = new System.Drawing.Size(301, 30);
            this.getMaxAgeOfAccusedToolStripMenuItem.Text = "Get Max Age of Accused";
            this.getMaxAgeOfAccusedToolStripMenuItem.Click += new System.EventHandler(this.getMaxAgeOfAccusedToolStripMenuItem_Click);
            // 
            // getSpecificAccusedToolStripMenuItem
            // 
            this.getSpecificAccusedToolStripMenuItem.Name = "getSpecificAccusedToolStripMenuItem";
            this.getSpecificAccusedToolStripMenuItem.Size = new System.Drawing.Size(301, 30);
            this.getSpecificAccusedToolStripMenuItem.Text = "Get Specific Accused";
            this.getSpecificAccusedToolStripMenuItem.Click += new System.EventHandler(this.getSpecificAccusedToolStripMenuItem_Click);
            // 
            // getAccusedReportToolStripMenuItem
            // 
            this.getAccusedReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.getJudgmentReportToolStripMenuItem1});
            this.getAccusedReportToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAccusedReportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.getAccusedReportToolStripMenuItem.Name = "getAccusedReportToolStripMenuItem";
            this.getAccusedReportToolStripMenuItem.Size = new System.Drawing.Size(94, 54);
            this.getAccusedReportToolStripMenuItem.Text = "Reports";
            this.getAccusedReportToolStripMenuItem.Click += new System.EventHandler(this.getAccusedReportToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(278, 30);
            this.toolStripMenuItem1.Text = "Get Court Report";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // getJudgmentReportToolStripMenuItem1
            // 
            this.getJudgmentReportToolStripMenuItem1.Name = "getJudgmentReportToolStripMenuItem1";
            this.getJudgmentReportToolStripMenuItem1.Size = new System.Drawing.Size(278, 30);
            this.getJudgmentReportToolStripMenuItem1.Text = "Get Judgment Report";
            this.getJudgmentReportToolStripMenuItem1.Click += new System.EventHandler(this.getJudgmentReportToolStripMenuItem1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Koufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(94, 289);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(765, 56);
            this.label2.TabIndex = 8;
            this.label2.Text = " Courts apply the law to specific controversies brought before them. \r\nThey resol" +
    "ve disputes between people companies and units of government.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project.Properties.Resources.home;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 542);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Court System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getCourtInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getAccusedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getAccusedReportToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem getJudgmentReportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem getMaxAgeOfAccusedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getSpecificAccusedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getCaseInformationToolStripMenuItem;
    }
}

