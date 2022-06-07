namespace WordPet
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelSelect = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnAgendamentos = new System.Windows.Forms.Button();
            this.btnServicos = new System.Windows.Forms.Button();
            this.btnAnimais = new System.Windows.Forms.Button();
            this.btnRaca = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnCloser = new System.Windows.Forms.Button();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelSide.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSide.Controls.Add(this.panelSelect);
            this.panelSide.Controls.Add(this.btnInicio);
            this.panelSide.Controls.Add(this.btnAgendamentos);
            this.panelSide.Controls.Add(this.btnServicos);
            this.panelSide.Controls.Add(this.btnAnimais);
            this.panelSide.Controls.Add(this.btnRaca);
            this.panelSide.Controls.Add(this.btnClientes);
            this.panelSide.Location = new System.Drawing.Point(5, 78);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(598, 916);
            this.panelSide.TabIndex = 1;
            this.panelSide.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSide_Paint);
            // 
            // panelSelect
            // 
            this.panelSelect.BackgroundImage = global::WordPet.Properties.Resources.seletor;
            this.panelSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSelect.Location = new System.Drawing.Point(19, 253);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(104, 64);
            this.panelSelect.TabIndex = 6;
            // 
            // btnInicio
            // 
            this.btnInicio.BackgroundImage = global::WordPet.Properties.Resources.pata2;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Location = new System.Drawing.Point(192, 44);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(234, 169);
            this.btnInicio.TabIndex = 5;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnAgendamentos
            // 
            this.btnAgendamentos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgendamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgendamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendamentos.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAgendamentos.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.btnAgendamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnAgendamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAgendamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamentos.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendamentos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgendamentos.Location = new System.Drawing.Point(129, 688);
            this.btnAgendamentos.Name = "btnAgendamentos";
            this.btnAgendamentos.Size = new System.Drawing.Size(347, 64);
            this.btnAgendamentos.TabIndex = 4;
            this.btnAgendamentos.Text = "Agendamentos";
            this.btnAgendamentos.UseVisualStyleBackColor = false;
            this.btnAgendamentos.Click += new System.EventHandler(this.btnAgendamentos_Click);
            // 
            // btnServicos
            // 
            this.btnServicos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnServicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnServicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicos.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnServicos.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.btnServicos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnServicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicos.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnServicos.Location = new System.Drawing.Point(129, 575);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(347, 64);
            this.btnServicos.TabIndex = 3;
            this.btnServicos.Text = "Serviços";
            this.btnServicos.UseVisualStyleBackColor = false;
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // btnAnimais
            // 
            this.btnAnimais.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAnimais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAnimais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnimais.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAnimais.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.btnAnimais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnAnimais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAnimais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimais.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimais.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnimais.Location = new System.Drawing.Point(129, 469);
            this.btnAnimais.Name = "btnAnimais";
            this.btnAnimais.Size = new System.Drawing.Size(347, 64);
            this.btnAnimais.TabIndex = 2;
            this.btnAnimais.Text = "Animais";
            this.btnAnimais.UseVisualStyleBackColor = false;
            this.btnAnimais.Click += new System.EventHandler(this.btnAnimais_Click);
            // 
            // btnRaca
            // 
            this.btnRaca.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRaca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRaca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRaca.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnRaca.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.btnRaca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnRaca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnRaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaca.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRaca.Location = new System.Drawing.Point(129, 359);
            this.btnRaca.Name = "btnRaca";
            this.btnRaca.Size = new System.Drawing.Size(347, 64);
            this.btnRaca.TabIndex = 1;
            this.btnRaca.Text = "Raças";
            this.btnRaca.UseVisualStyleBackColor = false;
            this.btnRaca.Click += new System.EventHandler(this.btnRaca_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnClientes.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClientes.Location = new System.Drawing.Point(129, 253);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(347, 64);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // panelTop
            // 
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTop.Controls.Add(this.btnMin);
            this.panelTop.Controls.Add(this.btnCloser);
            this.panelTop.Location = new System.Drawing.Point(5, 4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1745, 75);
            this.panelTop.TabIndex = 0;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMin.BackgroundImage = global::WordPet.Properties.Resources._2;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(1607, 18);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(47, 38);
            this.btnMin.TabIndex = 1;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnCloser
            // 
            this.btnCloser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCloser.BackgroundImage = global::WordPet.Properties.Resources.x;
            this.btnCloser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCloser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCloser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCloser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloser.Location = new System.Drawing.Point(1677, 18);
            this.btnCloser.Name = "btnCloser";
            this.btnCloser.Size = new System.Drawing.Size(47, 38);
            this.btnCloser.TabIndex = 0;
            this.btnCloser.UseVisualStyleBackColor = false;
            this.btnCloser.Click += new System.EventHandler(this.btnCloser_Click);
            // 
            // panelCenter
            // 
            this.panelCenter.BackgroundImage = global::WordPet.Properties.Resources.main_front;
            this.panelCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCenter.Location = new System.Drawing.Point(600, 78);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1150, 916);
            this.panelCenter.TabIndex = 1;
            this.panelCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCenter_Paint);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1755, 996);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelSide.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnCloser;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Button btnAgendamentos;
        private System.Windows.Forms.Button btnServicos;
        private System.Windows.Forms.Button btnAnimais;
        private System.Windows.Forms.Button btnRaca;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panelSelect;
    }
}

