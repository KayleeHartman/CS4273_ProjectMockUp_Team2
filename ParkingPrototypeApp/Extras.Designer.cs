﻿namespace ParkingPrototypeApp
{
    partial class Extras
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extras));
			this.extrasCheckbox = new System.Windows.Forms.CheckedListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.costTotalLabel = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// extrasCheckbox
			// 
			this.extrasCheckbox.CausesValidation = false;
			this.extrasCheckbox.CheckOnClick = true;
			this.extrasCheckbox.FormattingEnabled = true;
			this.extrasCheckbox.Items.AddRange(new object[] {
            "Car Wash",
            "Valet Parking",
            "Extra Security"});
			this.extrasCheckbox.Location = new System.Drawing.Point(178, 65);
			this.extrasCheckbox.Name = "extrasCheckbox";
			this.extrasCheckbox.Size = new System.Drawing.Size(191, 88);
			this.extrasCheckbox.TabIndex = 0;
			this.extrasCheckbox.SelectedIndexChanged += new System.EventHandler(this.ExtrasCheckbox_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(178, 302);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(191, 55);
			this.button1.TabIndex = 1;
			this.button1.Text = "Confirm";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(174, 209);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Cost Label";
			// 
			// costTotalLabel
			// 
			this.costTotalLabel.AutoSize = true;
			this.costTotalLabel.Location = new System.Drawing.Point(265, 209);
			this.costTotalLabel.Name = "costTotalLabel";
			this.costTotalLabel.Size = new System.Drawing.Size(124, 20);
			this.costTotalLabel.TabIndex = 3;
			this.costTotalLabel.Text = "Cost Total Label";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(133, 63);
			this.button2.TabIndex = 22;
			this.button2.Text = "Go Back to Home Page";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Extras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(543, 454);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.costTotalLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.extrasCheckbox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Extras";
			this.Text = "Extras";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox extrasCheckbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label costTotalLabel;
        private System.Windows.Forms.Button button2;
    }
}