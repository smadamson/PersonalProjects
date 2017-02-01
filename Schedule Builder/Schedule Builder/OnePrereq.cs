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
    public partial class OnePrereq : Form
    {
        public OnePrereq()
        {
            InitializeComponent();
        }

        private void AddPrereq_Click(object sender, EventArgs e)
        {
            //Open the Two Prereqs form saving the text information that existed in the current fields. 
            ScheduleBuilderApplicationContext.getAppContext().RunForm(new TwoPrereqs(CourseAbbreviation.Text, CourseValue.Text, CrHours.Text, Fall.Checked, Spring.Checked, Summer.Checked, PrereqCourseAbbreviation.Text, PrereqCourseValue.Text ));
            this.Close();
        }

    }
}
