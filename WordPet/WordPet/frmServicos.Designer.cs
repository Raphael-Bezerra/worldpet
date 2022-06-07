namespace WordPet
{
    partial class frmServicos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label serv_codigoLabel;
            System.Windows.Forms.Label serv_descricaoLabel;
            System.Windows.Forms.Label serv_precoLabel;
            System.Windows.Forms.Label serv_tempoLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.masterDataSet = new WordPet.masterDataSet();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicoTableAdapter = new WordPet.masterDataSetTableAdapters.servicoTableAdapter();
            this.tableAdapterManager = new WordPet.masterDataSetTableAdapters.TableAdapterManager();
            this.serv_codigoLabel1 = new System.Windows.Forms.Label();
            this.serv_descricaoTextBox = new System.Windows.Forms.TextBox();
            this.serv_precoTextBox = new System.Windows.Forms.TextBox();
            this.serv_tempoTextBox = new System.Windows.Forms.TextBox();
            this.servicoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnFirstItem = new System.Windows.Forms.ToolStripButton();
            this.btnPreviousItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNextItem = new System.Windows.Forms.ToolStripButton();
            this.btnLastItem = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btDelete = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            serv_codigoLabel = new System.Windows.Forms.Label();
            serv_descricaoLabel = new System.Windows.Forms.Label();
            serv_precoLabel = new System.Windows.Forms.Label();
            serv_tempoLabel = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingNavigator)).BeginInit();
            this.servicoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(366, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(8, 8);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(serv_codigoLabel);
            this.groupBox3.Controls.Add(this.serv_codigoLabel1);
            this.groupBox3.Controls.Add(serv_descricaoLabel);
            this.groupBox3.Controls.Add(this.serv_descricaoTextBox);
            this.groupBox3.Controls.Add(serv_precoLabel);
            this.groupBox3.Controls.Add(this.serv_precoTextBox);
            this.groupBox3.Controls.Add(serv_tempoLabel);
            this.groupBox3.Controls.Add(this.serv_tempoTextBox);
            this.groupBox3.Enabled = false;
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 393);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cadastrar Serviços";
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataMember = "servico";
            this.servicoBindingSource.DataSource = this.masterDataSet;
            // 
            // servicoTableAdapter
            // 
            this.servicoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicosTableAdapter = null;
            this.tableAdapterManager.agendamentoTableAdapter = null;
            this.tableAdapterManager.animalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.racaTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = this.servicoTableAdapter;
            this.tableAdapterManager.UpdateOrder = WordPet.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.wordldpetTableAdapter = null;
            this.tableAdapterManager.worldpetTableAdapter = null;
            // 
            // serv_codigoLabel
            // 
            serv_codigoLabel.AutoSize = true;
            serv_codigoLabel.Location = new System.Drawing.Point(37, 46);
            serv_codigoLabel.Name = "serv_codigoLabel";
            serv_codigoLabel.Size = new System.Drawing.Size(82, 23);
            serv_codigoLabel.TabIndex = 0;
            serv_codigoLabel.Text = "Código";
            // 
            // serv_codigoLabel1
            // 
            this.serv_codigoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "serv_codigo", true));
            this.serv_codigoLabel1.Location = new System.Drawing.Point(208, 50);
            this.serv_codigoLabel1.Name = "serv_codigoLabel1";
            this.serv_codigoLabel1.Size = new System.Drawing.Size(100, 23);
            this.serv_codigoLabel1.TabIndex = 1;
            this.serv_codigoLabel1.Click += new System.EventHandler(this.serv_codigoLabel1_Click);
            // 
            // serv_descricaoLabel
            // 
            serv_descricaoLabel.AutoSize = true;
            serv_descricaoLabel.Location = new System.Drawing.Point(37, 117);
            serv_descricaoLabel.Name = "serv_descricaoLabel";
            serv_descricaoLabel.Size = new System.Drawing.Size(113, 23);
            serv_descricaoLabel.TabIndex = 2;
            serv_descricaoLabel.Text = "Descricao:";
            // 
            // serv_descricaoTextBox
            // 
            this.serv_descricaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serv_descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "serv_descricao", true));
            this.serv_descricaoTextBox.Location = new System.Drawing.Point(212, 140);
            this.serv_descricaoTextBox.Name = "serv_descricaoTextBox";
            this.serv_descricaoTextBox.Size = new System.Drawing.Size(100, 32);
            this.serv_descricaoTextBox.TabIndex = 3;
            // 
            // serv_precoLabel
            // 
            serv_precoLabel.AutoSize = true;
            serv_precoLabel.Location = new System.Drawing.Point(37, 216);
            serv_precoLabel.Name = "serv_precoLabel";
            serv_precoLabel.Size = new System.Drawing.Size(72, 23);
            serv_precoLabel.TabIndex = 4;
            serv_precoLabel.Text = "Preco:";
            // 
            // serv_precoTextBox
            // 
            this.serv_precoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serv_precoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "serv_preco", true));
            this.serv_precoTextBox.Location = new System.Drawing.Point(212, 207);
            this.serv_precoTextBox.Name = "serv_precoTextBox";
            this.serv_precoTextBox.Size = new System.Drawing.Size(100, 32);
            this.serv_precoTextBox.TabIndex = 5;
            // 
            // serv_tempoLabel
            // 
            serv_tempoLabel.AutoSize = true;
            serv_tempoLabel.Location = new System.Drawing.Point(37, 284);
            serv_tempoLabel.Name = "serv_tempoLabel";
            serv_tempoLabel.Size = new System.Drawing.Size(82, 23);
            serv_tempoLabel.TabIndex = 6;
            serv_tempoLabel.Text = "Tempo:";
            // 
            // serv_tempoTextBox
            // 
            this.serv_tempoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serv_tempoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "serv_tempo", true));
            this.serv_tempoTextBox.Location = new System.Drawing.Point(212, 275);
            this.serv_tempoTextBox.Name = "serv_tempoTextBox";
            this.serv_tempoTextBox.Size = new System.Drawing.Size(100, 32);
            this.serv_tempoTextBox.TabIndex = 7;
            // 
            // servicoBindingNavigator
            // 
            this.servicoBindingNavigator.AddNewItem = null;
            this.servicoBindingNavigator.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.servicoBindingNavigator.CountItem = this.toolStripLabel1;
            this.servicoBindingNavigator.DeleteItem = null;
            this.servicoBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.servicoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFirstItem,
            this.btnPreviousItem,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.btnNextItem,
            this.btnLastItem,
            this.btnAdd,
            this.btDelete,
            this.btnCancel,
            this.btnSave,
            this.btnEdit});
            this.servicoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.servicoBindingNavigator.MoveFirstItem = this.btnLastItem;
            this.servicoBindingNavigator.MoveLastItem = this.btnLastItem;
            this.servicoBindingNavigator.MoveNextItem = this.btnNextItem;
            this.servicoBindingNavigator.MovePreviousItem = this.btnPreviousItem;
            this.servicoBindingNavigator.Name = "servicoBindingNavigator";
            this.servicoBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.servicoBindingNavigator.PositionItem = this.toolStripTextBox1;
            this.servicoBindingNavigator.Size = new System.Drawing.Size(922, 39);
            this.servicoBindingNavigator.TabIndex = 3;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(48, 36);
            this.toolStripLabel1.Text = "de {0}";
            this.toolStripLabel1.ToolTipText = "Número total de itens";
            // 
            // btnFirstItem
            // 
            this.btnFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFirstItem.Image = global::WordPet.Properties.Resources.left;
            this.btnFirstItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnFirstItem.Margin = new System.Windows.Forms.Padding(100, 1, 0, 2);
            this.btnFirstItem.Name = "btnFirstItem";
            this.btnFirstItem.RightToLeftAutoMirrorImage = true;
            this.btnFirstItem.Size = new System.Drawing.Size(36, 36);
            this.btnFirstItem.Text = "Mover primeiro";
            // 
            // btnPreviousItem
            // 
            this.btnPreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPreviousItem.Image = global::WordPet.Properties.Resources.setaleft;
            this.btnPreviousItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnPreviousItem.Name = "btnPreviousItem";
            this.btnPreviousItem.RightToLeftAutoMirrorImage = true;
            this.btnPreviousItem.Size = new System.Drawing.Size(36, 36);
            this.btnPreviousItem.Text = "Mover anterior";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Posição";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.toolStripTextBox1.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(75, 31);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox1.ToolTipText = "Posição atual";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btnNextItem
            // 
            this.btnNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNextItem.Image = global::WordPet.Properties.Resources.setaright;
            this.btnNextItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnNextItem.Name = "btnNextItem";
            this.btnNextItem.RightToLeftAutoMirrorImage = true;
            this.btnNextItem.Size = new System.Drawing.Size(36, 36);
            this.btnNextItem.Text = "Mover próximo";
            // 
            // btnLastItem
            // 
            this.btnLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLastItem.Image = global::WordPet.Properties.Resources.right;
            this.btnLastItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnLastItem.Name = "btnLastItem";
            this.btnLastItem.RightToLeftAutoMirrorImage = true;
            this.btnLastItem.Size = new System.Drawing.Size(36, 36);
            this.btnLastItem.Text = "Mover último";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = global::WordPet.Properties.Resources.add;
            this.btnAdd.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(36, 36);
            this.btnAdd.Text = "Adicionar Cadastro";
            // 
            // btDelete
            // 
            this.btDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btDelete.Image = global::WordPet.Properties.Resources.delete;
            this.btDelete.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.btDelete.Name = "btDelete";
            this.btDelete.RightToLeftAutoMirrorImage = true;
            this.btDelete.Size = new System.Drawing.Size(36, 36);
            this.btDelete.Text = "Excluir Cadastro";
            // 
            // btnCancel
            // 
            this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancel.Image = global::WordPet.Properties.Resources.parar;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(36, 36);
            this.btnCancel.Text = "Cancelar Cadastro";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::WordPet.Properties.Resources.save;
            this.btnSave.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(36, 36);
            this.btnSave.Text = "Salvar Cadastro";
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = global::WordPet.Properties.Resources.edit;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.LightSlateGray;
            this.btnEdit.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(36, 36);
            this.btnEdit.Text = "Editar";
            // 
            // frmServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(922, 732);
            this.Controls.Add(this.servicoBindingNavigator);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmServicos";
            this.Text = "frmServicos";
            this.Load += new System.EventHandler(this.frmServicos_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingNavigator)).EndInit();
            this.servicoBindingNavigator.ResumeLayout(false);
            this.servicoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private masterDataSetTableAdapters.servicoTableAdapter servicoTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label serv_codigoLabel1;
        private System.Windows.Forms.TextBox serv_descricaoTextBox;
        private System.Windows.Forms.TextBox serv_precoTextBox;
        private System.Windows.Forms.TextBox serv_tempoTextBox;
        private System.Windows.Forms.BindingNavigator servicoBindingNavigator;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnFirstItem;
        private System.Windows.Forms.ToolStripButton btnPreviousItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnNextItem;
        private System.Windows.Forms.ToolStripButton btnLastItem;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btDelete;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnEdit;
    }
}