using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using check_health.Controllers;
using System.Windows.Forms;

namespace check_health.Views
{
    public partial class lblProfissional : Form
    {
        public lblProfissional()
        {
            InitializeComponent();
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            


        }

        private void Consultas_Load_1(object sender, EventArgs e)
        {
            Consulta dados = new Consulta();

            Controller.SelectConsulta(dados);

            lblConsulta.Text = dados.DataConsulta;
            lblHorarioConsulta.Text = dados.Horario;
            lblProfissionalConsulta.Text = dados.Profissional;
            lblEspecialidade.Text = dados.Especialidade;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
