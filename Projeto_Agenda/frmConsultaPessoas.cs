using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Agenda
{
    public partial class frmConsultaPessoas : Form
    {
        public frmConsultaPessoas()
        {
            InitializeComponent();
        }

        private void frmConsultaPessoas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.dataSet_Agenda.Pessoa);

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string vFiltro;

            vFiltro = cmbColuna.Text;

            switch(cmbProcurar.Text)
            {
                case "Que contém":
                    vFiltro += $" like '%{txtValorUm.Text}%'";
                    break;
                case "Todos":
                    vFiltro = "";
                    break;
            }
            pessoaBindingSource.Filter = vFiltro;
        }

        private void cmbProcurar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbColuna.Text)
            {
               // case "Id":

                   // break;
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
