using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Builder
{
    public enum Requirement { PreMajor, GenEd, Major, MajorElective };

    /// <summary>
    /// Class defines a major at a university
    /// </summary>
    class Major
    {
        public string name;

        /// <summary>
        /// A list of all the courses that can satisfy a majors elective requirement
        /// </summary>
        private List<Course> majorElectives;

        /// <summary>
        /// A list of specific courses, all of which must be taken before obtaining a degeree.
        /// </summary>
        private List<Course> specificCourses;

        private int numberOfElectives;

        /// <summary>
        /// Creates a major with the given name and the given list of requirements. 
        /// </summary>
        public Major(string name, List<Course> courses, List<Course> electives, int numberOfElectives)
        {
            //a major has requirements
            this.name = name;
            this.specificCourses = courses;
            this.majorElectives = electives;
            this.numberOfElectives = numberOfElectives;
        }
    }
}
