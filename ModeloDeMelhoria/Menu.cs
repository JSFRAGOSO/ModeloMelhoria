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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sairStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nívelDeMaturidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NivelMaturidadeBrowse nmb = new NivelMaturidadeBrowse();

            nmb.ShowDialog();
        }

        private void nívelDeCapacidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NivelCapacidadeBrowse ncb = new NivelCapacidadeBrowse();
            ncb.ShowDialog();
        }

        private void metaGenéricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetaGenericaForm mgf = new MetaGenericaForm();

            mgf.ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriaForm cf = new CategoriaForm();
            cf.ShowDialog();
        }

        private void práticaEspecíficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PraticaEspecificaForm pef = new PraticaEspecificaForm();
            pef.ShowDialog();
        }

        private void proutoDeTrabalhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoTrabalhoForm ptf = new ProdutoTrabalhoForm();
            ptf.ShowDialog();
        }

        private void áreaDeProcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AreaProcessoForm apf = new AreaProcessoForm();

            apf.ShowDialog();
        }

        private void metaEspecíficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetaEspecificaForm mef = new MetaEspecificaForm();
            mef.ShowDialog();
        }

        private void criarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModeloForm mf = new ModeloForm();
            mf.ShowDialog();
        }

        private void gerarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModeloBrowseForm mbf = new ModeloBrowseForm();
            mbf.ShowDialog();
        }
    }
}
