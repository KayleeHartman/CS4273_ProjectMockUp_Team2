namespace ParkingPrototypeApp
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.extrasCostLabel = new System.Windows.Forms.Label();
            this.timeCostLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.label1.Location = new System.Drawing.Point(61, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Cost:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.button2.Location = new System.Drawing.Point(66, 246);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 75);
            this.button2.TabIndex = 2;
            this.button2.Text = "Credit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.button3.Location = new System.Drawing.Point(308, 246);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 75);
            this.button3.TabIndex = 3;
            this.button3.Text = "Debit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.label2.Location = new System.Drawing.Point(98, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Extras:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.label3.Location = new System.Drawing.Point(52, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time Spent:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 6;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 7;
            // 
            // extrasCostLabel
            // 
            this.extrasCostLabel.AutoSize = true;
            this.extrasCostLabel.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.extrasCostLabel.Location = new System.Drawing.Point(416, 111);
            this.extrasCostLabel.Name = "extrasCostLabel";
            this.extrasCostLabel.Size = new System.Drawing.Size(0, 27);
            this.extrasCostLabel.TabIndex = 8;
            // 
            // timeCostLabel
            // 
            this.timeCostLabel.AutoSize = true;
            this.timeCostLabel.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.timeCostLabel.Location = new System.Drawing.Point(416, 144);
            this.timeCostLabel.Name = "timeCostLabel";
            this.timeCostLabel.Size = new System.Drawing.Size(0, 27);
            this.timeCostLabel.TabIndex = 9;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.totalCostLabel.Location = new System.Drawing.Point(416, 184);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(0, 27);
            this.totalCostLabel.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.button1.Location = new System.Drawing.Point(14, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 75);
            this.button1.TabIndex = 11;
            this.button1.Text = "Go Back to Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.timeCostLabel);
            this.Controls.Add(this.extrasCostLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Summary";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label extrasCostLabel;
        private System.Windows.Forms.Label timeCostLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Button button1;
    }
}