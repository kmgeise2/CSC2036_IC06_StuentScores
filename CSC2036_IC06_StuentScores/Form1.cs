
namespace CSC2036_IC06_StuentScores
{
    public partial class Form1 : Form
    {
        public List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Student student1 = new Student("Kathy Geise|98|88|91");
            Student student2 = new Student("Rob Jones|91|95|86");
            Student student3 = new Student("Sally James|97|91|88");
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            LoadStudentListBox();
        }
        private void LoadStudentListBox()
        {
            //Clear the listBox
            listBox1.Items.Clear();

            //Add the students from the list to the listBox
            foreach (Student s in students)
            {
                listBox1.Items.Add(s);
            }

            //Set the selected index to zero
            if (listBox1.Items.Count > 0)
                listBox1.SelectedIndex = 0;
            else
                ClearLabels();
        }
        private void ClearLabels()
        {
            // Set the text boxes in the form to empty
            this.txtScoreTotal.Text = "";
            this.txtAverage.Text = "";
            this.txtScoreCount.Text = "";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            // Create an instance of the Add New Student Form
            FrmNewStudent addForm = new FrmNewStudent();
            DialogResult button = addForm.ShowDialog();

            // Retrieve information if OK is clicked
            if (button == DialogResult.OK)
            {
                students.Add((Student)addForm.Tag);
                LoadStudentListBox();
            }
        }
    }
}