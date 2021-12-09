namespace Capstone
{
    partial class HighLowForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.lowBloodSugarBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.highBloodSugarBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.currentLowLabel = new System.Windows.Forms.Label();
            this.currentHighLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter settings for what you consider high and low blood sugar.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Low blood sugar less than:";
            // 
            // lowBloodSugarBox
            // 
            this.lowBloodSugarBox.Location = new System.Drawing.Point(169, 53);
            this.lowBloodSugarBox.Name = "lowBloodSugarBox";
            this.lowBloodSugarBox.Size = new System.Drawing.Size(100, 20);
            this.lowBloodSugarBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "High blood sugar greater than:";
            // 
            // highBloodSugarBox
            // 
            this.highBloodSugarBox.Location = new System.Drawing.Point(169, 120);
            this.highBloodSugarBox.Name = "highBloodSugarBox";
            this.highBloodSugarBox.Size = new System.Drawing.Size(100, 20);
            this.highBloodSugarBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(49, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(169, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // currentLowLabel
            // 
            this.currentLowLabel.AutoSize = true;
            this.currentLowLabel.Location = new System.Drawing.Point(12, 87);
            this.currentLowLabel.Name = "currentLowLabel";
            this.currentLowLabel.Size = new System.Drawing.Size(59, 13);
            this.currentLowLabel.TabIndex = 7;
            this.currentLowLabel.Text = "current low";
            // 
            // currentHighLabel
            // 
            this.currentHighLabel.AutoSize = true;
            this.currentHighLabel.Location = new System.Drawing.Point(12, 154);
            this.currentHighLabel.Name = "currentHighLabel";
            this.currentHighLabel.Size = new System.Drawing.Size(63, 13);
            this.currentHighLabel.TabIndex = 8;
            this.currentHighLabel.Text = "current high";
            // 
            // HighLowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 250);
            this.Controls.Add(this.currentHighLabel);
            this.Controls.Add(this.currentLowLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.highBloodSugarBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lowBloodSugarBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HighLowForm";
            this.Text = "Set High and Low";
            this.Load += new System.EventHandler(this.HighLowForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lowBloodSugarBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox highBloodSugarBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label currentLowLabel;
        private System.Windows.Forms.Label currentHighLabel;
    }
}