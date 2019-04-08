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
    public partial class NivelMaturidadeForm : Form
    {
        public NivelMaturidadeForm()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            String mensagem = "";
            String ComandoSQL = "INSERT INTO nivelmaturidade(sigla,nome,descricao) " +    
                                "VALUES('"+ txtSigla.Text + "','" + txtNome.Text + "','" + txtDescricao.Text + "');";

            PostgreSQL pgSQL = new PostgreSQL();

            mensagem = pgSQL.ExecutarComandoSQL(ComandoSQL);

            if (mensagem != "")
            {
                MessageBox.Show(mensagem);
            }
            else
            {
                MessageBox.Show("Nível de Maturidade cadastrado com sucesso!");
                txtSigla.Clear();
                txtDescricao.Clear();
                txtNome.Clear();
                txtSigla.Focus();
            }



        }
    }
}
