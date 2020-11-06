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
    public partial class frmUsuario : Form
    {
        public static int codigo;

        private void Habilita()
        {

            cd_usuarioTextBox.Enabled = false;
            nm_usuarioTextBox.Enabled = true;
            sg_nivelTextBox.Enabled = true;
            nm_loginTextBox.Enabled = true;
            cd_senhaTextBox.Enabled = true;
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

            cd_usuarioTextBox.Enabled = false;
            nm_usuarioTextBox.Enabled = false;
            sg_nivelTextBox.Enabled = false;
            nm_loginTextBox.Enabled = false;
            cd_senhaTextBox.Enabled = false;
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

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tb_usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_usuarioTableAdapter.Fill(this.cadastroDataSet.tb_usuario);

            Desabilita();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.MovePrevious();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Validate();
            tb_usuarioBindingSource.EndEdit();
            tb_usuarioTableAdapter.Update(this.cadastroDataSet.tb_usuario);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void cd_senhaLabel_Click(object sender, EventArgs e)
        {

        }

        private void novobtn_Click(object sender, EventArgs e)
        {
            Habilita();
            tb_usuarioBindingSource.AddNew();
        }

        private void cancelarbtn_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.CancelEdit();
            Desabilita();
        }

        private void proximobtn_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.MoveNext();
        }

        private void excluirbtn_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.RemoveCurrent();
        }

        private void sairbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void alterarbtn_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void pesquisarbtn_Click(object sender, EventArgs e)
        {
            int reg;
            codigo = 0;
            fmrpesquisausuario fpu = new fmrpesquisausuario();
            fpu.ShowDialog();
            if (codigo > 0)
            {
                reg = tb_usuarioBindingSource.Find("cd_usuario", codigo);
                tb_usuarioBindingSource.Position = reg;
            }
        }

        private void imprimirbtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics objImpressao = e.Graphics;
            string strDados;

            strDados = "FICHA DE USUÁRIO"+ (char)10 + (char)10;
            strDados = strDados + "Código: " + cd_usuarioTextBox.Text + (char)10;
            strDados = strDados + "Nome: " + nm_usuarioTextBox.Text + (char)10;
            strDados = strDados + "Nível" + sg_nivelTextBox.Text + (char)10;
            strDados = strDados + "Login: " + nm_loginTextBox.Text + (char)10;

            objImpressao.DrawString(strDados, new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);
            objImpressao.DrawLine(new System.Drawing.Pen(Brushes.Black,1),50,150,700,80);
          //objImpressao.DrawImage(Image.FromFile(@"\exemplo.jpg"), 50, 200, 730, 400);
        }
    }
}
