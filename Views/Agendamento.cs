using check_health.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace check_health.Views
{
    public partial class Agendamento : Form
    {
        public Agendamento()
        {
            InitializeComponent();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            comboBoxHorario.Items.Remove(comboBoxHorario.SelectedItem);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calendario_ValueChanged(object sender, EventArgs e)
        {
            comboBoxHorario.Items.Clear();

            List<string> hora = new List<string>();

            Controller.HoraConsulta(hora);
            foreach (var item in hora)
            {
                comboBoxHorario.Items.Add(item);
            }
        }

        private void Agendamento_Load_1(object sender, EventArgs e)
        {
            List<string> especialidade = new List<string>();
            Controller.EspecialiadeController(especialidade);
            foreach (var item in especialidade)
            {
                comboBoxEspecialidade.Items.Add(item);
            }

            List<string> hora = new List<string>();

            Controller.HoraConsulta(hora);
            foreach (var item in hora)
            {
                comboBoxHorario.Items.Add(item);
            }

        }

        private void comboBoxEspecialidade_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBoxProfissional.Items.Clear(); 

            List<string> nome = new List<string>();
            Controller.MedicoController(comboBoxEspecialidade.Text, nome);

            foreach (var item in nome)
            {
                comboBoxProfissional.Items.Add(item);
            }
        }

        private void comboBoxHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
