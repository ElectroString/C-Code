/*
 * Cam Davies
 * 11/20/2024
 * Main Form Reggistration File
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Assignment_05
{
    public partial class Form1 : Form
    {
        List<campus> campusList = new List<campus> { };
        BindingList<student> students = new BindingList<student>();
        public Form1()
        {
            InitializeComponent();
            populateStudentComboBoxs();
            populateCampus();
            dataGridView1.DataSource = students;
        }

        // Checks the Student information data when clicked
        // Opens Campus information if available
        private void btn_check_Click(object sender, EventArgs e)
        {
             
            cmboBox_location.Items.Clear();
            if (studentInfoCheck())
            {
                if (populateLocations())
                {
                    cmboBox_location.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Registration Declined");
                }
                
            }
        }

        // Populates the combo boxes for grade and test score
        public void populateStudentComboBoxs()
        {
            // Grades
            cmboBox_grade.Items.Add("1");
            cmboBox_grade.Items.Add("2");
            cmboBox_grade.Items.Add("3");
            cmboBox_grade.Items.Add("4");
            cmboBox_grade.Items.Add("5");
            cmboBox_grade.Items.Add("6");
            cmboBox_grade.Items.Add("7");
            cmboBox_grade.Items.Add("8");
            cmboBox_grade.Items.Add("9");
            cmboBox_grade.Items.Add("10");
            cmboBox_grade.Items.Add("11");
            cmboBox_grade.Items.Add("12");

            // Test Scores
            cmboBox_testScore.Items.Add("10");
            cmboBox_testScore.Items.Add("20");
            cmboBox_testScore.Items.Add("30");
            cmboBox_testScore.Items.Add("40");
            cmboBox_testScore.Items.Add("50");
            cmboBox_testScore.Items.Add("60");
            cmboBox_testScore.Items.Add("70");
            cmboBox_testScore.Items.Add("80");
            cmboBox_testScore.Items.Add("90");
        }

        // Checks the student information for errors
        public bool studentInfoCheck()
        {
            bool valid = true;
            if (String.IsNullOrEmpty(txtBox_firstName.Text))
            {
                MessageBox.Show("Error: First Name cannot be blank");
                valid = false;
            }

            if (String.IsNullOrEmpty(txtBox_lastName.Text))
            {
                MessageBox.Show("Error, Last name cannot be blank");
                valid = false;
            }

            
            if (String.IsNullOrEmpty(txtBox_SIN.Text))
            {
                MessageBox.Show("Error, SIN cannot be blank");
                valid = false;
            }
            else
            {
                try
                {
                    int SIN = Convert.ToInt32(txtBox_SIN.Text);
                    if(SIN <= 99999999)
                    {
                        MessageBox.Show("Error: SIN Must be 9 digits");
                        valid = false;
                    }
                    else
                    {
                        if (students.Count != 0)
                        {
                            foreach (student student in students)
                            {
                                if (SIN == student.SIN)
                                {
                                    MessageBox.Show("Error: SIN Must Be Unique");
                                    valid = false;
                                    break;
                                }
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Error: SIN must be a 9 digit integer");
                    valid = false;
                }
            }

            if (String.IsNullOrEmpty(txtBox_email.Text))
            {
                MessageBox.Show("Error, Email cannot be blank");
                valid = false;
            }

            if (cmboBox_grade.SelectedIndex == -1)
            {
                MessageBox.Show("Error, Must select a grade");
                valid = false;
            }

            if (cmboBox_testScore.SelectedIndex == -1)
            {
                MessageBox.Show("Error, Must select a test score");
                valid = false;
            }

            return valid;
        }

        // Changes available programs depending on the selected campus location
        private void cmboBox_location_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboBox_location.SelectedIndex != -1)
            {
                cmboBox_programs.SelectedIndex = -1;
                lbl_totalCost.Text = "$0.00";
                lbl_studyPeriod.Text = "0";
                cmboBox_programs.Items.Clear();
                populatePrograms(cmboBox_location.SelectedItem.ToString());
                cmboBox_programs.Enabled = true;
            }

        }

        // Populates the campus List
        private void populateCampus()
        {
            campusList.Add(new campus("ON", 10, 70, 200,
                new List<programs> {
                    new programs("Architectural",3500,5),
                    new programs("Law",3500,6) }));

            campusList.Add(new campus("QC", 11, 80, 150,
                new List<programs> {
                    new programs("Architectural",3500,5),
                    new programs("Law",3500,6),
                    new programs("Enginerring",3000,6),
                    new programs("Health",3000,4),
                    new programs("Science and Art",2500,4),
                    new programs("Music",2500,6),
                    new programs("Buisiness", 3000, 5)}));

            campusList.Add(new campus("NS", 10, 80, 150,
                new List<programs> {
                    new programs("Architectural",3500,5),
                    new programs("Law",3500,6),
                    new programs("Health",3000,4),
                    new programs("Music",2500,6),
                    new programs("Buisiness", 3000, 5)}));

            campusList.Add(new campus("NB", 12, 90, 250,
                new List<programs> {
                    new programs("Architectural",3500,5),
                    new programs("Law",3500,6),
                    new programs("Enginerring",3000,6),
                    new programs("Buisiness", 3000, 5)}));

            campusList.Add(new campus("MB", 11, 90, 200,
                new List<programs> {
                    new programs("Architectural",3500,5),
                    new programs("Health",3000,4),
                    new programs("Science and Art",2500,4),
                    new programs("Music",2500,6),
                    new programs("Buisiness", 3000, 5)}));

            campusList.Add(new campus("BC", 12, 90, 200,
                new List<programs> {
                    new programs("Architectural",3500,5),
                    new programs("Law",3500,6),
                    new programs("Enginerring",3000,6),
                    new programs("Health",3000,4),
                    new programs("Science and Art",2500,4),
                    new programs("Music",2500,6),
                    new programs("Buisiness", 3000, 5)}));

            campusList.Add(new campus("PE", 9, 60, 100,
                new List<programs> {
                    new programs("Health",3000,4),
                    new programs("Science and Art",2500,4),
                    new programs("Music",2500,6)}));

            campusList.Add(new campus("SK", 11, 80, 150,
                new List<programs> {
                    new programs("Architectural",3500,5),
                    new programs("Law",3500,6),
                    new programs("Enginerring",3000,6),
                    new programs("Health",3000,4),
                    new programs("Science and Art",2500,4),
                    new programs("Music",2500,6)
                }));

            campusList.Add(new campus("AB", 10, 70, 100,
                new List<programs> {
                    new programs("Architectural",3500,5),
                    new programs("Law",3500,6),
                    new programs("Enginerring",3000,6),
                    new programs("Health",3000,4),
                    new programs("Science and Art",2500,4),
                    new programs("Music",2500,6),
                    new programs("Buisiness", 3000, 5)}));

            campusList.Add(new campus("NL", 11, 80, 150,
                new List<programs> {
                    new programs("Architectural",3500,5),
                    new programs("Enginerring",3000,6),
                    new programs("Health",3000,4)
                }));


        }

        // populates the  locations comboBox
        private bool populateLocations()
        {
            bool accepted = false;
            foreach (campus campus in campusList)
            {
                if (Convert.ToInt32(cmboBox_grade.SelectedItem.ToString()) >= campus.HSGradeReq
                        && Convert.ToInt32(cmboBox_testScore.SelectedItem.ToString()) >= campus.admissionTSReq)
                {
                    cmboBox_location.Items.Add(campus.location);
                    accepted = true;
                }
            }
            return accepted;
        }

        // Populates the Programs comboBox
        private void populatePrograms(string location)
        {
            foreach (campus campus in campusList)
            {
                if (campus.location == location)
                {
                    foreach(var programs in campus.programs)
                    {
                        cmboBox_programs.Items.Add(programs.programName);
                    }
                    break;
                }
            }
        }

        //Changes program length and Total price based on the selected Program
        private void cmboBox_programs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboBox_programs.SelectedIndex != -1)
            {
                foreach (campus campus in campusList)
                {
                    if (campus.location == cmboBox_location.SelectedItem.ToString())
                    {
                        foreach (var programs in campus.programs)
                        {
                            if (programs.programName == cmboBox_programs.SelectedItem.ToString())
                            {
                                setProgramPriceAndLength(campus.regFees + programs.programFees, programs.programDuration);
                            }
                        }
                        break;
                    }
                }
            }
        }

        // Sets the program length and Price 
        private void setProgramPriceAndLength(int price, int length)
        {
            lbl_studyPeriod.Text = length.ToString();
            lbl_totalCost.Text = "$" + price.ToString("0.00");
        }

        // Adds the current student to the registry
        private void btn_register_Click(object sender, EventArgs e)
        {
            if (studentInfoCheck() && cmboBox_programs.SelectedIndex!=-1)
            {
                students.Add(new student(
                    txtBox_firstName.Text,
                    txtBox_lastName.Text,
                    Convert.ToInt32(txtBox_SIN.Text),
                    txtBox_email.Text,
                    Convert.ToInt32(cmboBox_grade.SelectedItem.ToString()),
                    Convert.ToInt32(cmboBox_testScore.SelectedItem.ToString()),
                    cmboBox_location.SelectedItem.ToString(),
                    cmboBox_programs.SelectedItem.ToString()
                    ));

                cmboBox_SIN.Items.Add(txtBox_SIN.Text);
                setDefaults();
            }
        }

        // Sets the Student information and campus selection to their default states
        private void setDefaults()
        {
            txtBox_firstName.Text = "";
            txtBox_lastName.Text = "";
            txtBox_SIN.Text = "";
            txtBox_email.Text = "";
            cmboBox_grade.SelectedIndex = -1;
            cmboBox_testScore.SelectedIndex = -1;

            cmboBox_location.SelectedIndex = -1;
            cmboBox_programs.SelectedIndex = -1;
            cmboBox_location.Enabled = false;
            cmboBox_programs.Enabled = false;
        }

        // Deletes the selected Student
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (cmboBox_SIN.SelectedIndex == -1)
            {
                MessageBox.Show("Must Select a SIN To Delete");
            }
            else
            {
                foreach (student student in students)
                {
                    if (cmboBox_SIN.SelectedItem.ToString() == student.SIN.ToString())
                    {
                        students.Remove(student);
                        cmboBox_SIN.Items.Remove(cmboBox_SIN.SelectedItem.ToString());
                        break;
                    }
                }
                cmboBox_SIN.SelectedIndex = -1;
            }
        }

        // Allows updates of selected Student
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (cmboBox_SIN.SelectedIndex == -1)
            {
                MessageBox.Show("Must Select a SIN To Update");
            }
            else
            {
                foreach (student student in students)
                {
                    if (cmboBox_SIN.SelectedItem.ToString() == student.SIN.ToString())
                    {
                        txtBox_firstName.Text = student.firstName;
                        txtBox_lastName.Text = student.lastName;
                        txtBox_SIN.Text = student.SIN.ToString();
                        txtBox_email.Text = student.Email;
                        cmboBox_testScore.SelectedItem = student.admissionTestScore.ToString();
                        cmboBox_grade.SelectedItem = student.highSchoolGrade.ToString();
                        students.Remove(student);
                        string selectedItem = cmboBox_SIN.SelectedItem.ToString();
                        cmboBox_SIN.SelectedIndex = -1;
                        cmboBox_SIN.Items.Remove(selectedItem);
                        break;
                    }

                }
                cmboBox_SIN.SelectedIndex = -1;
            }
        }

        // Removes all records created in current session
        private void btn_removeAllRecords_Click(object sender, EventArgs e)
        {
            students.Clear();
            setDefaults();
        }

        // Clicks Register Button
        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_register_Click(sender, e);
        }

        // Clicks Update Button
        private void updateRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_update_Click(sender, e);
        }

        // Clicks Delete Button
        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_delete_Click(sender, e);
        }

        // Clicks Remove All Button
        private void deleteAllRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_removeAllRecords_Click(sender, e);
        }

        // Clicks Exit Button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_exit_Click(sender, e);
        }

        // Exits the Program
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Opens a help menu form
        private void readHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }

        // Opens Tech support information form
        private void technicalSupportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TechnicalSupportForm technicalSupportForm = new TechnicalSupportForm();
            technicalSupportForm.Show();
        }

        // Opens About DC Registration Form
        private void aboutDCRegistrationAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDCForm aboutDCForm = new AboutDCForm();
            aboutDCForm.Show();
        }
        // Saves the Registrations to the Json File
        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
            String filePath = Path.Combine(Application.StartupPath, "StudentData.json");
            foreach (student student in students)
            {
                String jsonString = JsonConvert.SerializeObject(student);
                File.AppendAllText(filePath, jsonString+Environment.NewLine);
            }
            btn_removeAllRecords_Click(sender, e);
            MessageBox.Show("Data Successfully Stored");

        }

        // Clicks the Registrations Button
        private void loadRecordsToServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLoadRecords_Click(sender, e);
        }
    }
}
