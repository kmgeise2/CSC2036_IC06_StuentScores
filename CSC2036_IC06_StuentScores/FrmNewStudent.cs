using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC2036_IC06_StuentScores
{
    public partial class FrmNewStudent : Form
    {
        Student student = new Student();
        public FrmNewStudent()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //if (Validator.IsPresent(txtName))
            {
                student.Name = txtName.Text;
                this.DialogResult = DialogResult.OK;
                this.Tag = student;
            }
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                int score = Convert.ToInt32(txtScore.Text);
                student.Scores.Add(score);
                DisplayScores();
                txtScore.Focus();
            }
        }
        private void DisplayScores()
        {
            txtDisplayScores.Text = "";
            foreach (var score in student.Scores)
            {
                txtDisplayScores.Text += score.ToString() + " ";
            }
        }
        private bool IsValidData()
        {
            return
                //Validate that the name text box has data
                Validator.IsPresent(txtName) &&

                /*
                 * Add the IsWithinRange code to the Validator
                 * class and add the validation using &&
                 */
                //Validate the score textbox
                //Validator.IsPresent(txtScore) &&
                //Validator.IsInt32(txtScore) &&
                //Validator.IsWithinRange(txtScore, 0, 100);

                //Validate the score textbox
                Validator.IsPresent(txtScore) &&
                Validator.IsInt32(txtScore);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            student.Scores.Clear();
            DisplayScores();
            txtScore.Focus();
        }
    }
}
