namespace WordPet
{
    partial class frmCadCliente
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
            System.Windows.Forms.Label cli_fotoLabel;
            System.Windows.Forms.Label cli_enderecoLabel;
            System.Windows.Forms.Label cli_cpfLabel;
            System.Windows.Forms.Label cli_emailLabel;
            System.Windows.Forms.Label cli_celularLabel;
            System.Windows.Forms.Label cli_nomeLabel;
            System.Windows.Forms.Label cli_codigoLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.cli_codigoLabel1 = new System.Windows.Forms.Label();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new WordPet.masterDataSet();
            this.cli_nomeTextBox = new System.Windows.Forms.TextBox();
            this.cli_celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cli_emailTextBox = new System.Windows.Forms.TextBox();
            this.cli_cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cli_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.cli_fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.clienteTableAdapter = new WordPet.masterDataSetTableAdapters.clienteTableAdapter();
            this.tableAdapterManager = new WordPet.masterDataSetTableAdapters.TableAdapterManager();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnFirstItem = new System.Windows.Forms.ToolStripButton();
            this.btnPreviousItem = new System.Windows.Forms.ToolStripButton();
            this.btnNextItem = new System.Windows.Forms.ToolStripButton();
            this.btnLastItem = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btDelete = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            cli_fotoLabel = new System.Windows.Forms.Label();
            cli_enderecoLabel = new System.Windows.Forms.Label();
            cli_cpfLabel = new System.Windows.Forms.Label();
            cli_emailLabel = new System.Windows.Forms.Label();
            cli_celularLabel = new System.Windows.Forms.Label();
            cli_nomeLabel = new System.Windows.Forms.Label();
            cli_codigoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).BeginInit();
            this.clienteBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // cli_fotoLabel
            // 
            cli_fotoLabel.AutoSize = true;
            cli_fotoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cli_fotoLabel.Location = new System.Drawing.Point(597, 157);
            cli_fotoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cli_fotoLabel.Name = "cli_fotoLabel";
            cli_fotoLabel.Size = new System.Drawing.Size(54, 23);
            cli_fotoLabel.TabIndex = 12;
            cli_fotoLabel.Text = "foto:";
            // 
            // cli_enderecoLabel
            // 
            cli_enderecoLabel.AutoSize = true;
            cli_enderecoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cli_enderecoLabel.Location = new System.Drawing.Point(76, 442);
            cli_enderecoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cli_enderecoLabel.Name = "cli_enderecoLabel";
            cli_enderecoLabel.Size = new System.Drawing.Size(110, 23);
            cli_enderecoLabel.TabIndex = 10;
            cli_enderecoLabel.Text = "Endereco:";
            cli_enderecoLabel.Click += new System.EventHandler(this.cli_enderecoLabel_Click);
            // 
            // cli_cpfLabel
            // 
            cli_cpfLabel.AutoSize = true;
            cli_cpfLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cli_cpfLabel.Location = new System.Drawing.Point(76, 383);
            cli_cpfLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cli_cpfLabel.Name = "cli_cpfLabel";
            cli_cpfLabel.Size = new System.Drawing.Size(53, 23);
            cli_cpfLabel.TabIndex = 8;
            cli_cpfLabel.Text = "CPF:";
            cli_cpfLabel.Click += new System.EventHandler(this.cli_cpfLabel_Click);
            // 
            // cli_emailLabel
            // 
            cli_emailLabel.AutoSize = true;
            cli_emailLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cli_emailLabel.Location = new System.Drawing.Point(76, 327);
            cli_emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cli_emailLabel.Name = "cli_emailLabel";
            cli_emailLabel.Size = new System.Drawing.Size(67, 23);
            cli_emailLabel.TabIndex = 6;
            cli_emailLabel.Text = "Email:";
            // 
            // cli_celularLabel
            // 
            cli_celularLabel.AutoSize = true;
            cli_celularLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cli_celularLabel.Location = new System.Drawing.Point(76, 271);
            cli_celularLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cli_celularLabel.Name = "cli_celularLabel";
            cli_celularLabel.Size = new System.Drawing.Size(86, 23);
            cli_celularLabel.TabIndex = 4;
            cli_celularLabel.Text = "Celular:";
            // 
            // cli_nomeLabel
            // 
            cli_nomeLabel.AutoSize = true;
            cli_nomeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cli_nomeLabel.Location = new System.Drawing.Point(76, 217);
            cli_nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cli_nomeLabel.Name = "cli_nomeLabel";
            cli_nomeLabel.Size = new System.Drawing.Size(75, 23);
            cli_nomeLabel.TabIndex = 2;
            cli_nomeLabel.Text = "Nome:";
            // 
            // cli_codigoLabel
            // 
            cli_codigoLabel.AutoSize = true;
            cli_codigoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cli_codigoLabel.Location = new System.Drawing.Point(76, 157);
            cli_codigoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cli_codigoLabel.Name = "cli_codigoLabel";
            cli_codigoLabel.Size = new System.Drawing.Size(87, 23);
            cli_codigoLabel.TabIndex = 0;
            cli_codigoLabel.Text = "Codigo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPhoto);
            this.groupBox1.Controls.Add(cli_codigoLabel);
            this.groupBox1.Controls.Add(this.cli_codigoLabel1);
            this.groupBox1.Controls.Add(cli_nomeLabel);
            this.groupBox1.Controls.Add(this.cli_nomeTextBox);
            this.groupBox1.Controls.Add(cli_celularLabel);
            this.groupBox1.Controls.Add(this.cli_celularMaskedTextBox);
            this.groupBox1.Controls.Add(cli_emailLabel);
            this.groupBox1.Controls.Add(this.cli_emailTextBox);
            this.groupBox1.Controls.Add(cli_cpfLabel);
            this.groupBox1.Controls.Add(this.cli_cpfMaskedTextBox);
            this.groupBox1.Controls.Add(cli_enderecoLabel);
            this.groupBox1.Controls.Add(this.cli_enderecoTextBox);
            this.groupBox1.Controls.Add(cli_fotoLabel);
            this.groupBox1.Controls.Add(this.cli_fotoPictureBox);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1068, 661);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro do Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnPhoto
            // 
            this.btnPhoto.BackgroundImage = global::WordPet.Properties.Resources.image;
            this.btnPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhoto.Location = new System.Drawing.Point(952, 157);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(37, 30);
            this.btnPhoto.TabIndex = 14;
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // cli_codigoLabel1
            // 
            this.cli_codigoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cli_codigo", true));
            this.cli_codigoLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cli_codigoLabel1.Location = new System.Drawing.Point(260, 157);
            this.cli_codigoLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cli_codigoLabel1.Name = "cli_codigoLabel1";
            this.cli_codigoLabel1.Size = new System.Drawing.Size(107, 45);
            this.cli_codigoLabel1.TabIndex = 1;
            this.cli_codigoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cli_nomeTextBox
            // 
            this.cli_nomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cli_nomeTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cli_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cli_nome", true));
            this.cli_nomeTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cli_nomeTextBox.Location = new System.Drawing.Point(264, 217);
            this.cli_nomeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cli_nomeTextBox.Name = "cli_nomeTextBox";
            this.cli_nomeTextBox.Size = new System.Drawing.Size(248, 32);
            this.cli_nomeTextBox.TabIndex = 3;
            // 
            // cli_celularMaskedTextBox
            // 
            this.cli_celularMaskedTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cli_celularMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cli_celular", true));
            this.cli_celularMaskedTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cli_celularMaskedTextBox.Location = new System.Drawing.Point(264, 271);
            this.cli_celularMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cli_celularMaskedTextBox.Mask = "(99) 99999-9999";
            this.cli_celularMaskedTextBox.Name = "cli_celularMaskedTextBox";
            this.cli_celularMaskedTextBox.Size = new System.Drawing.Size(150, 32);
            this.cli_celularMaskedTextBox.TabIndex = 5;
            // 
            // cli_emailTextBox
            // 
            this.cli_emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cli_emailTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cli_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cli_email", true));
            this.cli_emailTextBox.Location = new System.Drawing.Point(264, 325);
            this.cli_emailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cli_emailTextBox.Name = "cli_emailTextBox";
            this.cli_emailTextBox.Size = new System.Drawing.Size(248, 32);
            this.cli_emailTextBox.TabIndex = 7;
            // 
            // cli_cpfMaskedTextBox
            // 
            this.cli_cpfMaskedTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cli_cpfMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cli_cpf", true));
            this.cli_cpfMaskedTextBox.Location = new System.Drawing.Point(264, 383);
            this.cli_cpfMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cli_cpfMaskedTextBox.Mask = "999.999.999-99";
            this.cli_cpfMaskedTextBox.Name = "cli_cpfMaskedTextBox";
            this.cli_cpfMaskedTextBox.Size = new System.Drawing.Size(154, 32);
            this.cli_cpfMaskedTextBox.TabIndex = 9;
            // 
            // cli_enderecoTextBox
            // 
            this.cli_enderecoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cli_enderecoTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cli_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cli_endereco", true));
            this.cli_enderecoTextBox.Location = new System.Drawing.Point(264, 442);
            this.cli_enderecoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cli_enderecoTextBox.Name = "cli_enderecoTextBox";
            this.cli_enderecoTextBox.Size = new System.Drawing.Size(248, 32);
            this.cli_enderecoTextBox.TabIndex = 11;
            // 
            // cli_fotoPictureBox
            // 
            this.cli_fotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cli_fotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cli_fotoPictureBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cli_fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.clienteBindingSource, "cli_foto", true));
            this.cli_fotoPictureBox.Location = new System.Drawing.Point(659, 157);
            this.cli_fotoPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cli_fotoPictureBox.Name = "cli_fotoPictureBox";
            this.cli_fotoPictureBox.Size = new System.Drawing.Size(265, 317);
            this.cli_fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cli_fotoPictureBox.TabIndex = 13;
            this.cli_fotoPictureBox.TabStop = false;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicosTableAdapter = null;
            this.tableAdapterManager.agendamentoTableAdapter = null;
            this.tableAdapterManager.animalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.racaTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WordPet.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.wordldpetTableAdapter = null;
            this.tableAdapterManager.worldpetTableAdapter = null;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.BackColor = System.Drawing.SystemColors.InfoText;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorPositionItem.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.bindingNavigatorPositionItem.Margin = new System.Windows.Forms.Padding(1);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(75, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            this.bindingNavigatorPositionItem.Click += new System.EventHandler(this.bindingNavigatorPositionItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 36);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            this.bindingNavigatorCountItem.Click += new System.EventHandler(this.bindingNavigatorCountItem_Click);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // clienteBindingNavigator
            // 
            this.clienteBindingNavigator.AddNewItem = null;
            this.clienteBindingNavigator.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clienteBindingNavigator.BindingSource = this.clienteBindingSource;
            this.clienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clienteBindingNavigator.DeleteItem = null;
            this.clienteBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.clienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFirstItem,
            this.btnPreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.btnNextItem,
            this.btnLastItem,
            this.btnAdd,
            this.btDelete,
            this.btnCancel,
            this.btnSave,
            this.btnEdit});
            this.clienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clienteBindingNavigator.MoveFirstItem = this.btnLastItem;
            this.clienteBindingNavigator.MoveLastItem = this.btnLastItem;
            this.clienteBindingNavigator.MoveNextItem = this.btnNextItem;
            this.clienteBindingNavigator.MovePreviousItem = this.btnPreviousItem;
            this.clienteBindingNavigator.Name = "clienteBindingNavigator";
            this.clienteBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.clienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clienteBindingNavigator.Size = new System.Drawing.Size(1315, 39);
            this.clienteBindingNavigator.TabIndex = 1;
            this.clienteBindingNavigator.RefreshItems += new System.EventHandler(this.clienteBindingNavigator_RefreshItems);
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
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
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::WordPet.Properties.Resources.save;
            this.btnSave.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(36, 36);
            this.btnSave.Text = "Salvar Cadastro";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Escolha a foto do Cliente";
            // 
            // frmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1315, 1017);
            this.Controls.Add(this.clienteBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadCliente";
            this.Load += new System.EventHandler(this.frmCadCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).EndInit();
            this.clienteBindingNavigator.ResumeLayout(false);
            this.clienteBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private masterDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton btnFirstItem;
        private System.Windows.Forms.ToolStripButton btnPreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton btnNextItem;
        private System.Windows.Forms.ToolStripButton btnLastItem;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btDelete;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.BindingNavigator clienteBindingNavigator;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.Label cli_codigoLabel1;
        private System.Windows.Forms.TextBox cli_nomeTextBox;
        private System.Windows.Forms.MaskedTextBox cli_celularMaskedTextBox;
        private System.Windows.Forms.TextBox cli_emailTextBox;
        private System.Windows.Forms.MaskedTextBox cli_cpfMaskedTextBox;
        private System.Windows.Forms.TextBox cli_enderecoTextBox;
        private System.Windows.Forms.PictureBox cli_fotoPictureBox;
    }
}