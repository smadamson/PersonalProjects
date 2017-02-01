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
    public partial class NewStudent : Form
    {

        public NewStudent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generates a NewStudent form with the given id and firstName filled in. 
        /// </summary>
        public NewStudent(string id, string firstName)
        {
            InitializeComponent();
            this.id.Text = id;
            this.firstName.Text = firstName;
            this.lastName.Focus();
        }


        /// <summary>
        /// Adds this student to the University and opens the students homeScreen. Closes this form.
        /// </summary>
        private void submit_Click(object sender, EventArgs e)
        {
            //go to home screen for this student.
            //TODO: add student to the university. 
            ScheduleBuilderApplicationContext.getAppContext().RunForm(new HomeScreen());
            this.Close();
        }

        /// <summary>
        /// Makes a masters field visible.
        /// </summary>
        private void AddMasters_Click(object sender, EventArgs e)
        {

        }
    }
}
