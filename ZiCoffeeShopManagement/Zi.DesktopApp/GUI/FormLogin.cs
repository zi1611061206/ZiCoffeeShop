using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zi.DesktopApp.GUI
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void ExitApplication()
        {
            var result = MessageBox.Show("message", "caption", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void picEye_Click(object sender, EventArgs e)
        {
            txbPassword.UseSystemPasswordChar = !txbPassword.UseSystemPasswordChar;
            if (txbPassword.UseSystemPasswordChar)
            {
                picEye.Image = Properties.Resources.openedEyes;
            }
            else
            {
                picEye.Image = Properties.Resources.closedEyes;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            formBusiness formBusiness = new formBusiness();
            Hide();
            formBusiness.ShowDialog();
            Show();
        }
    }
}
