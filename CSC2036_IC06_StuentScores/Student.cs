using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC2036_IC06_StuentScores
{
    //internal class Student
    public class Student
    {
        // Default is private
        private string name;
        private List<int> scoresList = new List<int>();
        private char sep = '|';

        /// <summary>
        /// method <c>Student</c>  
        /// </summary>
        public Student() : this("Empty") // Removes nullable warning
        //public Student() // Has a nullable warning
        {
        }
        /// <summary>
        /// method <c>Student</c> This method has the same name as the method 
        /// above but requires a passed string
        /// </summary>
        public Student(string studentAndScores)
        {
            string[] columns = studentAndScores.Split(sep);

            // Set name
            if (columns[0] != "")
                this.name = columns[0];
            else
                this.name = "Empty";

            // Set scores list  
            for (int i = 1; i < columns.Length; ++i)
            {
                if (columns[i] != "")
                    this.scoresList.Add(Convert.ToInt32(columns[i]));
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public List<int> Scores
        {
            get
            {
                return scoresList;
            }
            set
            {
                scoresList = value;
            }
        }

        public char Sep
        {
            get { return sep; }
            set { sep = value; }
        }
        public string GetScoresString()
        {
            string scoresString = "";
            foreach (int idx in scoresList)
            {
                // Notice the concatenation plus equals 
                // Place the separator | between each score
                //    and convert to string
                scoresString += sep.ToString() + idx.ToString();
            }
            return scoresString;
        }
        public override string ToString() => name + this.GetScoresString();

    }
}
