﻿using System;
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
    public partial class AddToUniversity : Form
    {
        public AddToUniversity()
        {
            InitializeComponent();
        }

        public AddToUniversity(string courseAbbr, string courseValue)
        {
            InitializeComponent();

            this.CourseAbbr.Text = courseAbbr;
            this.CourseValue.Text = courseValue;
            this.CrHours.Text = "";

        }

        /// <summary>
        /// Displays more fields for prerequsites.
        /// </summary>
        private void AddAnother1_Click(object sender, EventArgs e)
        {
            //Set this button to be invisible and set the other prereqs to be visible. Resize the 
            //the form. 
            this.Height = 270;
            this.Prereq2CourseAbbr.Visible = true;
            this.Prereq2CourseValue.Visible = true;
            this.AddAnother2.Visible = true;
            this.AddAnother1.Visible = false;
        }

        /// <summary>
        /// Displays more fields for prerequsites.
        /// </summary>
        private void AddAnother2_Click(object sender, EventArgs e)
        {
            this.Height = 295;
            this.Prereq3CourseAbbr.Visible = true;
            this.Prereq3CourseValue.Visible = true;
            this.AddAnother3.Visible = true;
            this.AddAnother2.Visible = false;
        }

        /// <summary>
        /// Displays more fields for prerequsites.
        /// </summary>
        private void AddAnother3_Click(object sender, EventArgs e)
        {
            this.Height = 320;
            this.Prereq4CourseAbbr.Visible = true;
            this.Prereq4CourseValue.Visible = true;
            this.AddAnother3.Visible = false;
        }

        /// <summary>
        /// Saves the classes information into some data structure. 
        /// Goes back to the AddCourse Screen. 
        /// </summary>
        private void AddClass_Click(object sender, EventArgs e)
        {
            //TODO: Add the course to the university
            ScheduleBuilderApplicationContext.getAppContext().RunForm(new AddCourse());
            this.Close();
        }

        /// <summary>
        /// Closes the form and returns to the AddCourse Screen. 
        /// </summary>
        private void Cancel_Click(object sender, EventArgs e)
        {
            ScheduleBuilderApplicationContext.getAppContext().RunForm(new AddCourse());
            this.Close();
        }
    }
}
