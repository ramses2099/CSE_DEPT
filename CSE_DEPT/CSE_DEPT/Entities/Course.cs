using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE_DEPT.Entities
{
    class Course
    {
        public Course() { }

        public Course(string course_id, string courseName, int credit, string classRoom,
        string schedule, int enrollment, string faculty_id)
        {
            this.Course_id = course_id;
            this.CourseName = courseName;
            this.Credit = credit;
            this.ClassRoom = classRoom;
            this.Schedule = schedule;
            this.Enrollment = enrollment;
            this.Faculty_id = faculty_id;


        }

        public string Course_id { get; set; }
        public string CourseName { get; set; }
        public int Credit { get; set; }
        public string ClassRoom { get; set; }
        public string Schedule { get; set; }
        public int Enrollment { get; set; }
        public string Faculty_id { get; set; }

    }
}
