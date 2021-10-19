using check_health.Models;
using check_health.Models.ModelCadastroeLogin;
using check_health.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check_health
{
    public partial class FormCheckHealth : Form
    {
        public UsuarioLogin user;
        
        public FormCheckHealth()
        {
            InitializeComponent();
            customizarDesign();
        }
        #region Funções
        private void customizarDesign()
        {
            painelSobreNos.Visible = false;
            painelPaciente.Visible = false;
        }

        private void esconderSubMenu()
        {
            if (painelSobreNos.Visible == true)
                painelSobreNos.Visible = false;
            if (painelPaciente.Visible == true)
                painelPaciente.Visible = false;
        }
        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                esconderSubMenu();
                subMenu.Visible = true;
                if (!string.IsNullOrEmpty(LoginAtual.Email) && btnConsultas.Visible == false && btnAgendamento.Visible == false)
                {
                    btnConsultas.Visible = true;
                    btnAgendamento.Visible = true;
                }
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private Form activeForm = null;
        private void abrirChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            painelChildForm.Controls.Add(childForm);
            painelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        #region Sobre Nós
        private void btnSobreNos_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(painelSobreNos);
        }

        private void btnQuemSomos_Click(object sender, EventArgs e)
        {
            abrirChildForm(new QuemSomos());
            esconderSubMenu();
        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Colaboradores());
            esconderSubMenu();
        }

        private void btnFaleConosco_Click(object sender, EventArgs e)
        {
            abrirChildForm(new FaleConosco());
            esconderSubMenu();
        }

        #endregion

        #region Paciente
        private void btnPaciente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LoginAtual.Email) && btnConsultas.Visible == false && btnAgendamento.Visible == false)
            {
                btnConsultas.Visible = true;
                btnAgendamento.Visible = true;
            }
            mostrarSubMenu(painelPaciente);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Login());
            esconderSubMenu();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Cadastro());
            esconderSubMenu();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Consultas());
            esconderSubMenu();
        }

        private void btnAgendamento_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Agendamento());
            esconderSubMenu();
        }
        #endregion

        private void FormCheckHealth_Load(object sender, EventArgs e)
        {
            btnConsultas.Visible = false;
            btnAgendamento.Visible = false;      
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
