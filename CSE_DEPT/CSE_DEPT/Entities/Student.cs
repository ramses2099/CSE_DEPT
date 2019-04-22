using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE_DEPT.Entities
{
    class Student
    {
        //fields
        private string _student_id;
        private string _student_name;
        private decimal _gpa;
        private string _credit;
        private string _major;
        private string _schoolYear;
        private string _email;


        //constructores
        public Student() { }

        public Student(string student_id, string student_name, decimal gpa, string credit,
           string major, string schoolYear, string email)
        {
            this._student_id = student_id;
            this._student_name = student_name;
            this._gpa = gpa;
            this._credit = credit;
            this._major = major;
            this._schoolYear = schoolYear;
            this._email = email;
        }

        //propertys
        public string Student_id { get { return this._student_id; } set { this._student_id = value; } }
        public string Student_name { get { return this._student_name; } set { this._student_name = value; } }
        public decimal Gpa { get { return this._gpa; } set { this._gpa = value; } }
        public string Credit { get { return this._credit; } set { this._credit = value; } }
        public string Major { get { return this._major; } set { this._major = value; } }
        public string SchoolYear { get { return this._schoolYear; } set { this._schoolYear = value; } }
        public string Email { get { return this._email; } set { this._email = value; } }
        

    }
}
