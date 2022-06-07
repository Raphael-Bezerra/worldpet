namespace WordPet
{
    partial class frmAnimais
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
            System.Windows.Forms.Label ani_codigoLabel;
            System.Windows.Forms.Label ani_nomeLabel;
            System.Windows.Forms.Label ani_sexoLabel;
            System.Windows.Forms.Label ani_agressivoLabel;
            System.Windows.Forms.Label ani_corLabel;
            System.Windows.Forms.Label ani_idadeLabel;
            System.Windows.Forms.Label ani_alergiaLabel;
            System.Windows.Forms.Label ani_clienteLabel;
            System.Windows.Forms.Label ani_racaLabel;
            System.Windows.Forms.Label ani_fotoLabel;
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ani_agressivoComboBox = new System.Windows.Forms.ComboBox();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new WordPet.masterDataSet();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.ani_codigoLabel1 = new System.Windows.Forms.Label();
            this.ani_nomeTextBox = new System.Windows.Forms.TextBox();
            this.ani_sexoComboBox = new System.Windows.Forms.ComboBox();
            this.ani_corTextBox = new System.Windows.Forms.TextBox();
            this.ani_idadeTextBox = new System.Windows.Forms.TextBox();
            this.ani_alergiaTextBox = new System.Windows.Forms.TextBox();
            this.ani_clienteComboBox = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ani_racaComboBox = new System.Windows.Forms.ComboBox();
            this.racaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ani_fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.animalTableAdapter = new WordPet.masterDataSetTableAdapters.animalTableAdapter();
            this.tableAdapterManager = new WordPet.masterDataSetTableAdapters.TableAdapterManager();
            this.clienteTableAdapter = new WordPet.masterDataSetTableAdapters.clienteTableAdapter();
            this.racaTableAdapter = new WordPet.masterDataSetTableAdapters.racaTableAdapter();
            this.animalBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ani_codigoLabel = new System.Windows.Forms.Label();
            ani_nomeLabel = new System.Windows.Forms.Label();
            ani_sexoLabel = new System.Windows.Forms.Label();
            ani_agressivoLabel = new System.Windows.Forms.Label();
            ani_corLabel = new System.Windows.Forms.Label();
            ani_idadeLabel = new System.Windows.Forms.Label();
            ani_alergiaLabel = new System.Windows.Forms.Label();
            ani_clienteLabel = new System.Windows.Forms.Label();
            ani_racaLabel = new System.Windows.Forms.Label();
            ani_fotoLabel = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ani_fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingNavigator)).BeginInit();
            this.animalBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // ani_codigoLabel
            // 
            ani_codigoLabel.AutoSize = true;
            ani_codigoLabel.Location = new System.Drawing.Point(12, 44);
            ani_codigoLabel.Name = "ani_codigoLabel";
            ani_codigoLabel.Size = new System.Drawing.Size(87, 23);
            ani_codigoLabel.TabIndex = 0;
            ani_codigoLabel.Text = "Código:";
            // 
            // ani_nomeLabel
            // 
            ani_nomeLabel.AutoSize = true;
            ani_nomeLabel.Location = new System.Drawing.Point(12, 75);
            ani_nomeLabel.Name = "ani_nomeLabel";
            ani_nomeLabel.Size = new System.Drawing.Size(75, 23);
            ani_nomeLabel.TabIndex = 2;
            ani_nomeLabel.Text = "Nome:";
            // 
            // ani_sexoLabel
            // 
            ani_sexoLabel.AutoSize = true;
            ani_sexoLabel.Location = new System.Drawing.Point(12, 111);
            ani_sexoLabel.Name = "ani_sexoLabel";
            ani_sexoLabel.Size = new System.Drawing.Size(61, 23);
            ani_sexoLabel.TabIndex = 4;
            ani_sexoLabel.Text = "Sexo:";
            // 
            // ani_agressivoLabel
            // 
            ani_agressivoLabel.AutoSize = true;
            ani_agressivoLabel.Location = new System.Drawing.Point(6, 148);
            ani_agressivoLabel.Name = "ani_agressivoLabel";
            ani_agressivoLabel.Size = new System.Drawing.Size(107, 23);
            ani_agressivoLabel.TabIndex = 6;
            ani_agressivoLabel.Text = "Agressivo:";
            // 
            // ani_corLabel
            // 
            ani_corLabel.AutoSize = true;
            ani_corLabel.Location = new System.Drawing.Point(12, 189);
            ani_corLabel.Name = "ani_corLabel";
            ani_corLabel.Size = new System.Drawing.Size(50, 23);
            ani_corLabel.TabIndex = 8;
            ani_corLabel.Text = "Cor:";
            // 
            // ani_idadeLabel
            // 
            ani_idadeLabel.AutoSize = true;
            ani_idadeLabel.Location = new System.Drawing.Point(12, 225);
            ani_idadeLabel.Name = "ani_idadeLabel";
            ani_idadeLabel.Size = new System.Drawing.Size(75, 23);
            ani_idadeLabel.TabIndex = 10;
            ani_idadeLabel.Text = "Idade:";
            // 
            // ani_alergiaLabel
            // 
            ani_alergiaLabel.AutoSize = true;
            ani_alergiaLabel.Location = new System.Drawing.Point(12, 261);
            ani_alergiaLabel.Name = "ani_alergiaLabel";
            ani_alergiaLabel.Size = new System.Drawing.Size(88, 23);
            ani_alergiaLabel.TabIndex = 12;
            ani_alergiaLabel.Text = "ALergia:";
            // 
            // ani_clienteLabel
            // 
            ani_clienteLabel.AutoSize = true;
            ani_clienteLabel.Location = new System.Drawing.Point(12, 330);
            ani_clienteLabel.Name = "ani_clienteLabel";
            ani_clienteLabel.Size = new System.Drawing.Size(84, 23);
            ani_clienteLabel.TabIndex = 14;
            ani_clienteLabel.Text = "Cliente:";
            // 
            // ani_racaLabel
            // 
            ani_racaLabel.AutoSize = true;
            ani_racaLabel.Location = new System.Drawing.Point(12, 369);
            ani_racaLabel.Name = "ani_racaLabel";
            ani_racaLabel.Size = new System.Drawing.Size(68, 23);
            ani_racaLabel.TabIndex = 16;
            ani_racaLabel.Text = "Raca:";
            // 
            // ani_fotoLabel
            // 
            ani_fotoLabel.AutoSize = true;
            ani_fotoLabel.Location = new System.Drawing.Point(332, 72);
            ani_fotoLabel.Name = "ani_fotoLabel";
            ani_fotoLabel.Size = new System.Drawing.Size(53, 23);
            ani_fotoLabel.TabIndex = 18;
            ani_fotoLabel.Text = "Foto";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ani_agressivoComboBox);
            this.groupBox4.Controls.Add(this.btnPhoto);
            this.groupBox4.Controls.Add(ani_codigoLabel);
            this.groupBox4.Controls.Add(this.ani_codigoLabel1);
            this.groupBox4.Controls.Add(ani_nomeLabel);
            this.groupBox4.Controls.Add(this.ani_nomeTextBox);
            this.groupBox4.Controls.Add(ani_sexoLabel);
            this.groupBox4.Controls.Add(this.ani_sexoComboBox);
            this.groupBox4.Controls.Add(ani_corLabel);
            this.groupBox4.Controls.Add(this.ani_corTextBox);
            this.groupBox4.Controls.Add(ani_idadeLabel);
            this.groupBox4.Controls.Add(this.ani_idadeTextBox);
            this.groupBox4.Controls.Add(ani_alergiaLabel);
            this.groupBox4.Controls.Add(this.ani_alergiaTextBox);
            this.groupBox4.Controls.Add(ani_clienteLabel);
            this.groupBox4.Controls.Add(this.ani_clienteComboBox);
            this.groupBox4.Controls.Add(ani_racaLabel);
            this.groupBox4.Controls.Add(this.ani_racaComboBox);
            this.groupBox4.Controls.Add(ani_fotoLabel);
            this.groupBox4.Controls.Add(this.ani_fotoPictureBox);
            this.groupBox4.Controls.Add(ani_agressivoLabel);
            this.groupBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox4.Enabled = false;
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 42);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(687, 457);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cadastrar Animais";
            // 
            // ani_agressivoComboBox
            // 
            this.ani_agressivoComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ani_agressivoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_agressivo", true));
            this.ani_agressivoComboBox.FormattingEnabled = true;
            this.ani_agressivoComboBox.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.ani_agressivoComboBox.Location = new System.Drawing.Point(104, 147);
            this.ani_agressivoComboBox.Name = "ani_agressivoComboBox";
            this.ani_agressivoComboBox.Size = new System.Drawing.Size(79, 31);
            this.ani_agressivoComboBox.TabIndex = 7;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "animal";
            this.animalBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPhoto
            // 
            this.btnPhoto.BackgroundImage = global::WordPet.Properties.Resources.image;
            this.btnPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhoto.Location = new System.Drawing.Point(629, 70);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(27, 24);
            this.btnPhoto.TabIndex = 20;
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click_1);
            // 
            // ani_codigoLabel1
            // 
            this.ani_codigoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_codigo", true));
            this.ani_codigoLabel1.Location = new System.Drawing.Point(104, 44);
            this.ani_codigoLabel1.Name = "ani_codigoLabel1";
            this.ani_codigoLabel1.Size = new System.Drawing.Size(79, 10);
            this.ani_codigoLabel1.TabIndex = 1;
            this.ani_codigoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ani_nomeTextBox
            // 
            this.ani_nomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ani_nomeTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ani_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_nome", true));
            this.ani_nomeTextBox.Location = new System.Drawing.Point(104, 72);
            this.ani_nomeTextBox.Name = "ani_nomeTextBox";
            this.ani_nomeTextBox.Size = new System.Drawing.Size(147, 32);
            this.ani_nomeTextBox.TabIndex = 3;
            // 
            // ani_sexoComboBox
            // 
            this.ani_sexoComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ani_sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_sexo", true));
            this.ani_sexoComboBox.FormattingEnabled = true;
            this.ani_sexoComboBox.Items.AddRange(new object[] {
            "Macho",
            "Fêmea"});
            this.ani_sexoComboBox.Location = new System.Drawing.Point(104, 108);
            this.ani_sexoComboBox.Name = "ani_sexoComboBox";
            this.ani_sexoComboBox.Size = new System.Drawing.Size(79, 31);
            this.ani_sexoComboBox.TabIndex = 5;
            // 
            // ani_corTextBox
            // 
            this.ani_corTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ani_corTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ani_corTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_cor", true));
            this.ani_corTextBox.Location = new System.Drawing.Point(104, 186);
            this.ani_corTextBox.Name = "ani_corTextBox";
            this.ani_corTextBox.Size = new System.Drawing.Size(147, 32);
            this.ani_corTextBox.TabIndex = 9;
            // 
            // ani_idadeTextBox
            // 
            this.ani_idadeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ani_idadeTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ani_idadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_idade", true));
            this.ani_idadeTextBox.Location = new System.Drawing.Point(104, 222);
            this.ani_idadeTextBox.Name = "ani_idadeTextBox";
            this.ani_idadeTextBox.Size = new System.Drawing.Size(147, 32);
            this.ani_idadeTextBox.TabIndex = 11;
            // 
            // ani_alergiaTextBox
            // 
            this.ani_alergiaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ani_alergiaTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ani_alergiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_alergia", true));
            this.ani_alergiaTextBox.Location = new System.Drawing.Point(104, 261);
            this.ani_alergiaTextBox.Multiline = true;
            this.ani_alergiaTextBox.Name = "ani_alergiaTextBox";
            this.ani_alergiaTextBox.Size = new System.Drawing.Size(159, 60);
            this.ani_alergiaTextBox.TabIndex = 13;
            // 
            // ani_clienteComboBox
            // 
            this.ani_clienteComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ani_clienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.animalBindingSource, "ani_cliente", true));
            this.ani_clienteComboBox.DataSource = this.clienteBindingSource;
            this.ani_clienteComboBox.DisplayMember = "cli_nome";
            this.ani_clienteComboBox.FormattingEnabled = true;
            this.ani_clienteComboBox.Location = new System.Drawing.Point(104, 327);
            this.ani_clienteComboBox.Name = "ani_clienteComboBox";
            this.ani_clienteComboBox.Size = new System.Drawing.Size(106, 31);
            this.ani_clienteComboBox.TabIndex = 15;
            this.ani_clienteComboBox.ValueMember = "cli_codigo";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.masterDataSet;
            // 
            // ani_racaComboBox
            // 
            this.ani_racaComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ani_racaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.animalBindingSource, "ani_raca", true));
            this.ani_racaComboBox.DataSource = this.racaBindingSource;
            this.ani_racaComboBox.DisplayMember = "raca_nome";
            this.ani_racaComboBox.FormattingEnabled = true;
            this.ani_racaComboBox.Location = new System.Drawing.Point(104, 366);
            this.ani_racaComboBox.Name = "ani_racaComboBox";
            this.ani_racaComboBox.Size = new System.Drawing.Size(106, 31);
            this.ani_racaComboBox.TabIndex = 17;
            this.ani_racaComboBox.ValueMember = "raca_codigo";
            // 
            // racaBindingSource
            // 
            this.racaBindingSource.DataMember = "raca";
            this.racaBindingSource.DataSource = this.masterDataSet;
            // 
            // ani_fotoPictureBox
            // 
            this.ani_fotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ani_fotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ani_fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.animalBindingSource, "ani_foto", true));
            this.ani_fotoPictureBox.Location = new System.Drawing.Point(391, 72);
            this.ani_fotoPictureBox.Name = "ani_fotoPictureBox";
            this.ani_fotoPictureBox.Size = new System.Drawing.Size(205, 258);
            this.ani_fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ani_fotoPictureBox.TabIndex = 19;
            this.ani_fotoPictureBox.TabStop = false;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicosTableAdapter = null;
            this.tableAdapterManager.agendamentoTableAdapter = null;
            this.tableAdapterManager.animalTableAdapter = this.animalTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.racaTableAdapter = this.racaTableAdapter;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WordPet.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.wordldpetTableAdapter = null;
            this.tableAdapterManager.worldpetTableAdapter = null;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // racaTableAdapter
            // 
            this.racaTableAdapter.ClearBeforeFill = true;
            // 
            // animalBindingNavigator
            // 
            this.animalBindingNavigator.AddNewItem = null;
            this.animalBindingNavigator.BackColor = System.Drawing.Color.Black;
            this.animalBindingNavigator.BindingSource = this.animalBindingSource;
            this.animalBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.animalBindingNavigator.DeleteItem = null;
            this.animalBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.animalBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnAdd,
            this.btnDelete,
            this.btnCancel,
            this.btnSave,
            this.btnEdit});
            this.animalBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.animalBindingNavigator.MoveFirstItem = this.bindingNavigatorSeparator;
            this.animalBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.animalBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.animalBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.animalBindingNavigator.Name = "animalBindingNavigator";
            this.animalBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.animalBindingNavigator.Size = new System.Drawing.Size(1160, 39);
            this.animalBindingNavigator.TabIndex = 1;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 36);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::WordPet.Properties.Resources.left;
            this.bindingNavigatorMoveFirstItem.Margin = new System.Windows.Forms.Padding(100, 1, 0, 2);
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::WordPet.Properties.Resources.setaleft;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
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
            this.bindingNavigatorPositionItem.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorPositionItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(79, 38);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = global::WordPet.Properties.Resources.setaright;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::WordPet.Properties.Resources.right;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
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
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = global::WordPet.Properties.Resources.delete;
            this.btnDelete.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(36, 36);
            this.btnDelete.Text = "Excluir";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancel.Image = global::WordPet.Properties.Resources.parar;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(36, 36);
            this.btnCancel.Text = "toolStripButton1";
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
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(36, 36);
            this.btnEdit.Text = "toolStripButton2";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1160, 994);
            this.Controls.Add(this.animalBindingNavigator);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnimais";
            this.Text = "frmAnimais";
            this.Load += new System.EventHandler(this.frmAnimais_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ani_fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingNavigator)).EndInit();
            this.animalBindingNavigator.ResumeLayout(false);
            this.animalBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private masterDataSetTableAdapters.animalTableAdapter animalTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator animalBindingNavigator;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private masterDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private masterDataSetTableAdapters.racaTableAdapter racaTableAdapter;
        private System.Windows.Forms.BindingSource racaBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label ani_codigoLabel1;
        private System.Windows.Forms.TextBox ani_nomeTextBox;
        private System.Windows.Forms.ComboBox ani_sexoComboBox;
        private System.Windows.Forms.ComboBox ani_agressivoComboBox;
        private System.Windows.Forms.TextBox ani_corTextBox;
        private System.Windows.Forms.TextBox ani_idadeTextBox;
        private System.Windows.Forms.TextBox ani_alergiaTextBox;
        private System.Windows.Forms.ComboBox ani_clienteComboBox;
        private System.Windows.Forms.ComboBox ani_racaComboBox;
        private System.Windows.Forms.PictureBox ani_fotoPictureBox;
        private System.Windows.Forms.Button btnPhoto;
    }
}