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
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                this.Validate();
                this.clienteBindingSource.EndEdit();
                clienteTableAdapter.Update(masterDataSet.cliente);
                groupBox1.Enabled = false;
                MessageBox.Show("Cadastro Salvo","WorldPet");

            }
            catch (Exception)
            {

                MessageBox.Show("Ocorreu um erro, verifique os valores informados");
            }
            

        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.masterDataSet.cliente);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void clienteBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clienteBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente excluir cadastro", "WorldPet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clienteBindingSource.RemoveCurrent();
                    clienteTableAdapter.Update(masterDataSet.cliente);
                }

            }
            catch (Exception)
            {
                clienteTableAdapter.Fill(masterDataSet.cliente);
                MessageBox.Show("Cadastro não pode ser Excluído");
               
            }
           
        }

        private void cli_cpfLabel_Click(object sender, EventArgs e)
        {

        }

        private void cli_enderecoLabel_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {


        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Fotos (.jpg; *.png;) | *.jpg; .png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                cli_fotoPictureBox.Image = new Bitmap(openFileDialog1.FileName);           
            }
        }
    }
}
