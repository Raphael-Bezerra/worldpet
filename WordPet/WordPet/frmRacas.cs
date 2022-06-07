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
    public partial class frmRacas : Form
    {
        public frmRacas()
        {
            InitializeComponent();
        }

        private void racaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.racaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.racaBindingSource.EndEdit();
                racaTableAdapter.Update(masterDataSet.raca);
                groupBox2.Enabled = false;
                MessageBox.Show("Cadastro Salvo", "WorldPet");

            }
            catch (Exception)
            {

                MessageBox.Show("Ocorreu um erro, verifique os valores informados");
            }

        }

        private void frmRacas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.raca'. Você pode movê-la ou removê-la conforme necessário.
            this.racaTableAdapter.Fill(this.masterDataSet.raca);

        }

        private void raca_codigoLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            racaBindingSource.AddNew();
            groupBox2.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente excluir cadastro", "WorldPet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    racaBindingSource.RemoveCurrent();
                    racaTableAdapter.Update(masterDataSet.raca);
                }

            }
            catch (Exception)
            {
                racaTableAdapter.Fill(masterDataSet.raca);
                MessageBox.Show("Cadastro não pode ser Excluído");

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }
    }
}
