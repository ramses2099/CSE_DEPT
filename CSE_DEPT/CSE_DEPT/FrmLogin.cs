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
    public partial class FrmLogin : Form
    {
        #region "PROPERTYS AND FUNCTION"

        public string UserName { get { return this.txtUserName.Text;  } }
        public string Password { get { return this.txtPassword.Text; } }

        #endregion


        public FrmLogin()
        {
            InitializeComponent();
        }
               
        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
