using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE_DEPT.Entities
{
    class Faculty
    {

        public Faculty() { }

        public Faculty(string fculty_id, string faculty_name, string office, string phone, string college,
            string title, string email)
        {

            this.Faculty_id = fculty_id;
            this.Faculty_name = faculty_name;
            this.Office = office;
            this.Phone = phone;
            this.College = college;
            this.Title = title;
            this.Email = email;

        }

        public string Faculty_id { get; set; }
        public string Faculty_name { get; set; }
        public string Office { get; set; }
        public string Phone { get; set; }
        public string College { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }


    }
}
