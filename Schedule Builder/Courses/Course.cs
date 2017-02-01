using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Builder
{
    /// <summary>
    /// Class representation of a UofUCourse.
    /// </summary>
    class Course
    {
        /// <summary>
        /// prereqs that must be taken before this course
        /// </summary>
        public List<Course> prereqs { get; private set; }

        /// <summary>
        /// Terms this course is being offered. 
        /// </summary>
        private bool spring;
        private bool summer;
        private bool fall;

        /// <summary>
        /// Course subject abbreviation.
        /// </summary>
        private string subject;

        /// <summary>
        /// Course number
        /// </summary>
        private int number;

        /// <summary>
        /// The course subject and number
        /// </summary>
        public string name
        {
            get
            {
                return subject + " " + number;
            }
            private set
            {
            }
        }

        /// <summary>
        /// A course
        /// </summary>
        public Course(string subject, int number, List<Course> prereqs, bool fall, bool spring, bool summer)
        {
            this.subject = subject;
            this.number = number;
            this.name = subject + " " + number;
            this.prereqs = prereqs;
            this.fall = fall;
            this.spring = spring;
            this.summer = summer;
        }

    }
/*
    class Requirement
    {
        /// <summary>
        /// A requirement can be... 
        /// Pre-Major Requirement
        /// Gen. Edu.
        /// Math/Science Elective
        /// Major Requirment
        /// Major Elective
        /// </summary>
        public Requirement(string requrement)
        {

        }
    }*/
}
