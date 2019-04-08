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
    public partial class ModeloForm : Form
    {
        PostgreSQL pgSQL = new PostgreSQL();
        
        String SiglaAreaAtual = "";
        String SiglaMetaAtual = "";

        public ModeloForm()
        {
            InitializeComponent();
            HabilitarDesabilitarItens(false);
        }

        private void ModeloForm_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            /*String mensagem = "";
            String ComandoSQL = "INSERT INTO modelo(sigla,nome,descricao) " +
                                "VALUES('" + txtSigla.Text + "','" + txtNome.Text + "','" + txtDescricao.Text + "');";

            PostgreSQL pgSQL = new PostgreSQL();

            mensagem = pgSQL.ExecutarComandoSQL(ComandoSQL);

            if (mensagem != "")
            {
                MessageBox.Show(mensagem);
            }
            else
            {*/
                MessageBox.Show("Modelo Gerado com sucesso!");
                HabilitarDesabilitarItens(true);
                carregarAreas();

                carregarMetas();

            //}


        }

        private void HabilitarDesabilitarItens(bool acao)
        {   
                qryAreas.Enabled = acao;
                qryMetas.Enabled = acao;
                btnAddArea.Enabled = acao;
                btnFiltrarAreasAdds.Enabled = acao;
                btnResetFilterArea.Enabled = acao;
                
                btnAddMeta.Enabled = acao;
                btnFilterMetasAdds.Enabled = acao;
                btnResetFilterMetas.Enabled = acao;
        }

        private void carregarAreas() {

            DataSet dadosdataSet = new DataSet();
            String comandoSQL;

            dadosdataSet.Clear();
            pgSQL.abrirConexao();

            comandoSQL = "SELECT sigla,nome FROM areaprocesso WHERE modelo IS NULL";

            NpgsqlDataAdapter dados = new Npgsql.NpgsqlDataAdapter(comandoSQL, pgSQL.getConnectionString());

            dados.Fill(dadosdataSet);


            qryAreas.DataSource = dadosdataSet.Tables[0];

            pgSQL.fecharConexao();

        }

        private void carregarMetas()
        {
            DataSet dadosdataSet = new DataSet();
            String comandoSQL;

            dadosdataSet.Clear();
            pgSQL.abrirConexao();

            comandoSQL = "SELECT sigla,nome FROM metagenerica WHERE modelo IS NULL";

            NpgsqlDataAdapter dados = new Npgsql.NpgsqlDataAdapter(comandoSQL, pgSQL.getConnectionString());

            dados.Fill(dadosdataSet);


            qryMetas.DataSource = dadosdataSet.Tables[0];



            pgSQL.fecharConexao();

        }

        private void btnAddArea_Click(object sender, EventArgs e)
        {

            String ComandoSQL = "UPDATE areaprocesso SET " +
                                "modelo = '" + txtSigla.Text + "' "+
                                "WHERE sigla = '" + SiglaAreaAtual + "'";

            String mensagem = pgSQL.ExecutarComandoSQL(ComandoSQL);

            if (mensagem != "")
                MessageBox.Show(mensagem);

            carregarAreas();
        }

        private void btnAddMeta_Click(object sender, EventArgs e)
        {
            String ComandoSQL = "UPDATE metagenerica SET " +
                                    "modelo = '" + txtSigla.Text + "' " +
                                    "WHERE sigla = '" + SiglaMetaAtual + "'";

            String mensagem = pgSQL.ExecutarComandoSQL(ComandoSQL);

            if (mensagem != "")
                MessageBox.Show(mensagem);
            carregarMetas();
        }

        private void qryAreas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow selectedRow = qryAreas.Rows[index];
            SiglaAreaAtual = selectedRow.Cells[0].Value.ToString();
        }

        private void qryMetas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow selectedRow = qryMetas.Rows[index];
            SiglaMetaAtual = selectedRow.Cells[0].Value.ToString();

        }

        private void btnResetFilterArea_Click(object sender, EventArgs e)
        {
            carregarAreas();
        }

        

        private void btnFiltrarAreasAdds_Click(object sender, EventArgs e)
        {
            DataSet dadosdataSet = new DataSet();

            String comandoSQL;

            dadosdataSet.Clear();
            pgSQL.abrirConexao();

            comandoSQL = "SELECT nome,sigla FROM areaprocesso WHERE modelo = '" + txtSigla.Text + "'";

            NpgsqlDataAdapter dados = new Npgsql.NpgsqlDataAdapter(comandoSQL, pgSQL.getConnectionString());

            dados.Fill(dadosdataSet);


            qryAreas.DataSource = dadosdataSet.Tables[0];

            pgSQL.fecharConexao();
        }

        private void btnResetFilterMetas_Click(object sender, EventArgs e)
        {
            carregarMetas();
        }

        private void btnFilterMetasAdds_Click(object sender, EventArgs e)
        {
            DataSet dadosdataSet = new DataSet();

            String comandoSQL;

            dadosdataSet.Clear();
            pgSQL.abrirConexao();

            comandoSQL = "SELECT nome,sigla FROM metagenerica WHERE modelo = '" + txtSigla.Text + "'";

            NpgsqlDataAdapter dados = new Npgsql.NpgsqlDataAdapter(comandoSQL, pgSQL.getConnectionString());

            dados.Fill(dadosdataSet);


            qryMetas.DataSource = dadosdataSet.Tables[0];

            pgSQL.fecharConexao();
        }

        private void btnOkButton_Click(object sender, EventArgs e)
        {
            String mensagem = "";
            String ComandoSQL = "INSERT INTO modelo(sigla,nome,descricao) " +
                                "VALUES('" + txtSigla.Text + "','" + txtNome.Text + "','" + txtDescricao.Text + "');";

            PostgreSQL pgSQL = new PostgreSQL();

            mensagem = pgSQL.ExecutarComandoSQL(ComandoSQL);

            if (mensagem != "")
            {
                MessageBox.Show(mensagem);
            }
            else
            {
                Close();
            }
        }

        private void qryAreas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
