﻿namespace VisitorProject.UI
{
    partial class ZoneTypeUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.typeNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zoneTypeListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.typeNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 113);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zone Type";
          
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(140, 58);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(69, 26);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // typeNameTextBox
            // 
            this.typeNameTextBox.Location = new System.Drawing.Point(86, 32);
            this.typeNameTextBox.Name = "typeNameTextBox";
            this.typeNameTextBox.Size = new System.Drawing.Size(237, 20);
            this.typeNameTextBox.TabIndex = 3;
         
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Name:";

            // 
            // zoneTypeListView
            // 
            this.zoneTypeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.zoneTypeListView.Location = new System.Drawing.Point(71, 150);
            this.zoneTypeListView.Name = "zoneTypeListView";
            this.zoneTypeListView.Size = new System.Drawing.Size(275, 196);
            this.zoneTypeListView.TabIndex = 4;
            this.zoneTypeListView.UseCompatibleStateImageBehavior = false;
            this.zoneTypeListView.View = System.Windows.Forms.View.Details;
           
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Zone";
            this.columnHeader3.Width = 258;
            // 
            // ZoneTypeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 358);
            this.Controls.Add(this.zoneTypeListView);
            this.Controls.Add(this.groupBox1);
            this.Name = "ZoneTypeUI";
            this.Text = "Zone Type Entry";
            this.Load += new System.EventHandler(this.ZoneTypeUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox typeNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListView zoneTypeListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}