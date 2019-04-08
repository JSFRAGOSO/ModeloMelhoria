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
    public partial class NivelCapacidadeBrowse : Form
    {
        PostgreSQL pgSQL = new PostgreSQL();
        DataSet dadosdataSet = new DataSet();
        public NivelCapacidadeBrowse()
        {
            InitializeComponent();
            carregarDados();
        }

        private void carregarDados()
        {
            String comandoSQL;

            dadosdataSet.Clear();
            pgSQL.abrirConexao();

            comandoSQL = "SELECT * FROM nivelcapacidade";

            NpgsqlDataAdapter dados = new Npgsql.NpgsqlDataAdapter(comandoSQL, pgSQL.getConnectionString());

            dados.Fill(dadosdataSet);


            GridNiveis.DataSource = dadosdataSet.Tables[0];

            pgSQL.fecharConexao();

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            NivelCapacidadeForm ncf = new NivelCapacidadeForm();

            ncf.ShowDialog();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            carregarDados();
        }
    }
}
