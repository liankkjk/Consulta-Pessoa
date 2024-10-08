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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string vFiltro;

            vFiltro = cmbColuna.Text;

            switch(cmbProcurar.Text)
            {
                case "Que contém":
                    vFiltro += $" like '%{txtValor.Text}%'";
                    break;
                case "Todos":
                    vFiltro = "";
                    break;
            }
            pessoaBindingSource.Filter = vFiltro;
        }
    }
}
