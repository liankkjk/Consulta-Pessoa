using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Projeto_Agenda
{
    public partial class frmVisualizaListaPessoas : Form
    {
        public frmVisualizaListaPessoas()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_Agenda1 = new Projeto_Agenda.DataSet_Agenda();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaTableAdapter1 = new Projeto_Agenda.DataSet_AgendaTableAdapters.PessoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_Pessoas";
            reportDataSource1.Value = this.bindingSource1;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Projeto_Agenda.RelatorioPessoas.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(916, 550);
            this.reportViewer2.TabIndex = 0;
            // 
            // dataSet_Agenda1
            // 
            this.dataSet_Agenda1.DataSetName = "DataSet_Agenda";
            this.dataSet_Agenda1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Pessoa";
            this.bindingSource1.DataSource = this.dataSet_Agenda1;
            // 
            // pessoaTableAdapter1
            // 
            this.pessoaTableAdapter1.ClearBeforeFill = true;
            // 
            // frmVisualizaListaPessoas
            // 
            this.ClientSize = new System.Drawing.Size(916, 550);
            this.Controls.Add(this.reportViewer2);
            this.Name = "frmVisualizaListaPessoas";
            this.Text = "Visualiza Lista";
            this.Load += new System.EventHandler(this.frmVisualizaListaPessoas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        private void frmVisualizaListaPessoas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda1.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter1.Fill(this.dataSet_Agenda1.Pessoa);
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda1.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter1.Fill(this.dataSet_Agenda1.Pessoa);
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda1.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter1.Fill(this.dataSet_Agenda1.Pessoa);

            this.reportViewer2.RefreshReport();
        }
    }
}
