using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays_Exercise_WindowsForms
{
    public partial class FrmStudentMarks : Form
    {
        public FrmStudentMarks()
        {
            InitializeComponent();
        }

        // We initialize empty arrays to store the input data
        string[] studentName = new string[101];
        int[] studentMark = new int[101];
        int[] frequency = new int[101];

        // We initialize counter to count number of entries
        // and we pass it explicitly with the -ref modifier
        // in order to act as reference type and keep it's modified value.
        int counter = 0;

        private void BtnGrades_Click(object sender, EventArgs e)
        {
            // We pass the empty arrays and fill them with data
            DataEntry(studentName, studentMark, ref counter);
            Display(studentName, studentMark, counter);
            
        }
        private void BtnPassFail_Click(object sender, EventArgs e)
        {
            PassFail(studentName, studentMark, counter);
        }
        private void BtnHighestMark_Click(object sender, EventArgs e)
        {
            ShowHighestMark(studentName, studentMark, counter);
        }
        private void BtnFrequency_Click(object sender, EventArgs e)
        {
            GetMarksFrequency(studentMark, frequency, counter);
            ShowFrequency(frequency);
        }
        private void BtnShowSorted_Click(object sender, EventArgs e)
        {
            ShowSorted(studentMark, studentName, counter);
        }


        private void DataEntry(string[] stName, int[] stMark, ref int count)
        {
            while (true)
            {
                string response = "";

                do
                {
                    response = Microsoft.VisualBasic.Interaction.InputBox("Do you want to enter info y/n?", "Info");
                }
                while (response != "y" && response != "n");

                if (response == "n")
                    break;

                string tempS = Microsoft.VisualBasic.Interaction.InputBox("Enter student name: ", "Student name");
                int tempM = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter student mark: ", "Student mark"));

                if (String.IsNullOrWhiteSpace(tempS) || (tempM < 0 || tempM > 100))
                {
                    MessageBox.Show("Invalid entry", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    // We start from index 1
                    count++;
                    stName[count] = tempS;
                    stMark[count] = tempM;
                }
            }           
        }

        private void Display(string[] names, int[] marks, int count)
        {
            LstInfo.Items.Clear();
            LstInfo.Items.Add("List of students / marks.");
            for (int i = 1; i < count + 1; i++)
            {
                LstInfo.Items.Add(names[i] + "\t" + marks[i]);
            }
        }

        private void PassFail(string[] names, int[] marks, int count)
        {
            LstInfo.Items.Clear();
            for (int i = 1; i < count + 1; i++)
            {
                if (marks[i] >= 50)
                {
                    LstInfo.Items.Add(names[i] + " " + marks[i] + "\t Pass");
                }
                else
                {
                    LstInfo.Items.Add(names[i] + " " + marks[i] + "\t Fail");
                }      
            }
        }

        

        private void ShowHighestMark(string[] names, int[] marks, int count)
        {
            LstInfo.Items.Clear();

            int highest = marks[1];
            for (int i = 1; i < count + 1; i++)
            {
                if (marks[i] > highest)
                    highest = marks[i]; 
            }
            LstInfo.Items.Add("Highest mark is: " + highest);
            LstInfo.Items.Add("Students with highest marks: ");
            for (int i = 1; i < count + 1; i++)
            {
                if (marks[i] == highest)
                {
                    LstInfo.Items.Add(names[i]);
                }
            }
        }

        // We use array counter to count the frequency
        private void GetMarksFrequency(int[] marks, int[] frequency, int count)
        { 
            for (int i = 1; i < count + 1; i++)
            {
                frequency[marks[i]] = frequency[marks[i]] + 1;
            }
        }

        private void ShowFrequency(int[] f)
        {
            LstInfo.Items.Clear();
            for (int i = 1; i < f.Count(); i++)
            {
                if (f[i] != 0)
                    LstInfo.Items.Add(i + " " + f[i].ToString());
            }
        }

        // We use bubble sort to sort the marks and names
        private void ShowSorted(int[] marks, string[] names, int count)
        {
            // Flag to keep track if swap is made
            bool flag = false;

            // Declare new arrays and copy the data into them,
            // so we don't change the intial ones.
            int[] marksSorted = new int[marks.Count()];
            string[] namesSorted = new string[names.Count()];

            Array.Copy(marks, marksSorted, marks.Count());
            Array.Copy(names, namesSorted, names.Count());

            
            do
            {
                for (int i = 1; i <= count - 1; i++)
                {
                    flag = false;
                    int temp = 0;
                    string tempN = "";
                    // If first number is bigger than the second we swap them,
                    // and we also swap the names in the "names" array
                    if (marksSorted[i] > marksSorted[i + 1])
                    {
                        temp = marksSorted[i];
                        marksSorted[i] = marksSorted[i + 1];
                        marksSorted[i + 1] = temp;

                        tempN = namesSorted[i];
                        namesSorted[i] = namesSorted[i + 1];
                        namesSorted[i + 1] = tempN;
                        flag = true;
                    }
                }
            }
            while (flag);

            LstInfo.Items.Clear();
            for (int i = 1; i <= count; i++)
            {
                LstInfo.Items.Add(marksSorted[i] + "\t" + namesSorted[i]);
            }
        }
    }
}
