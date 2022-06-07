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
    public partial class frmServicos : Form
    {
        public frmServicos()
        {
            InitializeComponent();
        }

        private void servicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void frmServicos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.servico'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoTableAdapter.Fill(this.masterDataSet.servico);

        }

        private void serv_tempoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void serv_codigoLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
