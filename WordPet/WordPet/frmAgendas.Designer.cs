namespace WordPet
{
    partial class frmAgendas
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
            System.Windows.Forms.Label ag_codigoLabel;
            System.Windows.Forms.Label ag_dataLabel;
            System.Windows.Forms.Label ag_horarioLabel;
            System.Windows.Forms.Label ag_situacaoLabel;
            System.Windows.Forms.Label ag_animalLabel;
            System.Windows.Forms.Label ag_totalLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AgendasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.btnFirstItem = new System.Windows.Forms.ToolStripButton();
            this.btnPreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNextItem = new System.Windows.Forms.ToolStripButton();
            this.btnLastItem = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btDelete = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.masterDataSet = new WordPet.masterDataSet();
            this.agendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendamentoTableAdapter = new WordPet.masterDataSetTableAdapters.agendamentoTableAdapter();
            this.tableAdapterManager = new WordPet.masterDataSetTableAdapters.TableAdapterManager();
            this.ag_codigoTextBox = new System.Windows.Forms.TextBox();
            this.ag_dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ag_horarioTextBox = new System.Windows.Forms.TextBox();
            this.ag_situacaoTextBox = new System.Windows.Forms.TextBox();
            this.ag_animalTextBox = new System.Windows.Forms.TextBox();
            this.ag_totalTextBox = new System.Windows.Forms.TextBox();
            ag_codigoLabel = new System.Windows.Forms.Label();
            ag_dataLabel = new System.Windows.Forms.Label();
            ag_horarioLabel = new System.Windows.Forms.Label();
            ag_situacaoLabel = new System.Windows.Forms.Label();
            ag_animalLabel = new System.Windows.Forms.Label();
            ag_totalLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgendasBindingNavigator)).BeginInit();
            this.AgendasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(ag_codigoLabel);
            this.groupBox1.Controls.Add(this.ag_codigoTextBox);
            this.groupBox1.Controls.Add(ag_dataLabel);
            this.groupBox1.Controls.Add(this.ag_dataDateTimePicker);
            this.groupBox1.Controls.Add(ag_horarioLabel);
            this.groupBox1.Controls.Add(this.ag_horarioTextBox);
            this.groupBox1.Controls.Add(ag_situacaoLabel);
            this.groupBox1.Controls.Add(this.ag_situacaoTextBox);
            this.groupBox1.Controls.Add(ag_animalLabel);
            this.groupBox1.Controls.Add(this.ag_animalTextBox);
            this.groupBox1.Controls.Add(ag_totalLabel);
            this.groupBox1.Controls.Add(this.ag_totalTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 484);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Agendas";
            // 
            // AgendasBindingNavigator
            // 
            this.AgendasBindingNavigator.AddNewItem = null;
            this.AgendasBindingNavigator.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AgendasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.AgendasBindingNavigator.DeleteItem = null;
            this.AgendasBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.AgendasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.AgendasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.AgendasBindingNavigator.MoveFirstItem = this.btnLastItem;
            this.AgendasBindingNavigator.MoveLastItem = this.btnLastItem;
            this.AgendasBindingNavigator.MoveNextItem = this.btnNextItem;
            this.AgendasBindingNavigator.MovePreviousItem = this.btnPreviousItem;
            this.AgendasBindingNavigator.Name = "AgendasBindingNavigator";
            this.AgendasBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.AgendasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.AgendasBindingNavigator.Size = new System.Drawing.Size(1135, 39);
            this.AgendasBindingNavigator.TabIndex = 2;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 36);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
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
            this.btnPreviousItem.Text = "de {0}";
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
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
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
            this.btnSave.Text = "de {0}";
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
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendamentoBindingSource
            // 
            this.agendamentoBindingSource.DataMember = "agendamento";
            this.agendamentoBindingSource.DataSource = this.masterDataSet;
            // 
            // agendamentoTableAdapter
            // 
            this.agendamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicosTableAdapter = null;
            this.tableAdapterManager.agendamentoTableAdapter = this.agendamentoTableAdapter;
            this.tableAdapterManager.animalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.racaTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WordPet.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.wordldpetTableAdapter = null;
            this.tableAdapterManager.worldpetTableAdapter = null;
            // 
            // ag_codigoLabel
            // 
            ag_codigoLabel.AutoSize = true;
            ag_codigoLabel.Location = new System.Drawing.Point(31, 43);
            ag_codigoLabel.Name = "ag_codigoLabel";
            ag_codigoLabel.Size = new System.Drawing.Size(87, 23);
            ag_codigoLabel.TabIndex = 0;
            ag_codigoLabel.Text = "Código:";
            // 
            // ag_codigoTextBox
            // 
            this.ag_codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "ag_codigo", true));
            this.ag_codigoTextBox.Location = new System.Drawing.Point(231, 43);
            this.ag_codigoTextBox.Name = "ag_codigoTextBox";
            this.ag_codigoTextBox.Size = new System.Drawing.Size(200, 32);
            this.ag_codigoTextBox.TabIndex = 1;
            // 
            // ag_dataLabel
            // 
            ag_dataLabel.AutoSize = true;
            ag_dataLabel.Location = new System.Drawing.Point(31, 118);
            ag_dataLabel.Name = "ag_dataLabel";
            ag_dataLabel.Size = new System.Drawing.Size(65, 23);
            ag_dataLabel.TabIndex = 2;
            ag_dataLabel.Text = "Data:";
            // 
            // ag_dataDateTimePicker
            // 
            this.ag_dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.agendamentoBindingSource, "ag_data", true));
            this.ag_dataDateTimePicker.Location = new System.Drawing.Point(231, 117);
            this.ag_dataDateTimePicker.Name = "ag_dataDateTimePicker";
            this.ag_dataDateTimePicker.Size = new System.Drawing.Size(200, 32);
            this.ag_dataDateTimePicker.TabIndex = 3;
            // 
            // ag_horarioLabel
            // 
            ag_horarioLabel.AutoSize = true;
            ag_horarioLabel.Location = new System.Drawing.Point(31, 185);
            ag_horarioLabel.Name = "ag_horarioLabel";
            ag_horarioLabel.Size = new System.Drawing.Size(84, 23);
            ag_horarioLabel.TabIndex = 4;
            ag_horarioLabel.Text = "Horario:";
            // 
            // ag_horarioTextBox
            // 
            this.ag_horarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ag_horarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "ag_horario", true));
            this.ag_horarioTextBox.Location = new System.Drawing.Point(231, 185);
            this.ag_horarioTextBox.Name = "ag_horarioTextBox";
            this.ag_horarioTextBox.Size = new System.Drawing.Size(200, 32);
            this.ag_horarioTextBox.TabIndex = 5;
            // 
            // ag_situacaoLabel
            // 
            ag_situacaoLabel.AutoSize = true;
            ag_situacaoLabel.Location = new System.Drawing.Point(31, 252);
            ag_situacaoLabel.Name = "ag_situacaoLabel";
            ag_situacaoLabel.Size = new System.Drawing.Size(101, 23);
            ag_situacaoLabel.TabIndex = 6;
            ag_situacaoLabel.Text = "Situacao:";
            // 
            // ag_situacaoTextBox
            // 
            this.ag_situacaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ag_situacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "ag_situacao", true));
            this.ag_situacaoTextBox.Location = new System.Drawing.Point(231, 252);
            this.ag_situacaoTextBox.Name = "ag_situacaoTextBox";
            this.ag_situacaoTextBox.Size = new System.Drawing.Size(200, 32);
            this.ag_situacaoTextBox.TabIndex = 7;
            // 
            // ag_animalLabel
            // 
            ag_animalLabel.AutoSize = true;
            ag_animalLabel.Location = new System.Drawing.Point(31, 320);
            ag_animalLabel.Name = "ag_animalLabel";
            ag_animalLabel.Size = new System.Drawing.Size(83, 23);
            ag_animalLabel.TabIndex = 8;
            ag_animalLabel.Text = "Animal:";
            // 
            // ag_animalTextBox
            // 
            this.ag_animalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ag_animalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "ag_animal", true));
            this.ag_animalTextBox.Location = new System.Drawing.Point(231, 320);
            this.ag_animalTextBox.Name = "ag_animalTextBox";
            this.ag_animalTextBox.Size = new System.Drawing.Size(200, 32);
            this.ag_animalTextBox.TabIndex = 9;
            // 
            // ag_totalLabel
            // 
            ag_totalLabel.AutoSize = true;
            ag_totalLabel.Location = new System.Drawing.Point(31, 387);
            ag_totalLabel.Name = "ag_totalLabel";
            ag_totalLabel.Size = new System.Drawing.Size(62, 23);
            ag_totalLabel.TabIndex = 10;
            ag_totalLabel.Text = "Total:";
            // 
            // ag_totalTextBox
            // 
            this.ag_totalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ag_totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "ag_total", true));
            this.ag_totalTextBox.Location = new System.Drawing.Point(231, 387);
            this.ag_totalTextBox.Name = "ag_totalTextBox";
            this.ag_totalTextBox.Size = new System.Drawing.Size(200, 32);
            this.ag_totalTextBox.TabIndex = 11;
            // 
            // frmAgendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1135, 869);
            this.Controls.Add(this.AgendasBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgendas";
            this.Text = "frmAgendas";
            this.Load += new System.EventHandler(this.frmAgendas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgendasBindingNavigator)).EndInit();
            this.AgendasBindingNavigator.ResumeLayout(false);
            this.AgendasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingNavigator AgendasBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnFirstItem;
        private System.Windows.Forms.ToolStripButton btnPreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton btnNextItem;
        private System.Windows.Forms.ToolStripButton btnLastItem;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btDelete;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource agendamentoBindingSource;
        private masterDataSetTableAdapters.agendamentoTableAdapter agendamentoTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox ag_codigoTextBox;
        private System.Windows.Forms.DateTimePicker ag_dataDateTimePicker;
        private System.Windows.Forms.TextBox ag_horarioTextBox;
        private System.Windows.Forms.TextBox ag_situacaoTextBox;
        private System.Windows.Forms.TextBox ag_animalTextBox;
        private System.Windows.Forms.TextBox ag_totalTextBox;
    }
}