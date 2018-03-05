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
    public partial class HomeScreen : Form
    {
        /// <summary>
        /// This is where the students information is displayed. This is the screen where all of the students
        /// information can be accessed and from where a plan can be generated. 
        /// </summary>
        public HomeScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens the ManageCourses view. Does not close homeScreen.
        /// </summary>
        private void manageCourses_Click(object sender, EventArgs e)
        {
            ScheduleBuilderApplicationContext.getAppContext().RunForm(new ManageCourses());
        }

        /// <summary>
        /// Opens the EditMajors view. Does not Close homescreen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editMajors_Click(object sender, EventArgs e)
        {
            ScheduleBuilderApplicationContext.getAppContext().RunForm(new EditMajors());
        }

        /// <summary>
        /// Returns to the login screen view. 
        /// </summary>
        private void logout_Click(object sender, EventArgs e)
        {
            ScheduleBuilderApplicationContext.getAppContext().RunForm(new LoginScreen());
            this.Close();
        }

        /// <summary>
        /// Generates a plan view. This button was why I started the project.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewMyPlan_Click(object sender, EventArgs e)
        {
            ScheduleBuilderApplicationContext.getAppContext().RunForm(new PlanView());
            this.Close();
        }
    }
}
