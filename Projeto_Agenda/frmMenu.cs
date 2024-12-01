using System;
using System.Windows.Forms;

namespace Projeto_Agenda
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadPessoas objCadPessoas = new frmCadPessoas();
            objCadPessoas.MdiParent = this;
            objCadPessoas.Show();
        }

        private void pessoasFiltroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaPessoas objConPessoas = new frmConsultaPessoas();
            objConPessoas.MdiParent = this;
            objConPessoas.Show();
        }

        private void relatórioPessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizaListaPessoas objVisualiza = new frmVisualizaListaPessoas();
            objVisualiza.MdiParent = this;
            objVisualiza.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
