﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UINomina
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;


        private void PBCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PBMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin login = new();
            login.Show();
            this.Hide();
        }
        private void AbrirFormHija(object form)
        {
            if (this.panelContenedor != null && this.panelContenedor.Controls.Count > 0)
            {
                var existingForm = this.panelContenedor.Controls[0] as Form;
                if (existingForm != null)
                {
                    existingForm.Close();
                    existingForm.MouseDown -= FrmPrincipal_MouseDown; 
                }
            }

            Form frm = form as Form;
            if (frm != null)
            {
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(frm);
                this.panelContenedor.Tag = frm;
                frm.Show();
                frm.MouseDown += FrmPrincipal_MouseDown; 
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmConfiguraciones());
        }

        private void PBCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PBMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}