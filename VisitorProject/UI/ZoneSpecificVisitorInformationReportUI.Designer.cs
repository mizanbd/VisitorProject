namespace VisitorProject.UI
{
    partial class ZoneSpecificVisitorInformationReportUI
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
            this.selectZoneComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.zoneListView = new System.Windows.Forms.ListView();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.exportReportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectZoneComboBox
            // 
            this.selectZoneComboBox.FormattingEnabled = true;
            this.selectZoneComboBox.Location = new System.Drawing.Point(208, 33);
            this.selectZoneComboBox.Name = "selectZoneComboBox";
            this.selectZoneComboBox.Size = new System.Drawing.Size(216, 21);
            this.selectZoneComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Zone:";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(440, 30);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(71, 24);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            // 
            // zoneListView
            // 
            this.zoneListView.Location = new System.Drawing.Point(23, 124);
            this.zoneListView.Name = "zoneListView";
            this.zoneListView.Size = new System.Drawing.Size(721, 217);
            this.zoneListView.TabIndex = 3;
            this.zoneListView.UseCompatibleStateImageBehavior = false;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(397, 357);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total:";
            // 
            // exportReportButton
            // 
            this.exportReportButton.Location = new System.Drawing.Point(544, 354);
            this.exportReportButton.Name = "exportReportButton";
            this.exportReportButton.Size = new System.Drawing.Size(115, 23);
            this.exportReportButton.TabIndex = 6;
            this.exportReportButton.Text = "Exprot to Excel";
            this.exportReportButton.UseVisualStyleBackColor = true;
            // 
            // ZoneSpecificVisitorInformationReportUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 439);
            this.Controls.Add(this.exportReportButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.zoneListView);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectZoneComboBox);
            this.Name = "ZoneSpecificVisitorInformationReportUI";
            this.Text = "Zone Specific Visitor Information Report";
            this.Load += new System.EventHandler(this.ZoneSpecificVisitorInformationReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectZoneComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ListView zoneListView;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exportReportButton;
    }
}