using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE_DEPT.Entities
{
    class StudentCourse
    {

        public StudentCourse() { }

        public StudentCourse(int s_course_id, string student_id, string course_id, string credit, string major)
        {
            this.S_course_id = s_course_id;
            this.Student_id = student_id;
            this.Course_id = course_id;
            this.Credit = credit;
            this.Major = major;
        }

        public int S_course_id { get; set; }
        public string Student_id { get; set; }
        public string Course_id { get; set; }
        public string Credit { get; set; }
        public string Major { get; set; }


    }
}
