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
    public partial class AreaProcessoForm : Form
    {
        PostgreSQL pgSQL = new PostgreSQL();
        

        public AreaProcessoForm()
        {
            InitializeComponent();
            carregarComboNivel();
            carregarComboCategoria();
            
        }

        private void carregarComboNivel()
        {
            String comandoSQL;
            DataSet dadosdataSet = new DataSet();
            dadosdataSet.Clear();
            pgSQL.abrirConexao();
            comandoSQL = "SELECT * FROM nivelmaturidade";

            NpgsqlDataAdapter dados = new Npgsql.NpgsqlDataAdapter(comandoSQL, pgSQL.getConnectionString());

            dados.Fill(dadosdataSet);


            cboNivel.DataSource = dadosdataSet.Tables[0];
            cboNivel.ValueMember = "sigla";
            cboNivel.DisplayMember = "nome";
            pgSQL.fecharConexao();

        }

        private void carregarComboCategoria()
        {
            String comandoSQL;
            DataSet dadosdataSet = new DataSet();
            dadosdataSet.Clear();
            pgSQL.abrirConexao();
            comandoSQL = "SELECT * FROM categoria";

            NpgsqlDataAdapter dados = new Npgsql.NpgsqlDataAdapter(comandoSQL, pgSQL.getConnectionString());

            dados.Fill(dadosdataSet);


            cboCategoria.DataSource = dadosdataSet.Tables[0];
            cboCategoria.ValueMember = "nome";
            cboCategoria.DisplayMember = "nome";
            pgSQL.fecharConexao();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            String mensagem = "";
            String ComandoSQL = "INSERT INTO areaprocesso(sigla,nome,descricao,nivelmaturidade,categoria) " +
                                "VALUES('" + txtSigla.Text + "','" + txtNome.Text + "','" + txtDescricao.Text + "','" + cboNivel.SelectedValue + "','" + cboCategoria.SelectedValue + "');";

            PostgreSQL pgSQL = new PostgreSQL();

            mensagem = pgSQL.ExecutarComandoSQL(ComandoSQL);

            if (mensagem != "")
            {
                MessageBox.Show(mensagem);
            }
            else
            {
                MessageBox.Show("Área de Processo cadastrada com sucesso!");
                txtSigla.Clear();
                txtDescricao.Clear();
                txtNome.Clear();
                txtSigla.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
