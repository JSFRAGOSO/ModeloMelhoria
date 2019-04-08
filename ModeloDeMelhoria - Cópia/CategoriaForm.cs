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
    public partial class CategoriaForm : Form
    {
        public CategoriaForm()
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
            String ComandoSQL = "INSERT INTO categoria(nome) " +
                                "VALUES('" + txtNome.Text + "');";

            PostgreSQL pgSQL = new PostgreSQL();

            mensagem = pgSQL.ExecutarComandoSQL(ComandoSQL);

            if (mensagem != "")
            {
                MessageBox.Show(mensagem);
            }
            else
            {
                MessageBox.Show("Categoria cadastrada com sucesso!");

                txtNome.Clear();
                txtNome.Focus();
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void NOME_Click(object sender, EventArgs e)
        {

        }
    }
}
