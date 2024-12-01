using System;
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
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.dataSet_Agenda.Pessoa);
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.dataSet_Agenda.Pessoa);

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string coluna = cmbColuna.SelectedItem?.ToString(); 
            string procurar = cmbProcurar.SelectedItem?.ToString(); 
            string textoFiltro = txtValor.Text;

            string filtro = "";
            
            switch (procurar)
            {
                case "Igual a":
                    filtro = $"{coluna} = '{textoFiltro}'";
                    break;
                case "Que Começa com":
                    filtro = $"{coluna} LIKE '{textoFiltro}%'";
                    break;
                case "Que contém":
                    filtro = $"{coluna} LIKE '%{textoFiltro}%'";
                    break;
                case "Que termina com":
                    filtro = $"{coluna} LIKE '%{textoFiltro}'";
                    break;
                case "Todos":
                    filtro = "";
                    break;
                default:
                    MessageBox.Show("Critério de procura inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            try
            {
                pessoaBindingSource.Filter = filtro;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao aplicar o filtro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //pessoaBindingSource.Filter = "Nome like '%" + txtValor.Text + "%'"; 
        }

        private void cmbProcurar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
