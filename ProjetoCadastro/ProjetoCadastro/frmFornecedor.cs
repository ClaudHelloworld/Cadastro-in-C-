using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class frmFornecedor : Form
    {
        public static int codigo;

        private void Habilita()
        {

            salvarbtn.Enabled = true;
            cancelarbtn.Enabled = true;
            anteriorbtn.Enabled = false;
            proximobtn.Enabled = false;
            novobtn.Enabled = false;
            alterarbtn.Enabled = false;
            excluirbtn.Enabled = false;
            pesquisarbtn.Enabled = false;
            imprimirbtn.Enabled = false;
            sairbtn.Enabled = false;
        }

        private void Desabilita()
        {

            salvarbtn.Enabled = false;
            cancelarbtn.Enabled = false;
            anteriorbtn.Enabled = true;
            proximobtn.Enabled = true;
            novobtn.Enabled = true;
            alterarbtn.Enabled = true;
            excluirbtn.Enabled = true;
            pesquisarbtn.Enabled = true;
            imprimirbtn.Enabled = true;
            sairbtn.Enabled = true;

        }
        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.Tb_fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_fornecedorTableAdapter.Fill(this.cadastroDataSet.Tb_fornecedor);

        }

        private void nm_clienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void anteriorbtn_Click(object sender, EventArgs e)
        {
            tb_FornecedorbindingSource.MovePrevious();
        }

        private void proximobtn_Click(object sender, EventArgs e)
        {
            tb_FornecedorbindingSource.MoveNext();
        }

        private void novobtn_Click(object sender, EventArgs e)
        {
            Habilita();
            tb_FornecedorbindingSource.AddNew();
        }

        private void alterarbtn_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void excluirbtn_Click(object sender, EventArgs e)
        {
            tb_FornecedorbindingSource.RemoveCurrent();
        }

        private void salvarbtn_Click(object sender, EventArgs e)
        {
            Validate();
            tb_FornecedorbindingSource.EndEdit();
            tb_fornecedorTableAdapter.Update(this.cadastroDataSet.Tb_fornecedor);
        }

        private void cancelarbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sairbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
