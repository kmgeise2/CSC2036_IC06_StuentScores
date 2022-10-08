namespace CSC2036_IC06_StuentScores
{
    partial class FrmNewStudent
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDisplayScores = new System.Windows.Forms.TextBox();
            this.btnAddScore = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(203, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(518, 55);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(202, 145);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(213, 55);
            this.txtScore.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "Scores";
            // 
            // txtDisplayScores
            // 
            this.txtDisplayScores.Location = new System.Drawing.Point(207, 239);
            this.txtDisplayScores.Name = "txtDisplayScores";
            this.txtDisplayScores.Size = new System.Drawing.Size(514, 55);
            this.txtDisplayScores.TabIndex = 5;
            // 
            // btnAddScore
            // 
            this.btnAddScore.Location = new System.Drawing.Point(496, 131);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.Size = new System.Drawing.Size(225, 69);
            this.btnAddScore.TabIndex = 6;
            this.btnAddScore.Text = "Add Score";
            this.btnAddScore.UseVisualStyleBackColor = true;
            this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(494, 340);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(225, 69);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear Scores";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(494, 462);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(225, 69);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(251, 468);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(215, 63);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddScore);
            this.Controls.Add(this.txtDisplayScores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "FrmNewStudent";
            this.Text = "Add New Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtScore;
        private Label label3;
        private TextBox txtDisplayScores;
        private Button btnAddScore;
        private Button btnClear;
        private Button btnCancel;
        private Button btnOK;
    }
}