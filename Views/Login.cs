using check_health.Controllers;
using check_health.Models;
using check_health.Models.ModelCadastroeLogin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check_health.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UsuarioLogin user = new UsuarioLogin();
            Controller.LoginDados(txtEmail.Text, txtSenha.Text, out user);

            if (user.idPaciente != 0)
            {
                LoginAtual.Email = txtEmail.Text.ToString();
                MessageBox.Show("Login efetuado!");

                this.Hide();
            }
            else
            {
                MessageBox.Show("E-mail ou Senha incorreta");
            }
        }
    }
}
