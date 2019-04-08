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
    public partial class NivelMaturidadeBrowse : Form
    {
        PostgreSQL pgSQL = new PostgreSQL();
        DataSet dadosdataSet = new DataSet();

        public NivelMaturidadeBrowse()
        {
            InitializeComponent();
            carregarDados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NivelMaturidadeForm nmf = new NivelMaturidadeForm();
            nmf.ShowDialog();

        }

        private void carregarDados() {
            String comandoSQL;

            dadosdataSet.Clear();
            pgSQL.abrirConexao();

            comandoSQL = "SELECT * FROM nivelmaturidade";

            NpgsqlDataAdapter dados = new Npgsql.NpgsqlDataAdapter(comandoSQL, pgSQL.getConnectionString());

            dados.Fill(dadosdataSet);

            
            GridNiveis.DataSource = dadosdataSet.Tables[0];

            pgSQL.fecharConexao();

        }

        private void GridNiveis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NivelMaturidadeBrowse_Load(object sender, EventArgs e)
        {

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            carregarDados();
        }
    }
}
