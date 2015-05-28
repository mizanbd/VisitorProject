namespace VisitorProject
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitorEntrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneSpecificVisitorInformationReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneTypeWiseVisitorNumberReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitorToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // visitorToolStripMenuItem
            // 
            this.visitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitorEntrToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.visitorToolStripMenuItem.Name = "visitorToolStripMenuItem";
            this.visitorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.visitorToolStripMenuItem.Text = "Visitor";
            // 
            // visitorEntrToolStripMenuItem
            // 
            this.visitorEntrToolStripMenuItem.Name = "visitorEntrToolStripMenuItem";
            this.visitorEntrToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.visitorEntrToolStripMenuItem.Text = "Visitor Entry";
            this.visitorEntrToolStripMenuItem.Click += new System.EventHandler(this.visitorEntrToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoneTypeToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.setupToolStripMenuItem.Text = "Setup";
           
            // 
            // zoneTypeToolStripMenuItem
            // 
            this.zoneTypeToolStripMenuItem.Name = "zoneTypeToolStripMenuItem";
            this.zoneTypeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.zoneTypeToolStripMenuItem.Text = "Zone Type";
            this.zoneTypeToolStripMenuItem.Click += new System.EventHandler(this.zoneTypeToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoneSpecificVisitorInformationReportToolStripMenuItem,
            this.zoneTypeWiseVisitorNumberReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // zoneSpecificVisitorInformationReportToolStripMenuItem
            // 
            this.zoneSpecificVisitorInformationReportToolStripMenuItem.Name = "zoneSpecificVisitorInformationReportToolStripMenuItem";
            this.zoneSpecificVisitorInformationReportToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.zoneSpecificVisitorInformationReportToolStripMenuItem.Text = "Zone Specific Visitor Information Report";
            this.zoneSpecificVisitorInformationReportToolStripMenuItem.Click += new System.EventHandler(this.zoneSpecificVisitorInformationReportToolStripMenuItem_Click);
            // 
            // zoneTypeWiseVisitorNumberReportToolStripMenuItem
            // 
            this.zoneTypeWiseVisitorNumberReportToolStripMenuItem.Name = "zoneTypeWiseVisitorNumberReportToolStripMenuItem";
            this.zoneTypeWiseVisitorNumberReportToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.zoneTypeWiseVisitorNumberReportToolStripMenuItem.Text = "Zone Type Wise Visitor Number Report";
            this.zoneTypeWiseVisitorNumberReportToolStripMenuItem.Click += new System.EventHandler(this.zoneTypeWiseVisitorNumberReportToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 474);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitorEntrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneSpecificVisitorInformationReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneTypeWiseVisitorNumberReportToolStripMenuItem;

    }
}

