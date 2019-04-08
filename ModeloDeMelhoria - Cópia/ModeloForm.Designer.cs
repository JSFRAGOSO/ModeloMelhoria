namespace ModeloDeMelhoria
{
    partial class ModeloForm
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
            this.btnOkButton = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.descricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.NOME = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.sigla = new System.Windows.Forms.Label();
            this.qryAreas = new System.Windows.Forms.DataGridView();
            this.btnAddArea = new System.Windows.Forms.Button();
            this.btnFiltrarAreasAdds = new System.Windows.Forms.Button();
            this.btnResetFilterArea = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResetFilterMetas = new System.Windows.Forms.Button();
            this.btnFilterMetasAdds = new System.Windows.Forms.Button();
            this.btnAddMeta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.qryMetas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.qryAreas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qryMetas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOkButton
            // 
            this.btnOkButton.Location = new System.Drawing.Point(17, 285);
            this.btnOkButton.Name = "btnOkButton";
            this.btnOkButton.Size = new System.Drawing.Size(86, 35);
            this.btnOkButton.TabIndex = 15;
            this.btnOkButton.Text = "Confirmar";
            this.btnOkButton.UseVisualStyleBackColor = true;
            this.btnOkButton.Click += new System.EventHandler(this.btnOkButton_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(221, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(78, 30);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Criar Modelo";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // descricao
            // 
            this.descricao.AutoSize = true;
            this.descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao.Location = new System.Drawing.Point(12, 59);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(114, 25);
            this.descricao.TabIndex = 13;
            this.descricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(17, 87);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(282, 167);
            this.txtDescricao.TabIndex = 12;
            this.txtDescricao.Text = "";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(84, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(215, 20);
            this.txtNome.TabIndex = 11;
            // 
            // NOME
            // 
            this.NOME.AutoSize = true;
            this.NOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOME.Location = new System.Drawing.Point(12, 34);
            this.NOME.Name = "NOME";
            this.NOME.Size = new System.Drawing.Size(74, 25);
            this.NOME.TabIndex = 10;
            this.NOME.Text = "Nome:";
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(84, 9);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(72, 20);
            this.txtSigla.TabIndex = 9;
            // 
            // sigla
            // 
            this.sigla.AutoSize = true;
            this.sigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigla.Location = new System.Drawing.Point(12, 9);
            this.sigla.Name = "sigla";
            this.sigla.Size = new System.Drawing.Size(66, 25);
            this.sigla.TabIndex = 8;
            this.sigla.Text = "Sigla:";
            // 
            // qryAreas
            // 
            this.qryAreas.AllowUserToAddRows = false;
            this.qryAreas.AllowUserToDeleteRows = false;
            this.qryAreas.AllowUserToResizeColumns = false;
            this.qryAreas.AllowUserToResizeRows = false;
            this.qryAreas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.qryAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qryAreas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.qryAreas.Location = new System.Drawing.Point(0, 17);
            this.qryAreas.MultiSelect = false;
            this.qryAreas.Name = "qryAreas";
            this.qryAreas.Size = new System.Drawing.Size(233, 231);
            this.qryAreas.TabIndex = 16;
            this.qryAreas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.qryAreas_CellClick);
            this.qryAreas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.qryAreas_CellContentClick);
            // 
            // btnAddArea
            // 
            this.btnAddArea.Location = new System.Drawing.Point(305, 272);
            this.btnAddArea.Name = "btnAddArea";
            this.btnAddArea.Size = new System.Drawing.Size(60, 35);
            this.btnAddArea.TabIndex = 17;
            this.btnAddArea.Text = "Adicionar Área";
            this.btnAddArea.UseVisualStyleBackColor = true;
            this.btnAddArea.Click += new System.EventHandler(this.btnAddArea_Click);
            // 
            // btnFiltrarAreasAdds
            // 
            this.btnFiltrarAreasAdds.Location = new System.Drawing.Point(371, 272);
            this.btnFiltrarAreasAdds.Name = "btnFiltrarAreasAdds";
            this.btnFiltrarAreasAdds.Size = new System.Drawing.Size(101, 35);
            this.btnFiltrarAreasAdds.TabIndex = 18;
            this.btnFiltrarAreasAdds.Text = "Filtrar adicionados";
            this.btnFiltrarAreasAdds.UseVisualStyleBackColor = true;
            this.btnFiltrarAreasAdds.Click += new System.EventHandler(this.btnFiltrarAreasAdds_Click);
            // 
            // btnResetFilterArea
            // 
            this.btnResetFilterArea.Location = new System.Drawing.Point(478, 272);
            this.btnResetFilterArea.Name = "btnResetFilterArea";
            this.btnResetFilterArea.Size = new System.Drawing.Size(54, 35);
            this.btnResetFilterArea.TabIndex = 19;
            this.btnResetFilterArea.Text = "Refresh";
            this.btnResetFilterArea.UseVisualStyleBackColor = true;
            this.btnResetFilterArea.Click += new System.EventHandler(this.btnResetFilterArea_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.qryAreas);
            this.groupBox1.Location = new System.Drawing.Point(305, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 254);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Áreas de Processo";
            // 
            // btnResetFilterMetas
            // 
            this.btnResetFilterMetas.Location = new System.Drawing.Point(703, 272);
            this.btnResetFilterMetas.Name = "btnResetFilterMetas";
            this.btnResetFilterMetas.Size = new System.Drawing.Size(56, 35);
            this.btnResetFilterMetas.TabIndex = 23;
            this.btnResetFilterMetas.Text = "Refresh";
            this.btnResetFilterMetas.UseVisualStyleBackColor = true;
            this.btnResetFilterMetas.Click += new System.EventHandler(this.btnResetFilterMetas_Click);
            // 
            // btnFilterMetasAdds
            // 
            this.btnFilterMetasAdds.Location = new System.Drawing.Point(619, 272);
            this.btnFilterMetasAdds.Name = "btnFilterMetasAdds";
            this.btnFilterMetasAdds.Size = new System.Drawing.Size(78, 35);
            this.btnFilterMetasAdds.TabIndex = 22;
            this.btnFilterMetasAdds.Text = "Filtrar adicionadas";
            this.btnFilterMetasAdds.UseVisualStyleBackColor = true;
            this.btnFilterMetasAdds.Click += new System.EventHandler(this.btnFilterMetasAdds_Click);
            // 
            // btnAddMeta
            // 
            this.btnAddMeta.Location = new System.Drawing.Point(553, 272);
            this.btnAddMeta.Name = "btnAddMeta";
            this.btnAddMeta.Size = new System.Drawing.Size(60, 35);
            this.btnAddMeta.TabIndex = 21;
            this.btnAddMeta.Text = "Adicionar Meta";
            this.btnAddMeta.UseVisualStyleBackColor = true;
            this.btnAddMeta.Click += new System.EventHandler(this.btnAddMeta_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.qryMetas);
            this.groupBox2.Location = new System.Drawing.Point(547, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 254);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Metas Genéricas";
            // 
            // qryMetas
            // 
            this.qryMetas.AllowUserToAddRows = false;
            this.qryMetas.AllowUserToDeleteRows = false;
            this.qryMetas.AllowUserToResizeColumns = false;
            this.qryMetas.AllowUserToResizeRows = false;
            this.qryMetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.qryMetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qryMetas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.qryMetas.Location = new System.Drawing.Point(3, 17);
            this.qryMetas.MultiSelect = false;
            this.qryMetas.Name = "qryMetas";
            this.qryMetas.Size = new System.Drawing.Size(209, 231);
            this.qryMetas.TabIndex = 17;
            this.qryMetas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.qryMetas_CellClick);
            // 
            // ModeloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 332);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnResetFilterMetas);
            this.Controls.Add(this.btnFilterMetasAdds);
            this.Controls.Add(this.btnAddMeta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnResetFilterArea);
            this.Controls.Add(this.btnFiltrarAreasAdds);
            this.Controls.Add(this.btnAddArea);
            this.Controls.Add(this.btnOkButton);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.NOME);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.sigla);
            this.Name = "ModeloForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModeloForm";
            this.Load += new System.EventHandler(this.ModeloForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qryAreas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qryMetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOkButton;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label descricao;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label NOME;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label sigla;
        private System.Windows.Forms.DataGridView qryAreas;
        private System.Windows.Forms.Button btnAddArea;
        private System.Windows.Forms.Button btnFiltrarAreasAdds;
        private System.Windows.Forms.Button btnResetFilterArea;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnResetFilterMetas;
        private System.Windows.Forms.Button btnFilterMetasAdds;
        private System.Windows.Forms.Button btnAddMeta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView qryMetas;
    }
}