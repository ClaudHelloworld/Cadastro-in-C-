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
    public partial class frmCliente : Form
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

        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.Tb_Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_ClienteTableAdapter.Fill(this.cadastroDataSet.Tb_Cliente);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void novobtn_Click(object sender, EventArgs e)
        {
            Habilita();
            tb_ClienteBindingSource.AddNew();
        }

        private void sairbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void imprimirbtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics objImpressao = e.Graphics;
            string strDados;

            strDados = "FICHA DE USUÁRIO" + (char)10 + (char)10;
            strDados = strDados + "Código: " + nm_clienteTextBox.Text + (char)10;
            strDados = strDados + "Nome: " + nm_clienteTextBox.Text + (char)10;
            strDados = strDados + "Nível" + sg_nivelTextBox.Text + (char)10;
            strDados = strDados + "Login: " + nm_EstadoTextBox.Text + (char)10;

            objImpressao.DrawString(strDados, new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);
            objImpressao.DrawLine(new System.Drawing.Pen(Brushes.Black, 1), 50, 150, 700, 80);
            //objImpressao.DrawImage(Image.FromFile(@"\exemplo.jpg"), 50, 200, 730, 400);
        }

        private void proximobtn_Click(object sender, EventArgs e)
        {
            tb_ClienteBindingSource.MoveNext();
        }

        private void anteriorbtn_Click(object sender, EventArgs e)
        {
            tb_ClienteBindingSource.MovePrevious();
        }

        private void cancelarbtn_Click(object sender, EventArgs e)
        {
            tb_ClienteBindingSource.CancelEdit();
            Desabilita();
        }

        private void alterarbtn_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void excluirbtn_Click(object sender, EventArgs e)
        {
            tb_ClienteBindingSource.RemoveCurrent();
        }

        private void salvarbtn_Click(object sender, EventArgs e)
        {
            Validate();
            tb_ClienteBindingSource.EndEdit();
            tb_ClienteTableAdapter.Update(this.cadastroDataSet.Tb_Cliente);
        }

        private void pesquisarbtn_Click(object sender, EventArgs e)
        {
            //int reg;
            //codigo = 0;
            //fmrpesquisaCliente fpu = new fmrpesquisausuario();
            //fpu.ShowDialog();
            //if (codigo > 0)
           // {
            //    reg = tb_ClienteBindingSource.Find("cd_Cliente", codigo);
             //   tb_ClienteBindingSource.Position = reg;
           // }
        }

        private void imprimirbtn_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
