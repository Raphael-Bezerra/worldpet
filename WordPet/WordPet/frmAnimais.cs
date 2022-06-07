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
    public partial class frmAnimais : Form
    {
        public frmAnimais()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.animalBindingSource.EndEdit();
                animalTableAdapter.Update(masterDataSet.animal);
                groupBox4.Enabled = false;
                MessageBox.Show("Cadastro Salvo", "WorldPet");

            }
            catch (Exception)
            {

                MessageBox.Show("Ocorreu um erro, verifique os valores informados");
            }
        }

        private void frmAnimais_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.raca'. Você pode movê-la ou removê-la conforme necessário.
            this.racaTableAdapter.Fill(this.masterDataSet.raca);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.masterDataSet.cliente);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.animal'. Você pode movê-la ou removê-la conforme necessário.
            this.animalTableAdapter.Fill(this.masterDataSet.animal);

        }

    

        private void btnAdd_Click(object sender, EventArgs e)
        {
            animalBindingSource.AddNew();
            groupBox4.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente excluir cadastro", "WorldPet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    animalBindingSource.RemoveCurrent();
                    animalTableAdapter.Update(masterDataSet.animal);
                }

            }
            catch (Exception)
            {
                animalTableAdapter.Fill(masterDataSet.animal);
                MessageBox.Show("Cadastro não pode ser Excluído");

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            animalBindingSource.CancelEdit();
            groupBox4.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;
        }

     

        private void btnPhoto_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Fotos (.jpg; *.png;) | *.jpg; .png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ani_fotoPictureBox.Image = new Bitmap(openFileDialog1.FileName);
            }
        }


    }
    }
 

