using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Proj05
{
    public partial class Form1 : Form
    {
        BindingList<Student> studentList = new BindingList<Student>();

        public Form1()
        {
            InitializeComponent();

            this.Text = "Records Manager";

            // Set the GUI listbox to use the studentList as a data source
            recordListbox.DataSource = studentList;
            recordListbox.DisplayMember = "displayName";

            loadRecords();
        }

        /*
         * addButton_Click
         * Triggers when pressing the "Add Record" button.
         * Checks user input, and then creates a new Student object to add to the studentList.
         * 
         * @ref checkInputs
         */
        private void addButton_Click(object sender, EventArgs e)
        {
            if (!checkInputs())
                return;

            studentList.Add(new Student(fnameInput.Text, lnameInput.Text, standingInput.SelectedItem.ToString()));
        }

        /*
         * checkInputs
         * Checks the input fields for valid entry data
         * 
         * @return bool Whether or not the inputs all checkout
         * 
         * TODO: Modify the if statements to check for valid inputs
         */
        private bool checkInputs()
        {
            bool pass = false;

            if (fnameInput.Text.All(char.IsLetter))
                pass = true;

            if (lnameInput.Text.All(char.IsLetter))
                pass = true;

            if (standingInput.SelectedItem == null)
                pass = false;

            if (!pass) MessageBox.Show("You have entered invalid inputs.");

            return pass;
        }

        /*
         * recordListbox_SelectedIndexChanged
         * Triggers when changing the select item in the GUI listbox.
         * Gets the index of the selected item and uses it to get the same index in
         * the studentList.
         */
        private void recordListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (recordListbox.SelectedIndex > -1)
            {
                saveButton.Visible = false;
                fnameOutput.Text = studentList[recordListbox.SelectedIndex].fname;
                lnameOutput.Text = studentList[recordListbox.SelectedIndex].lname;
                standingOutput.Text = studentList[recordListbox.SelectedIndex].standing;

                fnameInput.Text = "";
                lnameInput.Text = "";
                standingInput.Text = "";


            }
        }

        /*
         * Form1_FormClosing
         * Triggers when closing the application window.
         * Calls the saveRecords method.
         */
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveRecords();
        }

        /*
         * loadRecords
         * Loads a previously saved record of student data into the studentList variable
         */
        private void loadRecords()
        {
            if (!File.Exists(@"records.txt"))
            {
                File.Create(@"records.txt");
                return;
            }

            using (StreamReader reader = new StreamReader(@"records.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string fileLine = reader.ReadLine();

                    if (fileLine != null)
                    {
                        string[] parts = fileLine.Split('|');
                        Student student = new Student(parts[0], parts[1], parts[2]);
                        studentList.Add(student);

                    }
                }
            }
        }

        /*
         * saveRecords
         * Saves the records from the studentList variable to a file
         */
        private void saveRecords()
        {
            using (StreamWriter writer = new StreamWriter(@"records.txt"))
            {
                foreach (Student student in studentList)
                {
                    writer.WriteLine(student.fname + "|" + student.lname + "|" + student.standing);
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (recordListbox.SelectedIndex > -1)
            {
                fnameInput.Text = studentList[recordListbox.SelectedIndex].fname;
                lnameInput.Text = studentList[recordListbox.SelectedIndex].lname;
                standingInput.Text = studentList[recordListbox.SelectedIndex].standing;

                saveButton.Visible = true;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (recordListbox.SelectedIndex > -1)
                studentList.RemoveAt(recordListbox.SelectedIndex);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!checkInputs())
                return;

            studentList[recordListbox.SelectedIndex] = (new Student(fnameInput.Text, lnameInput.Text, standingInput.SelectedItem.ToString()));
        }
    }

    class Student
    {
        public string fname;
        public string lname;
        public string standing;
        public string displayName
        {
            get
            {
                return lname + ", " + fname;
            }
        }

        public Student(string FirstName, string LastName, string Standing)
        {
            this.fname = FirstName;
            this.lname = LastName;
            this.standing = Standing;
        }
    }
}
