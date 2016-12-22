using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Builder
{
    class Student
    {
        public Major major { get; set; }

        public string name { get; private set; }
        public int ID { get; private set; }

        /// <summary>
        /// Creates a student object. A student has a name, ID, and a university?
        /// </summary>
        public Student(string name, int ID, Major major)
        {
            this.name = name;
            this.ID = ID;
            //TODO: students can have more than one major.
            this.major = major;
        }
    }
}
