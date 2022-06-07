namespace WordPet
{
    partial class frmRacas
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
            System.Windows.Forms.Label raca_codigoLabel;
            System.Windows.Forms.Label raca_nomeLabel;
            System.Windows.Forms.Label raca_pais_origemLabel;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.raca_codigoLabel1 = new System.Windows.Forms.Label();
            this.racaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new WordPet.masterDataSet();
            this.raca_nomeTextBox = new System.Windows.Forms.TextBox();
            this.raca_pais_origemTextBox = new System.Windows.Forms.TextBox();
            this.racaTableAdapter = new WordPet.masterDataSetTableAdapters.racaTableAdapter();
            this.tableAdapterManager = new WordPet.masterDataSetTableAdapters.TableAdapterManager();
            this.racaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            raca_codigoLabel = new System.Windows.Forms.Label();
            raca_nomeLabel = new System.Windows.Forms.Label();
            raca_pais_origemLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingNavigator)).BeginInit();
            this.racaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // raca_codigoLabel
            // 
            raca_codigoLabel.AutoSize = true;
            raca_codigoLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            raca_codigoLabel.Location = new System.Drawing.Point(81, 95);
            raca_codigoLabel.Name = "raca_codigoLabel";
            raca_codigoLabel.Size = new System.Drawing.Size(104, 27);
            raca_codigoLabel.TabIndex = 0;
            raca_codigoLabel.Text = "Código:";
            raca_codigoLabel.UseWaitCursor = true;
            // 
            // raca_nomeLabel
            // 
            raca_nomeLabel.AutoSize = true;
            raca_nomeLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            raca_nomeLabel.Location = new System.Drawing.Point(81, 149);
            raca_nomeLabel.Name = "raca_nomeLabel";
            raca_nomeLabel.Size = new System.Drawing.Size(87, 27);
            raca_nomeLabel.TabIndex = 2;
            raca_nomeLabel.Text = "Nome:";
            raca_nomeLabel.UseWaitCursor = true;
            // 
            // raca_pais_origemLabel
            // 
            raca_pais_origemLabel.AutoSize = true;
            raca_pais_origemLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            raca_pais_origemLabel.Location = new System.Drawing.Point(81, 204);
            raca_pais_origemLabel.Name = "raca_pais_origemLabel";
            raca_pais_origemLabel.Size = new System.Drawing.Size(149, 27);
            raca_pais_origemLabel.TabIndex = 4;
            raca_pais_origemLabel.Text = "Pais origem:";
            raca_pais_origemLabel.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(raca_codigoLabel);
            this.groupBox2.Controls.Add(this.raca_codigoLabel1);
            this.groupBox2.Controls.Add(raca_nomeLabel);
            this.groupBox2.Controls.Add(this.raca_nomeTextBox);
            this.groupBox2.Controls.Add(raca_pais_origemLabel);
            this.groupBox2.Controls.Add(this.raca_pais_origemTextBox);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(32, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 364);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastrar Raças";
            this.groupBox2.UseWaitCursor = true;
            // 
            // raca_codigoLabel1
            // 
            this.raca_codigoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racaBindingSource, "raca_codigo", true));
            this.raca_codigoLabel1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raca_codigoLabel1.Location = new System.Drawing.Point(338, 95);
            this.raca_codigoLabel1.Name = "raca_codigoLabel1";
            this.raca_codigoLabel1.Size = new System.Drawing.Size(160, 34);
            this.raca_codigoLabel1.TabIndex = 1;
            this.raca_codigoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.raca_codigoLabel1.UseWaitCursor = true;
            this.raca_codigoLabel1.Click += new System.EventHandler(this.raca_codigoLabel1_Click);
            // 
            // racaBindingSource
            // 
            this.racaBindingSource.DataMember = "raca";
            this.racaBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raca_nomeTextBox
            // 
            this.raca_nomeTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.raca_nomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.raca_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racaBindingSource, "raca_nome", true));
            this.raca_nomeTextBox.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raca_nomeTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.raca_nomeTextBox.Location = new System.Drawing.Point(342, 149);
            this.raca_nomeTextBox.Name = "raca_nomeTextBox";
            this.raca_nomeTextBox.Size = new System.Drawing.Size(156, 36);
            this.raca_nomeTextBox.TabIndex = 3;
            this.raca_nomeTextBox.UseWaitCursor = true;
            // 
            // raca_pais_origemTextBox
            // 
            this.raca_pais_origemTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.raca_pais_origemTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.raca_pais_origemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racaBindingSource, "raca_pais_origem", true));
            this.raca_pais_origemTextBox.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raca_pais_origemTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.raca_pais_origemTextBox.Location = new System.Drawing.Point(342, 202);
            this.raca_pais_origemTextBox.Name = "raca_pais_origemTextBox";
            this.raca_pais_origemTextBox.Size = new System.Drawing.Size(156, 36);
            this.raca_pais_origemTextBox.TabIndex = 5;
            this.raca_pais_origemTextBox.UseWaitCursor = true;
            // 
            // racaTableAdapter
            // 
            this.racaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicosTableAdapter = null;
            this.tableAdapterManager.agendamentoTableAdapter = null;
            this.tableAdapterManager.animalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.racaTableAdapter = this.racaTableAdapter;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WordPet.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // racaBindingNavigator
            // 
            this.racaBindingNavigator.AddNewItem = null;
            this.racaBindingNavigator.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.racaBindingNavigator.BindingSource = this.racaBindingSource;
            this.racaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.racaBindingNavigator.DeleteItem = null;
            this.racaBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.racaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.racaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.racaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.racaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.racaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.racaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.racaBindingNavigator.Name = "racaBindingNavigator";
            this.racaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.racaBindingNavigator.Size = new System.Drawing.Size(2685, 39);
            this.racaBindingNavigator.TabIndex = 1;
            this.racaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.ActiveLinkColor = System.Drawing.Color.Red;
            this.bindingNavigatorCountItem.BackColor = System.Drawing.Color.Black;
            this.bindingNavigatorCountItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bindingNavigatorCountItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bindingNavigatorCountItem.LinkColor = System.Drawing.Color.Black;
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 36);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            this.bindingNavigatorCountItem.Click += new System.EventHandler(this.bindingNavigatorCountItem_Click);
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
            this.bindingNavigatorPositionItem.BackColor = System.Drawing.SystemColors.InfoText;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorPositionItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(63, 38);
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
            this.btnAdd.Text = "Adicionar novo";
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
            this.btnSave.Text = "Salvar Dados";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = global::WordPet.Properties.Resources.edit;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.LightSlateGray;
            this.btnEdit.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(36, 36);
            this.btnEdit.Text = "toolStripButton2";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmRacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2685, 1372);
            this.Controls.Add(this.racaBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRacas";
            this.Text = "frmRacas";
            this.Load += new System.EventHandler(this.frmRacas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingNavigator)).EndInit();
            this.racaBindingNavigator.ResumeLayout(false);
            this.racaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource racaBindingSource;
        private masterDataSetTableAdapters.racaTableAdapter racaTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator racaBindingNavigator;
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
        private System.Windows.Forms.Label raca_codigoLabel1;
        private System.Windows.Forms.TextBox raca_nomeTextBox;
        private System.Windows.Forms.TextBox raca_pais_origemTextBox;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripButton btnEdit;
    }
}