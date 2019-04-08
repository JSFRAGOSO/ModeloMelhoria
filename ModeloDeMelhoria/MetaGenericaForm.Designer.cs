namespace ModeloDeMelhoria
{
    partial class MetaGenericaForm
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
            this.cboNivel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(265, 205);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 35);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(132, 205);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(86, 35);
            this.btnConfirmar.TabIndex = 22;
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
            this.descricao.TabIndex = 21;
            this.descricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(132, 75);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(282, 120);
            this.txtDescricao.TabIndex = 20;
            this.txtDescricao.Text = "";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(132, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(155, 20);
            this.txtNome.TabIndex = 19;
            // 
            // NOME
            // 
            this.NOME.AutoSize = true;
            this.NOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOME.Location = new System.Drawing.Point(12, 47);
            this.NOME.Name = "NOME";
            this.NOME.Size = new System.Drawing.Size(74, 25);
            this.NOME.TabIndex = 18;
            this.NOME.Text = "Nome:";
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(132, 22);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(72, 20);
            this.txtSigla.TabIndex = 17;
            // 
            // sigla
            // 
            this.sigla.AutoSize = true;
            this.sigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigla.Location = new System.Drawing.Point(12, 22);
            this.sigla.Name = "sigla";
            this.sigla.Size = new System.Drawing.Size(66, 25);
            this.sigla.TabIndex = 16;
            this.sigla.Text = "Sigla:";
            // 
            // cboNivel
            // 
            this.cboNivel.FormattingEnabled = true;
            this.cboNivel.Location = new System.Drawing.Point(293, 22);
            this.cboNivel.Name = "cboNivel";
            this.cboNivel.Size = new System.Drawing.Size(121, 21);
            this.cboNivel.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nível:";
            // 
            // MetaGenericaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboNivel);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.NOME);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.sigla);
            this.Name = "MetaGenericaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Meta Genérica";
            this.Load += new System.EventHandler(this.MetaGenericaForm_Load);
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
        private System.Windows.Forms.ComboBox cboNivel;
        private System.Windows.Forms.Label label1;
    }
}