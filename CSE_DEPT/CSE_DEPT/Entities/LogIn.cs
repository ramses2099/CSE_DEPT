using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE_DEPT.Entities
{
    class LogIn
    {
        public LogIn() { }

        public LogIn(string login_id,string user_name,string pass_word,string faculty_id,string student_id) {
            this.Login_id = login_id;
            this.Faculty_id = faculty_id;
            this.Pass_word = pass_word;
            this.User_name = user_name;
            this.Student_id = student_id;

        }
        
        public string Login_id { get; set; }
        public string User_name { get; set; }
        public string Pass_word { get; set; }
        public string Faculty_id { get; set; }
        public string Student_id { get; set; }
        

    }
}
