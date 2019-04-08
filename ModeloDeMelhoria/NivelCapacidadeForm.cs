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
    public partial class NivelCapacidadeForm : Form
    {
        public NivelCapacidadeForm()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            String mensagem = "";
            String ComandoSQL = "INSERT INTO nivelcapacidade(sigla,nome,descricao) " +
                                "VALUES('" + txtSigla.Text + "','" + txtNome.Text + "','" + txtDescricao.Text + "');";

            PostgreSQL pgSQL = new PostgreSQL();

            mensagem = pgSQL.ExecutarComandoSQL(ComandoSQL);

            if (mensagem != "")
            {
                MessageBox.Show(mensagem);
            }
            else
            {
                MessageBox.Show("Nível de Capacidade cadastrado com sucesso!");
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

        private void descricao_Click(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void NOME_Click(object sender, EventArgs e)
        {

        }

        private void txtSigla_TextChanged(object sender, EventArgs e)
        {

        }

        private void sigla_Click(object sender, EventArgs e)
        {

        }
    }
}
