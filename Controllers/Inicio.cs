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
            //*abre outro form*
            esconderSubMenu();
        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            //*abre outro form*
            esconderSubMenu();
        }

        private void btnFaleConosco_Click(object sender, EventArgs e)
        {
            //*abre outro form*
            esconderSubMenu();
        }

        private void btnPrivacidade_Click(object sender, EventArgs e)
        {
            //*abre outro form*
            esconderSubMenu();
        }
        #endregion

        #region Paciente
        private void btnPaciente_Click(object sender, EventArgs e)
        {
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
            //*abre outro form*
            esconderSubMenu();
        }

        private void btnAgendamento_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Agendamento());
            esconderSubMenu();
        }
        #endregion
    }
}
