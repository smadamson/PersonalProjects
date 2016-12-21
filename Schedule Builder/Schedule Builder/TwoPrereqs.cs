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
    public partial class TwoPrereqs : Form
    {
        public TwoPrereqs()
        {
            InitializeComponent();
        }
        public TwoPrereqs(string courseAbbr, string courseValue, string crHours, bool fall, bool spring, bool summer, string prCourseAbbr, string prCourseValue)
        {

            InitializeComponent();

            CourseAbbr.Text = courseAbbr;
            CourseValue.Text = courseValue;
            CrHours.Text = crHours;
            Fall.Checked = fall;
            Spring.Checked = spring;
            Summer.Checked = summer;
            Prereq1CourseAbbr.Text = prCourseAbbr;
            Prereq1CourseValue.Text = prCourseValue;

        }
        private void AddAnother_Click(object sender, EventArgs e)
        {
            //Open ThreePreqs form maintaing text fields values
        }
    }
}
