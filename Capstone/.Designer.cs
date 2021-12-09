namespace Capstone
{
    partial class MainForm
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
            this.table1 = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bsCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.average30day = new System.Windows.Forms.Label();
            this.average30dayCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.average60day = new System.Windows.Forms.Label();
            this.average60dayCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.average90day = new System.Windows.Forms.Label();
            this.average90dayCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.averageAllTime = new System.Windows.Forms.Label();
            this.averageAllTimeCount = new System.Windows.Forms.Label();
            this.setHighLowButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numberLow = new System.Windows.Forms.Label();
            this.numberHigh = new System.Windows.Forms.Label();
            this.numberGood = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.graphButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // table1
            // 
            this.table1.AllowUserToAddRows = false;
            this.table1.AllowUserToDeleteRows = false;
            this.table1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.table1.Location = new System.Drawing.Point(47, 49);
            this.table1.Name = "table1";
            this.table1.ReadOnly = true;
            this.table1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table1.Size = new System.Drawing.Size(267, 325);
            this.table1.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 415);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(141, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add New Blood Sugar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(308, 415);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(153, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete Selected Blood Sugar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(603, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.loadMenuItem,
            this.saveMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newMenuItem
            // 
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newMenuItem.Text = "New";
            this.newMenuItem.Click += new System.EventHandler(this.newMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveMenuItem.Text = "Save";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // loadMenuItem
            // 
            this.loadMenuItem.Name = "loadMenuItem";
            this.loadMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadMenuItem.Text = "Load";
            this.loadMenuItem.Click += new System.EventHandler(this.loadMenuItem_Click);
            // 
            // bsCountLabel
            // 
            this.bsCountLabel.AutoSize = true;
            this.bsCountLabel.Location = new System.Drawing.Point(257, 387);
            this.bsCountLabel.Name = "bsCountLabel";
            this.bsCountLabel.Size = new System.Drawing.Size(13, 13);
            this.bsCountLabel.TabIndex = 4;
            this.bsCountLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of Blood Sugars: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "30 Day Average:";
            // 
            // average30day
            // 
            this.average30day.AutoSize = true;
            this.average30day.Location = new System.Drawing.Point(445, 187);
            this.average30day.Name = "average30day";
            this.average30day.Size = new System.Drawing.Size(0, 13);
            this.average30day.TabIndex = 7;
            // 
            // average30dayCount
            // 
            this.average30dayCount.AutoSize = true;
            this.average30dayCount.Location = new System.Drawing.Point(485, 187);
            this.average30dayCount.Name = "average30dayCount";
            this.average30dayCount.Size = new System.Drawing.Size(0, 13);
            this.average30dayCount.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "60 Day Average:";
            // 
            // average60day
            // 
            this.average60day.AutoSize = true;
            this.average60day.Location = new System.Drawing.Point(445, 231);
            this.average60day.Name = "average60day";
            this.average60day.Size = new System.Drawing.Size(13, 13);
            this.average60day.TabIndex = 10;
            this.average60day.Text = "  ";
            // 
            // average60dayCount
            // 
            this.average60dayCount.AutoSize = true;
            this.average60dayCount.Location = new System.Drawing.Point(485, 231);
            this.average60dayCount.Name = "average60dayCount";
            this.average60dayCount.Size = new System.Drawing.Size(13, 13);
            this.average60dayCount.TabIndex = 11;
            this.average60dayCount.Text = "  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "90 Day Average:";
            // 
            // average90day
            // 
            this.average90day.AutoSize = true;
            this.average90day.Location = new System.Drawing.Point(445, 274);
            this.average90day.Name = "average90day";
            this.average90day.Size = new System.Drawing.Size(0, 13);
            this.average90day.TabIndex = 13;
            // 
            // average90dayCount
            // 
            this.average90dayCount.AutoSize = true;
            this.average90dayCount.Location = new System.Drawing.Point(485, 274);
            this.average90dayCount.Name = "average90dayCount";
            this.average90dayCount.Size = new System.Drawing.Size(13, 13);
            this.average90dayCount.TabIndex = 14;
            this.average90dayCount.Text = "  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "All Time Average:";
            // 
            // averageAllTime
            // 
            this.averageAllTime.AutoSize = true;
            this.averageAllTime.Location = new System.Drawing.Point(445, 318);
            this.averageAllTime.Name = "averageAllTime";
            this.averageAllTime.Size = new System.Drawing.Size(13, 13);
            this.averageAllTime.TabIndex = 16;
            this.averageAllTime.Text = "  ";
            // 
            // averageAllTimeCount
            // 
            this.averageAllTimeCount.AutoSize = true;
            this.averageAllTimeCount.Location = new System.Drawing.Point(485, 318);
            this.averageAllTimeCount.Name = "averageAllTimeCount";
            this.averageAllTimeCount.Size = new System.Drawing.Size(13, 13);
            this.averageAllTimeCount.TabIndex = 17;
            this.averageAllTimeCount.Text = "  ";
            // 
            // setHighLowButton
            // 
            this.setHighLowButton.Location = new System.Drawing.Point(12, 444);
            this.setHighLowButton.Name = "setHighLowButton";
            this.setHighLowButton.Size = new System.Drawing.Size(141, 23);
            this.setHighLowButton.TabIndex = 18;
            this.setHighLowButton.Text = "Set High and Low";
            this.setHighLowButton.UseVisualStyleBackColor = true;
            this.setHighLowButton.Click += new System.EventHandler(this.setHighLowButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Number High:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Number Low:";
            // 
            // numberLow
            // 
            this.numberLow.AutoSize = true;
            this.numberLow.Location = new System.Drawing.Point(448, 115);
            this.numberLow.Name = "numberLow";
            this.numberLow.Size = new System.Drawing.Size(16, 13);
            this.numberLow.TabIndex = 21;
            this.numberLow.Text = "   ";
            // 
            // numberHigh
            // 
            this.numberHigh.AutoSize = true;
            this.numberHigh.Location = new System.Drawing.Point(448, 150);
            this.numberHigh.Name = "numberHigh";
            this.numberHigh.Size = new System.Drawing.Size(13, 13);
            this.numberHigh.TabIndex = 22;
            this.numberHigh.Text = "  ";
            // 
            // numberGood
            // 
            this.numberGood.AutoSize = true;
            this.numberGood.Location = new System.Drawing.Point(448, 86);
            this.numberGood.Name = "numberGood";
            this.numberGood.Size = new System.Drawing.Size(16, 13);
            this.numberGood.TabIndex = 24;
            this.numberGood.Text = "   ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(363, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Number Good:";
            // 
            // graphButton
            // 
            this.graphButton.Location = new System.Drawing.Point(159, 444);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(143, 23);
            this.graphButton.TabIndex = 25;
            this.graphButton.Text = "Graph";
            this.graphButton.UseVisualStyleBackColor = true;
            this.graphButton.Click += new System.EventHandler(this.graphButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(159, 415);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(143, 23);
            this.editButton.TabIndex = 26;
            this.editButton.Text = "Edit Selected Blood Sugar";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 479);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.graphButton);
            this.Controls.Add(this.numberGood);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numberHigh);
            this.Controls.Add(this.numberLow);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.setHighLowButton);
            this.Controls.Add(this.averageAllTimeCount);
            this.Controls.Add(this.averageAllTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.average90dayCount);
            this.Controls.Add(this.average90day);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.average60dayCount);
            this.Controls.Add(this.average60day);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.average30dayCount);
            this.Controls.Add(this.average30day);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bsCountLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.table1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Blood Sugar Log";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMenuItem;
        private System.Windows.Forms.Label bsCountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label average30day;
        private System.Windows.Forms.Label average30dayCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label average60day;
        private System.Windows.Forms.Label average60dayCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label average90day;
        private System.Windows.Forms.Label average90dayCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label averageAllTime;
        private System.Windows.Forms.Label averageAllTimeCount;
        private System.Windows.Forms.Button setHighLowButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label numberLow;
        private System.Windows.Forms.Label numberHigh;
        private System.Windows.Forms.Label numberGood;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button graphButton;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.Button editButton;
    }
}

