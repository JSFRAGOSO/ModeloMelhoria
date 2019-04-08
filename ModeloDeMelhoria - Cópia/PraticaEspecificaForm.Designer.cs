namespace ModeloDeMelhoria
{
    partial class PraticaEspecificaForm
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.descricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.NOME = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.sigla = new System.Windows.Forms.Label();
            this.cboMeta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResetFilterArea = new System.Windows.Forms.Button();
            this.btnFiltrarAreasAdds = new System.Windows.Forms.Button();
            this.btnAddArea = new System.Windows.Forms.Button();
            this.qryAreas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.qryAreas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(283, 331);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 35);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(132, 331);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(86, 35);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // descricao
            // 
            this.descricao.AutoSize = true;
            this.descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao.Location = new System.Drawing.Point(12, 72);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(114, 25);
            this.descricao.TabIndex = 13;
            this.descricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(132, 75);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(249, 172);
            this.txtDescricao.TabIndex = 12;
            this.txtDescricao.Text = "";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(132, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(283, 20);
            this.txtNome.TabIndex = 11;
            // 
            // NOME
            // 
            this.NOME.AutoSize = true;
            this.NOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOME.Location = new System.Drawing.Point(12, 47);
            this.NOME.Name = "NOME";
            this.NOME.Size = new System.Drawing.Size(74, 25);
            this.NOME.TabIndex = 10;
            this.NOME.Text = "Nome:";
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(132, 22);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(72, 20);
            this.txtSigla.TabIndex = 9;
            this.txtSigla.Leave += new System.EventHandler(this.txtSigla_Leave);
            // 
            // sigla
            // 
            this.sigla.AutoSize = true;
            this.sigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigla.Location = new System.Drawing.Point(12, 22);
            this.sigla.Name = "sigla";
            this.sigla.Size = new System.Drawing.Size(66, 25);
            this.sigla.TabIndex = 8;
            this.sigla.Text = "Sigla:";
            // 
            // cboMeta
            // 
            this.cboMeta.FormattingEnabled = true;
            this.cboMeta.Location = new System.Drawing.Point(378, 21);
            this.cboMeta.Name = "cboMeta";
            this.cboMeta.Size = new System.Drawing.Size(258, 21);
            this.cboMeta.TabIndex = 16;
            this.cboMeta.SelectedIndexChanged += new System.EventHandler(this.cboMeta_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Meta Específica:";
            // 
            // btnResetFilterArea
            // 
            this.btnResetFilterArea.Location = new System.Drawing.Point(618, 309);
            this.btnResetFilterArea.Name = "btnResetFilterArea";
            this.btnResetFilterArea.Size = new System.Drawing.Size(54, 35);
            this.btnResetFilterArea.TabIndex = 23;
            this.btnResetFilterArea.Text = "Refresh";
            this.btnResetFilterArea.UseVisualStyleBackColor = true;
            // 
            // btnFiltrarAreasAdds
            // 
            this.btnFiltrarAreasAdds.Location = new System.Drawing.Point(511, 309);
            this.btnFiltrarAreasAdds.Name = "btnFiltrarAreasAdds";
            this.btnFiltrarAreasAdds.Size = new System.Drawing.Size(101, 35);
            this.btnFiltrarAreasAdds.TabIndex = 22;
            this.btnFiltrarAreasAdds.Text = "Filtrar adicionados";
            this.btnFiltrarAreasAdds.UseVisualStyleBackColor = true;
            // 
            // btnAddArea
            // 
            this.btnAddArea.Location = new System.Drawing.Point(445, 309);
            this.btnAddArea.Name = "btnAddArea";
            this.btnAddArea.Size = new System.Drawing.Size(60, 35);
            this.btnAddArea.TabIndex = 21;
            this.btnAddArea.Text = "Adicionar Área";
            this.btnAddArea.UseVisualStyleBackColor = true;
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
            this.qryAreas.Location = new System.Drawing.Point(2, 17);
            this.qryAreas.MultiSelect = false;
            this.qryAreas.Name = "qryAreas";
            this.qryAreas.Size = new System.Drawing.Size(233, 231);
            this.qryAreas.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.qryAreas);
            this.groupBox1.Location = new System.Drawing.Point(443, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 254);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos de Trabalho";
            // 
            // PraticaEspecificaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 378);
            this.Controls.Add(this.btnResetFilterArea);
            this.Controls.Add(this.btnFiltrarAreasAdds);
            this.Controls.Add(this.btnAddArea);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMeta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.NOME);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.sigla);
            this.Name = "PraticaEspecificaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prática Específica";
            ((System.ComponentModel.ISupportInitialize)(this.qryAreas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label descricao;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label NOME;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label sigla;
        private System.Windows.Forms.ComboBox cboMeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResetFilterArea;
        private System.Windows.Forms.Button btnFiltrarAreasAdds;
        private System.Windows.Forms.Button btnAddArea;
        private System.Windows.Forms.DataGridView qryAreas;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}