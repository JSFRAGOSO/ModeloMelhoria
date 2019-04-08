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
    public partial class MetaEspecificaForm : Form
    {
        PostgreSQL pgSQL = new PostgreSQL();
        DataSet dadosdataSet = new DataSet();

        public MetaEspecificaForm()
        {
            InitializeComponent();
            carregarComboArea();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void carregarComboArea()
        {
            String comandoSQL;

            dadosdataSet.Clear();
            pgSQL.abrirConexao();
            comandoSQL = "SELECT * FROM areaprocesso";

            NpgsqlDataAdapter dados = new Npgsql.NpgsqlDataAdapter(comandoSQL, pgSQL.getConnectionString());

            dados.Fill(dadosdataSet);


            cboArea.DataSource = dadosdataSet.Tables[0];
            cboArea.ValueMember = "sigla";
            cboArea.DisplayMember = "nome";
            pgSQL.fecharConexao();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            String mensagem = "";
            String ComandoSQL = "INSERT INTO metaespecifica(sigla,nome,descricao,areaprocesso) " +
                                "VALUES('" + txtSigla.Text + "','" + txtNome.Text + "','" + txtDescricao.Text + "','" + cboArea.SelectedValue + "');";

            PostgreSQL pgSQL = new PostgreSQL();

            mensagem = pgSQL.ExecutarComandoSQL(ComandoSQL);

            if (mensagem != "")
            {
                MessageBox.Show(mensagem);
            }
            else
            {
                MessageBox.Show("Meta Específica cadastrada com sucesso!");
                txtSigla.Clear();
                txtDescricao.Clear();
                txtNome.Clear();
                txtSigla.Focus();
            }
        }
    }
}
