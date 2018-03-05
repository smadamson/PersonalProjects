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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the students information from the University database. Opens the students Homescreen. 
        /// Closes this form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Click(object sender, EventArgs e)
        {
            //Open the homeScreen
            ScheduleBuilderApplicationContext.getAppContext().RunForm(new HomeScreen());

            //TODO: load information into that page. 
            this.Close();
        }

        /// <summary>
        /// Opens the NewStudent view. Closes this form. 
        /// </summary>
        private void newStudent_Click(object sender, EventArgs e)
        {
            //Open the newStudent view
            NewStudent ns = new NewStudent(id.Text, firstName.Text);
            ScheduleBuilderApplicationContext.getAppContext().RunForm(new NewStudent());

            this.Close();
        }
    }
}
