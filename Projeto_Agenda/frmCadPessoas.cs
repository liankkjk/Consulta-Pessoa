using System;
using System.Windows.Forms;

namespace Projeto_Agenda
{
    public partial class frmCadPessoas : Form
    {
        public frmCadPessoas()
        {
            InitializeComponent();
        }

        private void frmCadPessoas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.dataSet_Agenda.Pessoa);
        }

        private void pessoaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_Agenda);

        }

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirmar Exclusão?", "Excluindo registro...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {
                pessoaBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.dataSet_Agenda);
            }
        }
    }
}
