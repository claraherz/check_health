using System;
using System.Windows.Forms;

namespace check_health.Views
{
    public partial class Agendamento : Form
    {
        public Agendamento()
        {
            InitializeComponent();
        }

        private void Agendamento_Load(object sender, EventArgs e)
        {
            List<string> especialidade = new List<string>();
            Controller.EspecialiadeController(especialidade);
            foreach (var item in especialidade)
            {
                comboBoxEspecialidade.Items.Add(item);
            }
        }

        private void comboBoxEspecialidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> medico = new List<string>();
            Controller.MedicoController(comboBoxEspecialidade.Text, medico);

            foreach (var item in medico)
            {
                comboBoxProfissional.Items.Add(item);
            }
        }
    }
}
