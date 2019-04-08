namespace ModeloDeMelhoria
{
    partial class ModeloBrowseForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.qryAreas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.qryMetasGenericas = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.qryNiveisCapacidade = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.qryMetasEspecificas = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.qryPraticasEspecificas = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.cboModelo = new System.Windows.Forms.ComboBox();
            this.NOME = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.qryNiveisMaturidade = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qryAreas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qryMetasGenericas)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qryNiveisCapacidade)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qryMetasEspecificas)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qryPraticasEspecificas)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qryNiveisMaturidade)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.qryAreas);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Áreas de Processo";
            // 
            // qryAreas
            // 
            this.qryAreas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.qryAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qryAreas.Location = new System.Drawing.Point(6, 19);
            this.qryAreas.Name = "qryAreas";
            this.qryAreas.Size = new System.Drawing.Size(306, 157);
            this.qryAreas.TabIndex = 0;
            this.qryAreas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.qryAreas_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.qryMetasGenericas);
            this.groupBox2.Location = new System.Drawing.Point(336, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 177);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Metas Genéricas";
            // 
            // qryMetasGenericas
            // 
            this.qryMetasGenericas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.qryMetasGenericas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qryMetasGenericas.Location = new System.Drawing.Point(6, 17);
            this.qryMetasGenericas.Name = "qryMetasGenericas";
            this.qryMetasGenericas.Size = new System.Drawing.Size(432, 150);
            this.qryMetasGenericas.TabIndex = 1;
            this.qryMetasGenericas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.qryMetasGenericas_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.qryNiveisCapacidade);
            this.groupBox3.Location = new System.Drawing.Point(786, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 177);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Níveis de Capacidade";
            // 
            // qryNiveisCapacidade
            // 
            this.qryNiveisCapacidade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.qryNiveisCapacidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qryNiveisCapacidade.Location = new System.Drawing.Point(6, 13);
            this.qryNiveisCapacidade.Name = "qryNiveisCapacidade";
            this.qryNiveisCapacidade.Size = new System.Drawing.Size(265, 150);
            this.qryNiveisCapacidade.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.qryMetasEspecificas);
            this.groupBox5.Location = new System.Drawing.Point(336, 195);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(231, 252);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Metas Específicas";
            // 
            // qryMetasEspecificas
            // 
            this.qryMetasEspecificas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.qryMetasEspecificas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qryMetasEspecificas.Location = new System.Drawing.Point(6, 19);
            this.qryMetasEspecificas.Name = "qryMetasEspecificas";
            this.qryMetasEspecificas.Size = new System.Drawing.Size(219, 227);
            this.qryMetasEspecificas.TabIndex = 2;
            this.qryMetasEspecificas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.qryMetasEspecificas_CellClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.qryPraticasEspecificas);
            this.groupBox6.Location = new System.Drawing.Point(573, 195);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(231, 252);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Práticas Específicas";
            // 
            // qryPraticasEspecificas
            // 
            this.qryPraticasEspecificas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.qryPraticasEspecificas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qryPraticasEspecificas.Location = new System.Drawing.Point(6, 19);
            this.qryPraticasEspecificas.Name = "qryPraticasEspecificas";
            this.qryPraticasEspecificas.Size = new System.Drawing.Size(210, 221);
            this.qryPraticasEspecificas.TabIndex = 3;
            this.qryPraticasEspecificas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.qryPraticasEspecificas_CellClick);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dataGridView6);
            this.groupBox7.Location = new System.Drawing.Point(810, 195);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(231, 252);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Produtos de Trabalho";
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(6, 19);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(219, 227);
            this.dataGridView6.TabIndex = 2;
            // 
            // cboModelo
            // 
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.Location = new System.Drawing.Point(127, 2);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(121, 21);
            this.cboModelo.TabIndex = 7;
            this.cboModelo.SelectedIndexChanged += new System.EventHandler(this.cboModelo_SelectedIndexChanged);
            // 
            // NOME
            // 
            this.NOME.AutoSize = true;
            this.NOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOME.Location = new System.Drawing.Point(12, 1);
            this.NOME.Name = "NOME";
            this.NOME.Size = new System.Drawing.Size(89, 25);
            this.NOME.TabIndex = 8;
            this.NOME.Text = "Modelo:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.qryNiveisMaturidade);
            this.groupBox4.Location = new System.Drawing.Point(12, 220);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(318, 227);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Níveis de Maturidade";
            // 
            // qryNiveisMaturidade
            // 
            this.qryNiveisMaturidade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.qryNiveisMaturidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qryNiveisMaturidade.Location = new System.Drawing.Point(6, 19);
            this.qryNiveisMaturidade.Name = "qryNiveisMaturidade";
            this.qryNiveisMaturidade.Size = new System.Drawing.Size(306, 202);
            this.qryNiveisMaturidade.TabIndex = 0;
            // 
            // ModeloBrowseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 452);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.NOME);
            this.Controls.Add(this.cboModelo);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModeloBrowseForm";
            this.Text = "Visualizar Modelos";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qryAreas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qryMetasGenericas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qryNiveisCapacidade)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qryMetasEspecificas)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qryPraticasEspecificas)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qryNiveisMaturidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cboModelo;
        private System.Windows.Forms.Label NOME;
        private System.Windows.Forms.DataGridView qryAreas;
        private System.Windows.Forms.DataGridView qryMetasGenericas;
        private System.Windows.Forms.DataGridView qryNiveisCapacidade;
        private System.Windows.Forms.DataGridView qryMetasEspecificas;
        private System.Windows.Forms.DataGridView qryPraticasEspecificas;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView qryNiveisMaturidade;
    }
}