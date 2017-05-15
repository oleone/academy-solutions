﻿using AcademySolution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademySolution
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public Login login = new Login();

        public frmLogin()
        {
            if (login._LogOut == false)
            {
                Thread t = new Thread(new ThreadStart(Loading));
                //Inicializado
                t.Start();
                for (int i = 0; i <= 5; i++)
                {
                    Thread.Sleep(1000);
                }
                //Completo
                t.Abort();
                
                InitializeComponent();
                this.Show();

            }
            else if(login._LogOut == true)
            {
                InitializeComponent();
                this.Show();
            }
        }

        public void Loading()
        {
            frmSplashScreen frm = new frmSplashScreen();
            Application.Run(frm);
        }

        //BOTÕES
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbUsername.Clear();
            txbPassword.Clear();
            txbUsername.Focus();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txbUsername.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            login._LogOut = true;
            Application.Exit();
        }

        private void txbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txbPassword.Focus();
        }

        private void txbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnEntrar.PerformClick();
        }
        
        private void btnEntrar_Click(object sender, EventArgs e)
        {

            //Validação de login
            login.ValidaLogin(txbUsername.Text, txbPassword.Text);
            try
            {
                using(AcademySolutionEntities academy = new AcademySolutionEntities())
                {
                    var query = from o in academy.TblLogins
                                where o.Username == txbUsername.Text && o.Password == txbPassword.Text
                                select o;
                    if (query.SingleOrDefault() != null)
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            //Se logado
            if (login.Status == true)
            {
                login.Logar();

                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();
            }
            //Se não logado
            else
            {
                MetroFramework.MetroMessageBox.Show(this, $"{login._error}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbUsername.Focus();
                return;
            }
        }
    }
}