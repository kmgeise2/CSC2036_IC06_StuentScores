namespace CSC2036_IC06_StuentScores
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtScoreTotal = new System.Windows.Forms.TextBox();
            this.txtScoreCount = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 48;
            this.listBox1.Location = new System.Drawing.Point(90, 114);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(492, 340);
            this.listBox1.TabIndex = 0;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(629, 114);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(225, 69);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Students";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(629, 248);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(225, 69);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(629, 372);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(225, 69);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "Score total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 645);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "Score count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 748);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 48);
            this.label4.TabIndex = 7;
            this.label4.Text = "Average";
            // 
            // txtScoreTotal
            // 
            this.txtScoreTotal.Location = new System.Drawing.Point(412, 551);
            this.txtScoreTotal.Name = "txtScoreTotal";
            this.txtScoreTotal.ReadOnly = true;
            this.txtScoreTotal.Size = new System.Drawing.Size(300, 55);
            this.txtScoreTotal.TabIndex = 8;
            this.txtScoreTotal.Visible = false;
            // 
            // txtScoreCount
            // 
            this.txtScoreCount.Location = new System.Drawing.Point(410, 647);
            this.txtScoreCount.Name = "txtScoreCount";
            this.txtScoreCount.ReadOnly = true;
            this.txtScoreCount.Size = new System.Drawing.Size(300, 55);
            this.txtScoreCount.TabIndex = 9;
            this.txtScoreCount.Visible = false;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(406, 744);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(300, 55);
            this.txtAverage.TabIndex = 10;
            this.txtAverage.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(823, 714);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(225, 69);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 946);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtScoreCount);
            this.Controls.Add(this.txtScoreTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Student Scores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnAddNew;
        private Label label1;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtScoreTotal;
        private TextBox txtScoreCount;
        private TextBox txtAverage;
        private Button btnExit;
        public ListBox listBox1;
    }
}