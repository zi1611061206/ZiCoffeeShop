﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zi.DesktopApp.GUI
{
    public partial class formBusiness : Form
    {
        #region Form Move (Keep and move form on screen)
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion

        public formBusiness()
        {
            InitializeComponent();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picMaximize_Click(object sender, EventArgs e)
        {
            FormWindowState state = FormWindowState.Normal;
            if (WindowState == FormWindowState.Normal)
            {
                state = FormWindowState.Maximized;
            }
            WindowState = state;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            pnlAccountSideBar.Size = new Size(40, pnlAccountSideBar.Size.Height);
            picShow.Show();
            picHide.Hide();
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            pnlAccountSideBar.Size = new Size(300, pnlAccountSideBar.Size.Height);
            picShow.Hide();
            picHide.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FormChangePassword formChangePassword = new FormChangePassword();
            formChangePassword.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            FormOrder formOrder = new FormOrder();
            formOrder.Show();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            FormCheckout formCheckout = new FormCheckout();
            formCheckout.Show();
        }
    }
}
