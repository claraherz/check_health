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

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Agendamento_Load_1(object sender, EventArgs e)
        {

            comboBoxProfissional.Items.Clear();

            List<string> nome = new List<string>();
            Controller.MedicoController(comboBoxEspecialidade.Text, nome);

            foreach (var item in nome)
            {
                comboBoxProfissional.Items.Add(item);
            }
            List<string> especialidade = new List<string>();
            Controller.EspecialiadeController(especialidade);
            foreach (var item in especialidade)
            {
                comboBoxEspecialidade.Items.Add(item);
            }
            List<int> dia = new List<int>();
            Controller.ComboDia(dia);

            foreach (var item in dia)
            {
                comboBoxDia.Items.Add(item);
            }

            List<int> ano = new List<int>();
            Controller.ComboAno(ano);

            foreach (var item in ano)
            {
                comboBoxAno.Items.Add(item);
            }

            List<string> mes = new List<string>();
            Controller.ComboMes(mes);

            foreach (var item in mes)
            {
                comboBoxMes.Items.Add(item);
            }

            List<string> hora = new List<string>();

            Controller.HoraConsulta(hora);
            foreach (var item in hora)
            {
                comboBoxHorario.Items.Add(item);
            }
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            string data = comboBoxDia.Text + " de " + comboBoxMes.Text;
            Controller.Consulta(data, comboBoxHorario.Text, comboBoxProfissional.Text, comboBoxEspecialidade.Text);
            comboBoxHorario.Items.Remove(comboBoxHorario.SelectedItem);
            this.Hide();
        }

        private void comboBoxEspecialidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxProfissional.Items.Clear();

            List<string> nome = new List<string>();
            Controller.MedicoController(comboBoxEspecialidade.Text, nome);

            foreach (var item in nome)
            {
                comboBoxProfissional.Items.Add(item);
            }
        }
    }
}
