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
    public partial class ModeloBrowseForm : Form
    {
        public ModeloBrowseForm()
        {
            InitializeComponent();
            carregarComboModelo();
        }

        private void carregarComboModelo()
        {
            PostgreSQL pgSQL = new PostgreSQL();
            String comandoSQL;
            DataSet dadosdataSet = new DataSet();
            dadosdataSet.Clear();
            pgSQL.abrirConexao();
            comandoSQL = "SELECT * FROM modelo";

            NpgsqlDataAdapter dados = new Npgsql.NpgsqlDataAdapter(comandoSQL, pgSQL.getConnectionString());

            dados.Fill(dadosdataSet);


            cboModelo.DataSource = dadosdataSet.Tables[0];
            cboModelo.ValueMember = "sigla";
            cboModelo.DisplayMember = "nome";
            pgSQL.fecharConexao();

        }

        private void cboModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String sigla = cboModelo.SelectedValue.ToString(); ;
            carregarAreas(sigla);
            carregarMetasGenericas(sigla);
        }
        private void qryAreas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow selectedRow = qryAreas.Rows[index];
            String SiglaAtual = selectedRow.Cells[1].Value.ToString();
            String NivelMaturidade = selectedRow.Cells[2].Value.ToString();
            carregarMetasEspecificas(SiglaAtual);
            carregarNiveisMaturidade(NivelMaturidade);
        }
        private void qryMetasGenericas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow selectedRow = qryMetasGenericas.Rows[index];
            String SiglaAtual = selectedRow.Cells[0].Value.ToString();
            String NivelCapacidade = selectedRow.Cells[2].Value.ToString();
            carregarNiveisCapacidade(NivelCapacidade);
        }
        
        private void qryNiveisMaturidade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow selectedRow = qryNiveisMaturidade.Rows[index];
            String SiglaAtual = selectedRow.Cells[0].Value.ToString();
        }
        private void qryMetasEspecificas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow selectedRow = qryMetasEspecificas.Rows[index];
            String SiglaAtual = selectedRow.Cells[1].Value.ToString();
            carregarPraticasEspecificas(SiglaAtual);
        }
        private void qryPraticasEspecificas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow selectedRow = qryPraticasEspecificas.Rows[index];
            String SiglaAtual = selectedRow.Cells[0].Value.ToString();
        }


        private void carregarAreas(String modelo) {
            DataSet dadosdataSet = new DataSet();
            PostgreSQL pgSQL = new PostgreSQL();
            String comandoSQL;

            dadosdataSet.Clear();
            pgSQL.abrirConexao();

            comandoSQL = "SELECT nome,sigla,nivelmaturidade FROM areaprocesso WHERE modelo = '" + modelo + "'";

            NpgsqlDataAdapter dados = new Npgsql.NpgsqlDataAdapter(comandoSQL, pgSQL.getConnectionString());

            dados.Fill(dadosdataSet);


            qryAreas.DataSource = dadosdataSet.Tables[0];

            pgSQL.fecharConexao();
        }

        private void carregarMetasGenericas(String modelo)
        {
            DataSet dadosdataSet = new DataSet();
            PostgreSQL pgSQL = new PostgreSQL();
            String comandoSQL;

            dadosdataSet.Clear();
            pgSQL.abrirConexao();

            comandoSQL = "SELECT nome,sigla,nivelcapacidade FROM metagenerica WHERE modelo = '" + modelo + "'";

            NpgsqlDataAdapter dados = new Npgsql.NpgsqlDataAdapter(comandoSQL, pgSQL.getConnectionString());

            dados.Fill(dadosdataSet);


            qryMetasGenericas.DataSource = dadosdataSet.Tables[0];

            pgSQL.fecharConexao();
        }

        private void carregarMetasEspecificas(String modelo)
        {
            DataSet dadosdataSet = new DataSet();
            PostgreSQL pgSQL = new PostgreSQL();
            String comandoSQL;

            dadosdataSet.Clear();
            pgSQL.abrirConexao();

            comandoSQL = "SELECT nome,sigla FROM metaespecifica WHERE areaprocesso = '" + modelo + "'";

            NpgsqlDataAdapter dados = new Npgsql.NpgsqlDataAdapter(comandoSQL, pgSQL.getConnectionString());

            dados.Fill(dadosdataSet);


            qryMetasEspecificas.DataSource = dadosdataSet.Tables[0];

            pgSQL.fecharConexao();
        }

        private void carregarPraticasEspecificas(String metaespecifica)
        {
            DataSet dadosdataSet = new DataSet();
            PostgreSQL pgSQL = new PostgreSQL();
            String comandoSQL;

            dadosdataSet.Clear();
            pgSQL.abrirConexao();

            comandoSQL = "SELECT nome,sigla FROM praticaespecifica WHERE metaespecifica = '" + metaespecifica + "'";

            NpgsqlDataAdapter dados = new Npgsql.NpgsqlDataAdapter(comandoSQL, pgSQL.getConnectionString());

            dados.Fill(dadosdataSet);


            qryPraticasEspecificas.DataSource = dadosdataSet.Tables[0];

            pgSQL.fecharConexao();
        }

        private void carregarNiveisCapacidade(String nivelcapacidade)
        {
            DataSet dadosdataSet = new DataSet();
            PostgreSQL pgSQL = new PostgreSQL();
            String comandoSQL;

            dadosdataSet.Clear();
            pgSQL.abrirConexao();

            comandoSQL = "SELECT nome,sigla FROM nivelcapacidade WHERE sigla = '" + nivelcapacidade + "'";

            NpgsqlDataAdapter dados = new Npgsql.NpgsqlDataAdapter(comandoSQL, pgSQL.getConnectionString());

            dados.Fill(dadosdataSet);


            qryNiveisCapacidade.DataSource = dadosdataSet.Tables[0];

            pgSQL.fecharConexao();
        }

        private void carregarNiveisMaturidade(String nivelmaturidade)
        {
            DataSet dadosdataSet = new DataSet();
            PostgreSQL pgSQL = new PostgreSQL();
            String comandoSQL;

            dadosdataSet.Clear();
            pgSQL.abrirConexao();

            comandoSQL = "SELECT nome,sigla FROM nivelmaturidade WHERE sigla = '" + nivelmaturidade + "'";

            NpgsqlDataAdapter dados = new Npgsql.NpgsqlDataAdapter(comandoSQL, pgSQL.getConnectionString());

            dados.Fill(dadosdataSet);


            qryNiveisMaturidade.DataSource = dadosdataSet.Tables[0];

            pgSQL.fecharConexao();
        }



    }

    
}
