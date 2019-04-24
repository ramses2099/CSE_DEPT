using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSE_DEPT
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void tlstrMnuItemAbout_Click(object sender, EventArgs e)
        {
            frmAbaout frmAbaout = new frmAbaout();
            // Set the Parent Form of the Child window.  
            frmAbaout.MdiParent = this;
            // Display the new form.  
            frmAbaout.Show();
        }

        private void tlstrMnuItemExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Esta seguro que desea salir del sistema", "CSE DPT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            //
            if (dialog == DialogResult.OK) {
                Application.Exit();
            }

        }

        private void tlstrMnuItemLogIn_Click(object sender, EventArgs e)
        {
            FrmLogInEntry frmLogInEntry = new FrmLogInEntry();
            // Set the Parent Form of the Child window.  
            frmLogInEntry.MdiParent = this;
            // Display the new form.  
            frmLogInEntry.Show();
        }
    }
}
