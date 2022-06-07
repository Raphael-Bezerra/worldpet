using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPet
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void panelCenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCloser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair", "WordPet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmCadCliente cliente = new frmCadCliente();
            cliente.TopLevel = false;
            cliente.Dock = DockStyle.Fill;
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(cliente);
            cliente.Show();

            panelSelect.Top = btnClientes.Top;
        }

        private void btnRaca_Click(object sender, EventArgs e)
        {
            frmRacas racas = new frmRacas();
            racas.TopLevel = false;
            racas.Dock = DockStyle.Fill;
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(racas);
            racas.Show();

            panelSelect.Top = btnRaca.Top;
        }

        private void btnAnimais_Click(object sender, EventArgs e)
        {
            frmAnimais animais = new frmAnimais();
            animais.TopLevel = false;
            animais.Dock = DockStyle.Fill;
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(animais);
            animais.Show();
           
            panelSelect.Top = btnAnimais.Top;
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            frmServicos servicos = new frmServicos();
            servicos.TopLevel = false;
            servicos.Dock = DockStyle.Fill;
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(servicos);
            servicos.Show();

            panelSelect.Top = btnServicos.Top;
        }

        private void btnAgendamentos_Click(object sender, EventArgs e)
        {
            frmAgendas agendas = new frmAgendas();
            agendas.TopLevel = false;
            agendas.Dock = DockStyle.Fill;
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(agendas);
            agendas.Show();

            panelSelect.Top = btnAgendamentos.Top;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panelCenter.Controls.Clear();

            //panelSelect.Visible = false;

            panelSelect.Top = btnInicio.Top;

        }

        private void panelSide_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
