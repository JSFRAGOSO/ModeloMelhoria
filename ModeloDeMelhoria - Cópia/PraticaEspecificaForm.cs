using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloDeMelhoria
{
    public partial class PraticaEspecificaForm : Form
    {
        PostgreSQL pgSQL = new PostgreSQL();
        DataSet dadosdataSet = new DataSet();
        
        public PraticaEspecificaForm()
        {
            InitializeComponent();
            carregarComboMeta();

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void carregarComboMeta()
        {
            String comandoSQL;

            dadosdataSet.Clear();
            pgSQL.abrirConexao();
            comandoSQL = "SELECT * FROM metaespecifica";

            NpgsqlDataAdapter dados = new Npgsql.NpgsqlDataAdapter(comandoSQL, pgSQL.getConnectionString());

            dados.Fill(dadosdataSet);


            cboMeta.DataSource = dadosdataSet.Tables[0];
            cboMeta.ValueMember = "sigla";
            cboMeta.DisplayMember = "nome";
            pgSQL.fecharConexao();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            String mensagem = "";
            String ComandoSQL = "INSERT INTO praticaespecifica(sigla,nome,descricao,metaespecifica) " +
                                "VALUES('" + txtSigla.Text + "','" + txtNome.Text + "','" + txtDescricao.Text + "','" + cboMeta.SelectedValue + "');";

            PostgreSQL pgSQL = new PostgreSQL();

            mensagem = pgSQL.ExecutarComandoSQL(ComandoSQL);

            if (mensagem != "")
            {
                MessageBox.Show(mensagem);
            }
            else
            {
                
                MessageBox.Show("Pratica Específica cadastrada com sucesso!");
                txtSigla.Clear();
                txtDescricao.Clear();
                txtNome.Clear();
                txtSigla.Focus();
            }


           
        }

        private void cboMeta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSigla_Leave(object sender, EventArgs e)
        {

        }
    }


}
