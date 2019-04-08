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
    public partial class ProdutoTrabalhoForm : Form
    {
        public ProdutoTrabalhoForm()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            String mensagem = "";
            String ComandoSQL = "INSERT INTO produtotrabalho(nome,teamplate) " +
                                "VALUES('" + txtNome.Text + "','" + txtTeamplate.Text + "');";

            PostgreSQL pgSQL = new PostgreSQL();

            mensagem = pgSQL.ExecutarComandoSQL(ComandoSQL);

            if (mensagem != "")
            {
                MessageBox.Show(mensagem);
            }
            else
            {
                MessageBox.Show("Produto de Trabalho cadastrado com sucesso!");

                txtNome.Clear();
                txtTeamplate.Clear();
                txtNome.Focus();

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
