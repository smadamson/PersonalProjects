using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule_Builder
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }
        

        /// <summary>
        /// Closes the window and adds the course to the stuents course list. 
        /// Returns to the ManageCourses view. 
        /// </summary>
        private void Done_Click(object sender, EventArgs e)
        {
            AddCourseToStudent(CourseAbbr.Text, CourseValue.Text, taken.Checked);
            ScheduleBuilderApplicationContext.getAppContext().RunForm(new ManageCourses());
            this.Close();
        }

        private void DoesNotExistDialog()
        {
            DialogResult dialogResult = MessageBox.Show("This course does not exist in the University Database. Would you like to add it?", "Does not exist", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                AddToUniversity course = new AddToUniversity(this.CourseAbbr.Text, this.CourseValue.Text);
                ScheduleBuilderApplicationContext.getAppContext().RunForm(course);

                //TODO: after this is complete, submit this form. 
                this.Close();

            }
            else if (dialogResult == DialogResult.No)
            {
                //close the message box. 
                Close();
            }
        }

        /// <summary>
        /// Accepts the changed course, clears the forms to add another class
        /// </summary>
        private void AddAnother_Click(object sender, EventArgs e)
        {
            //Add the course to the student
            AddCourseToStudent(CourseAbbr.Text, CourseValue.Text, taken.Checked);
            CourseAbbr.Text = "";
            CourseValue.Text = "";
            taken.Checked = false;
        }
        
        /// <summary>
        /// Adds a course to this students courses. 
        /// </summary>
        private void AddCourseToStudent(string courseAbbr, string courseValue, bool taken)
        {
            //TODO: Implement

            //If the course does not exist in the university database allows the user to enter it there.
            DoesNotExistDialog();

        }
        /// <summary>
        /// Does not accept any changes, closes the form.
        /// </summary>
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
