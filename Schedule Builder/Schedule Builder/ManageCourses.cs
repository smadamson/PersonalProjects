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
    public partial class ManageCourses : Form
    {
        public ManageCourses()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens the AddCourse menu, closes this window.
        /// </summary>
        private void addCourse_Click(object sender, EventArgs e)
        {
            ScheduleBuilderApplicationContext.getAppContext().RunForm(new AddCourse());
            this.Close();
        }

        /// <summary>
        /// Cloeses this form and accepts the changes. 
        /// </summary>
        private void acceptGoBack_Click(object sender, EventArgs e)
        {
            //TODO: add course to the student. 
            this.Close();
        }
    }
}
