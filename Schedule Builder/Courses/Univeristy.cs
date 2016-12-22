using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpreadsheetUtilities;

namespace Schedule_Builder
{
    /// <summary>
    /// This class maintains the relationship between all courses in the University. 
    /// </summary>
    class University
    {
        Dictionary<String, Course> allCourses;

        private string name;

        private DependencyGraph courseDependencies;

        public University(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Adds the course to the university. 
        /// </summary>
        /// <param name="course"></param>
        public void AddCourse(Course course)
        {
            //TODO: make a generic dependency class
            //TODO: what if the prereq does not exist yet?
            //TODO: is a dependency graph really necessary?
            foreach(Course c in course.prereqs)
            {
                //prereq, course
                courseDependencies.AddDependency(c.name, course.name);
                //I wish I could pass objects into this. 
            }
            allCourses.Add(course.name, course);
        }
    }
}
