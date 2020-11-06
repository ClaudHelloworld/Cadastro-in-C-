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
    public partial class fmrpesquisausuario : Form
    {
        public fmrpesquisausuario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fmrpesquisausuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tb_usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_usuarioTableAdapter.Fill(this.cadastroDataSet.tb_usuario);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tb_usuarioTableAdapter.Fill(this.cadastroDataSet.tb_usuario);
            } else
            {
                this.tb_usuarioTableAdapter.FillByNome(this.cadastroDataSet.tb_usuario, "%" + txtNome.Text + "%");
            }
        }

        private void tb_usuarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_usuarioDataGridView_DoubleClick(object sender, EventArgs e)
        {
            
            frmUsuario.codigo =int.Parse(tb_usuarioDataGridView.CurrentRow.Cells[0].Value.ToString());
             Close();
        }
    }
}
