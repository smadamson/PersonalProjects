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
    class UofUCourse
    {
        /// <summary>
        /// prereqs that must be taken before this course
        /// </summary>
        private List<UofUCourse> prereqs;

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
        public string course
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
        public UofUCourse(string subject, int number, List<UofUCourse> prereqs, bool fall, bool spring, bool summer)
        {
            this.subject = subject;
            this.number = number;
            this.course = subject + " " + number;
            this.prereqs = prereqs;
            this.fall = fall;
            this.spring = spring;
            this.summer = summer;
        }

    }
}
