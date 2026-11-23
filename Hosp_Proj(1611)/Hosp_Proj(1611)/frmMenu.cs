using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hosp_Proj_1611_
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void médicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // CRIEI ERRADO
        }

        private void médicoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMedico frmMedico = new frmMedico();
            frmMedico.Show();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaciente frmPaciente = new frmPaciente();
            frmPaciente.Show();
        }

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgendamento frmAgenda = new frmAgendamento();
            frmAgenda.Show();
        }

        private void atendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAtendimento frmAtend = new frmAtendimento();
            frmAtend.Show();
        }

        private void listagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListagens frmListagens = new frmListagens();
            frmListagens.Show();
        }
    }
}
