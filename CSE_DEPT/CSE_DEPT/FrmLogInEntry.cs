using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSE_DEPT.Services;
using CSE_DEPT.Entities;

namespace CSE_DEPT
{
    public partial class FrmLogInEntry : Form
    {


        #region "PROPERTYS AND FUNCTION"

        public string UserName { get { return this.txtuser_name.Text; } }
        public string Password { get { return this.txtpass_word.Text; } }
        public string LoginId { get { return this.txtlogin_id.Text; } }
        
        #endregion
        

        public FrmLogInEntry()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                using (LogInService service = new LogInService())
                {

                    LogIn logIn = new LogIn() {
                        Login_id = this.LoginId,
                        Pass_word = this.Password,
                        User_name = this.UserName,
                        Faculty_id= "B66750",
                        Student_id = "J77896"
                    };

                    service.CrateObject(logIn);

                    MessageBox.Show(this, "Usuario Usuario Creado Conrrectamente", "CSE_DEPT", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
