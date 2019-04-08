using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloDeMelhoria
{
    public partial class MetaGenericaForm : Form
    {
        PostgreSQL pgSQL = new PostgreSQL();
        DataSet dadosdataSet = new DataSet();
        public MetaGenericaForm()
        {
            InitializeComponent();
            carregarComboNivel();
        }
    

        private void carregarComboNivel()
         {
            String comandoSQL;

            dadosdataSet.Clear();
            pgSQL.abrirConexao();
            comandoSQL = "SELECT * FROM nivelcapacidade";

            NpgsqlDataAdapter dados = new Npgsql.NpgsqlDataAdapter(comandoSQL, pgSQL.getConnectionString());

            dados.Fill(dadosdataSet);
            
            
            cboNivel.DataSource = dadosdataSet.Tables[0];
            cboNivel.ValueMember = "sigla";
            cboNivel.DisplayMember = "nome";
            pgSQL.fecharConexao();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            String mensagem = "";
            String ComandoSQL = "INSERT INTO metagenerica(sigla,nome,descricao,nivelcapacidade) " +
                                "VALUES('" + txtSigla.Text + "','" + txtNome.Text + "','" + txtDescricao.Text + "','" + cboNivel.SelectedValue + "');";

            PostgreSQL pgSQL = new PostgreSQL();

            mensagem = pgSQL.ExecutarComandoSQL(ComandoSQL);

            if (mensagem != "")
            {
                MessageBox.Show(mensagem);
            }
            else
            {
                MessageBox.Show("Meta Genérica cadastrada com sucesso!");
                txtSigla.Clear();
                txtDescricao.Clear();
                txtNome.Clear();
                txtSigla.Focus();
            }
        }

        private void MetaGenericaForm_Load(object sender, EventArgs e)
        {

        }
    }
}