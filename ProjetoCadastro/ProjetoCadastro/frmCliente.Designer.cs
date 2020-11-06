namespace ProjetoCadastro
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.codigocliente = new System.Windows.Forms.Label();
            this.nomecliente = new System.Windows.Forms.Label();
            this.endereco = new System.Windows.Forms.Label();
            this.bairro = new System.Windows.Forms.Label();
            this.cidade = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.Label();
            this.cep = new System.Windows.Forms.Label();
            this.telefone = new System.Windows.Forms.Label();
            this.contato = new System.Windows.Forms.Label();
            this.cnpj = new System.Windows.Forms.Label();
            this.ie = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.tipocliente = new System.Windows.Forms.Label();
            this.rg = new System.Windows.Forms.Label();
            this.nm_EstadoTextBox = new System.Windows.Forms.TextBox();
            this.nm_clienteTextBox = new System.Windows.Forms.TextBox();
            this.cd_clienteTextBox = new System.Windows.Forms.TextBox();
            this.sg_nivelTextBox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.sairbtn = new System.Windows.Forms.Button();
            this.excluirbtn = new System.Windows.Forms.Button();
            this.imprimirbtn = new System.Windows.Forms.Button();
            this.alterarbtn = new System.Windows.Forms.Button();
            this.pesquisarbtn = new System.Windows.Forms.Button();
            this.novobtn = new System.Windows.Forms.Button();
            this.cancelarbtn = new System.Windows.Forms.Button();
            this.proximobtn = new System.Windows.Forms.Button();
            this.salvarbtn = new System.Windows.Forms.Button();
            this.anteriorbtn = new System.Windows.Forms.Button();
            this.tb_ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroDataSet = new ProjetoCadastro.cadastroDataSet();
            this.tb_ClienteTableAdapter = new ProjetoCadastro.cadastroDataSetTableAdapters.Tb_ClienteTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // codigocliente
            // 
            this.codigocliente.Location = new System.Drawing.Point(99, 116);
            this.codigocliente.Name = "codigocliente";
            this.codigocliente.Size = new System.Drawing.Size(78, 34);
            this.codigocliente.TabIndex = 0;
            this.codigocliente.Text = "Código Cliente";
            this.codigocliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nomecliente
            // 
            this.nomecliente.Location = new System.Drawing.Point(99, 93);
            this.nomecliente.Name = "nomecliente";
            this.nomecliente.Size = new System.Drawing.Size(100, 23);
            this.nomecliente.TabIndex = 1;
            this.nomecliente.Text = "Nome Cliente";
            this.nomecliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nomecliente.Click += new System.EventHandler(this.label2_Click);
            // 
            // endereco
            // 
            this.endereco.Location = new System.Drawing.Point(99, 356);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(100, 23);
            this.endereco.TabIndex = 2;
            this.endereco.Text = "Endereço";
            this.endereco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bairro
            // 
            this.bairro.Location = new System.Drawing.Point(99, 392);
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(100, 23);
            this.bairro.TabIndex = 3;
            this.bairro.Text = "Bairro";
            this.bairro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cidade
            // 
            this.cidade.Location = new System.Drawing.Point(99, 282);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(100, 23);
            this.cidade.TabIndex = 4;
            this.cidade.Text = "Cidade";
            this.cidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(99, 243);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(100, 23);
            this.estado.TabIndex = 5;
            this.estado.Text = "Estado";
            this.estado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cep
            // 
            this.cep.Location = new System.Drawing.Point(99, 319);
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(100, 23);
            this.cep.TabIndex = 6;
            this.cep.Text = "CEP";
            this.cep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(616, 93);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(100, 23);
            this.telefone.TabIndex = 7;
            this.telefone.Text = "Telefone";
            this.telefone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contato
            // 
            this.contato.Location = new System.Drawing.Point(616, 125);
            this.contato.Name = "contato";
            this.contato.Size = new System.Drawing.Size(100, 23);
            this.contato.TabIndex = 8;
            this.contato.Text = "Contato";
            this.contato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cnpj
            // 
            this.cnpj.Location = new System.Drawing.Point(616, 159);
            this.cnpj.Name = "cnpj";
            this.cnpj.Size = new System.Drawing.Size(100, 23);
            this.cnpj.TabIndex = 9;
            this.cnpj.Text = "CNPJ";
            this.cnpj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ie
            // 
            this.ie.Location = new System.Drawing.Point(616, 296);
            this.ie.Name = "ie";
            this.ie.Size = new System.Drawing.Size(100, 23);
            this.ie.TabIndex = 10;
            this.ie.Text = "IE";
            this.ie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cpf
            // 
            this.cpf.Location = new System.Drawing.Point(616, 192);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(100, 23);
            this.cpf.TabIndex = 11;
            this.cpf.Text = "CPF";
            this.cpf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(616, 257);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 23);
            this.email.TabIndex = 12;
            this.email.Text = "E-Mail";
            this.email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tipocliente
            // 
            this.tipocliente.Location = new System.Drawing.Point(99, 159);
            this.tipocliente.Name = "tipocliente";
            this.tipocliente.Size = new System.Drawing.Size(100, 23);
            this.tipocliente.TabIndex = 13;
            this.tipocliente.Text = "Tipo Cliente";
            this.tipocliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tipocliente.Click += new System.EventHandler(this.label14_Click);
            // 
            // rg
            // 
            this.rg.Location = new System.Drawing.Point(616, 224);
            this.rg.Name = "rg";
            this.rg.Size = new System.Drawing.Size(100, 23);
            this.rg.TabIndex = 14;
            this.rg.Text = "RG";
            this.rg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nm_EstadoTextBox
            // 
            this.nm_EstadoTextBox.Location = new System.Drawing.Point(184, 245);
            this.nm_EstadoTextBox.Name = "nm_EstadoTextBox";
            this.nm_EstadoTextBox.Size = new System.Drawing.Size(79, 20);
            this.nm_EstadoTextBox.TabIndex = 15;
            // 
            // nm_clienteTextBox
            // 
            this.nm_clienteTextBox.Location = new System.Drawing.Point(184, 93);
            this.nm_clienteTextBox.Name = "nm_clienteTextBox";
            this.nm_clienteTextBox.Size = new System.Drawing.Size(245, 20);
            this.nm_clienteTextBox.TabIndex = 16;
            // 
            // cd_clienteTextBox
            // 
            this.cd_clienteTextBox.Location = new System.Drawing.Point(184, 124);
            this.cd_clienteTextBox.Name = "cd_clienteTextBox";
            this.cd_clienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.cd_clienteTextBox.TabIndex = 17;
            // 
            // sg_nivelTextBox
            // 
            this.sg_nivelTextBox.Location = new System.Drawing.Point(184, 162);
            this.sg_nivelTextBox.Name = "sg_nivelTextBox";
            this.sg_nivelTextBox.Size = new System.Drawing.Size(100, 20);
            this.sg_nivelTextBox.TabIndex = 18;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(184, 394);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(286, 20);
            this.textBox5.TabIndex = 19;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(184, 359);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(286, 20);
            this.textBox6.TabIndex = 20;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(184, 319);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(128, 20);
            this.textBox7.TabIndex = 21;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(184, 285);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(138, 20);
            this.textBox8.TabIndex = 22;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(678, 299);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(189, 20);
            this.textBox9.TabIndex = 23;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(678, 259);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(162, 20);
            this.textBox10.TabIndex = 24;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(678, 226);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(123, 20);
            this.textBox11.TabIndex = 25;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(678, 192);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(123, 20);
            this.textBox12.TabIndex = 26;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(678, 161);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(119, 20);
            this.textBox13.TabIndex = 27;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(678, 128);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(189, 20);
            this.textBox14.TabIndex = 28;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(678, 96);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(189, 20);
            this.textBox15.TabIndex = 29;
            // 
            // sairbtn
            // 
            this.sairbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sairbtn.Location = new System.Drawing.Point(882, 599);
            this.sairbtn.Name = "sairbtn";
            this.sairbtn.Size = new System.Drawing.Size(95, 43);
            this.sairbtn.TabIndex = 39;
            this.sairbtn.Text = "Sair";
            this.sairbtn.UseVisualStyleBackColor = true;
            this.sairbtn.Click += new System.EventHandler(this.sairbtn_Click);
            // 
            // excluirbtn
            // 
            this.excluirbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirbtn.Location = new System.Drawing.Point(882, 525);
            this.excluirbtn.Name = "excluirbtn";
            this.excluirbtn.Size = new System.Drawing.Size(95, 43);
            this.excluirbtn.TabIndex = 38;
            this.excluirbtn.Text = "Excluir";
            this.excluirbtn.UseVisualStyleBackColor = true;
            this.excluirbtn.Click += new System.EventHandler(this.excluirbtn_Click);
            // 
            // imprimirbtn
            // 
            this.imprimirbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imprimirbtn.Location = new System.Drawing.Point(759, 599);
            this.imprimirbtn.Name = "imprimirbtn";
            this.imprimirbtn.Size = new System.Drawing.Size(95, 43);
            this.imprimirbtn.TabIndex = 37;
            this.imprimirbtn.Text = "Imprimir";
            this.imprimirbtn.UseVisualStyleBackColor = true;
            this.imprimirbtn.Click += new System.EventHandler(this.imprimirbtn_Click_1);
            // 
            // alterarbtn
            // 
            this.alterarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alterarbtn.Location = new System.Drawing.Point(759, 525);
            this.alterarbtn.Name = "alterarbtn";
            this.alterarbtn.Size = new System.Drawing.Size(95, 43);
            this.alterarbtn.TabIndex = 36;
            this.alterarbtn.Text = "Alterar";
            this.alterarbtn.UseVisualStyleBackColor = true;
            this.alterarbtn.Click += new System.EventHandler(this.alterarbtn_Click);
            // 
            // pesquisarbtn
            // 
            this.pesquisarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pesquisarbtn.Location = new System.Drawing.Point(634, 599);
            this.pesquisarbtn.Name = "pesquisarbtn";
            this.pesquisarbtn.Size = new System.Drawing.Size(95, 43);
            this.pesquisarbtn.TabIndex = 35;
            this.pesquisarbtn.Text = "Pesquisar";
            this.pesquisarbtn.UseVisualStyleBackColor = true;
            this.pesquisarbtn.Click += new System.EventHandler(this.pesquisarbtn_Click);
            // 
            // novobtn
            // 
            this.novobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novobtn.Location = new System.Drawing.Point(634, 525);
            this.novobtn.Name = "novobtn";
            this.novobtn.Size = new System.Drawing.Size(95, 43);
            this.novobtn.TabIndex = 34;
            this.novobtn.Text = "Novo";
            this.novobtn.UseVisualStyleBackColor = true;
            this.novobtn.Click += new System.EventHandler(this.novobtn_Click);
            // 
            // cancelarbtn
            // 
            this.cancelarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarbtn.Location = new System.Drawing.Point(510, 599);
            this.cancelarbtn.Name = "cancelarbtn";
            this.cancelarbtn.Size = new System.Drawing.Size(95, 43);
            this.cancelarbtn.TabIndex = 33;
            this.cancelarbtn.Text = "Cancelar";
            this.cancelarbtn.UseVisualStyleBackColor = true;
            this.cancelarbtn.Click += new System.EventHandler(this.cancelarbtn_Click);
            // 
            // proximobtn
            // 
            this.proximobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proximobtn.Location = new System.Drawing.Point(510, 525);
            this.proximobtn.Name = "proximobtn";
            this.proximobtn.Size = new System.Drawing.Size(95, 43);
            this.proximobtn.TabIndex = 32;
            this.proximobtn.Text = "Próximo";
            this.proximobtn.UseVisualStyleBackColor = true;
            this.proximobtn.Click += new System.EventHandler(this.proximobtn_Click);
            // 
            // salvarbtn
            // 
            this.salvarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvarbtn.Location = new System.Drawing.Point(381, 599);
            this.salvarbtn.Name = "salvarbtn";
            this.salvarbtn.Size = new System.Drawing.Size(95, 43);
            this.salvarbtn.TabIndex = 31;
            this.salvarbtn.Text = "Salvar";
            this.salvarbtn.UseVisualStyleBackColor = true;
            this.salvarbtn.Click += new System.EventHandler(this.salvarbtn_Click);
            // 
            // anteriorbtn
            // 
            this.anteriorbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anteriorbtn.Location = new System.Drawing.Point(381, 525);
            this.anteriorbtn.Name = "anteriorbtn";
            this.anteriorbtn.Size = new System.Drawing.Size(95, 43);
            this.anteriorbtn.TabIndex = 30;
            this.anteriorbtn.Text = "anterior";
            this.anteriorbtn.UseVisualStyleBackColor = true;
            this.anteriorbtn.Click += new System.EventHandler(this.anteriorbtn_Click);
            // 
            // tb_ClienteBindingSource
            // 
            this.tb_ClienteBindingSource.DataMember = "Tb_Cliente";
            this.tb_ClienteBindingSource.DataSource = this.cadastroDataSet;
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "cadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_ClienteTableAdapter
            // 
            this.tb_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 676);
            this.Controls.Add(this.sairbtn);
            this.Controls.Add(this.excluirbtn);
            this.Controls.Add(this.imprimirbtn);
            this.Controls.Add(this.alterarbtn);
            this.Controls.Add(this.pesquisarbtn);
            this.Controls.Add(this.novobtn);
            this.Controls.Add(this.cancelarbtn);
            this.Controls.Add(this.proximobtn);
            this.Controls.Add(this.salvarbtn);
            this.Controls.Add(this.anteriorbtn);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.sg_nivelTextBox);
            this.Controls.Add(this.cd_clienteTextBox);
            this.Controls.Add(this.nm_clienteTextBox);
            this.Controls.Add(this.nm_EstadoTextBox);
            this.Controls.Add(this.rg);
            this.Controls.Add(this.tipocliente);
            this.Controls.Add(this.email);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.ie);
            this.Controls.Add(this.cnpj);
            this.Controls.Add(this.contato);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.cep);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.bairro);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.nomecliente);
            this.Controls.Add(this.codigocliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codigocliente;
        private System.Windows.Forms.Label endereco;
        private System.Windows.Forms.Label bairro;
        private System.Windows.Forms.Label cidade;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.Label cep;
        private System.Windows.Forms.Label telefone;
        private System.Windows.Forms.Label contato;
        private System.Windows.Forms.Label cnpj;
        private System.Windows.Forms.Label ie;
        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label tipocliente;
        public System.Windows.Forms.Label nomecliente;
        private System.Windows.Forms.Label rg;
        private System.Windows.Forms.TextBox nm_EstadoTextBox;
        private System.Windows.Forms.TextBox nm_clienteTextBox;
        private System.Windows.Forms.TextBox cd_clienteTextBox;
        private System.Windows.Forms.TextBox sg_nivelTextBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Button sairbtn;
        private System.Windows.Forms.Button excluirbtn;
        private System.Windows.Forms.Button imprimirbtn;
        private System.Windows.Forms.Button alterarbtn;
        private System.Windows.Forms.Button pesquisarbtn;
        private System.Windows.Forms.Button novobtn;
        private System.Windows.Forms.Button cancelarbtn;
        private System.Windows.Forms.Button proximobtn;
        private System.Windows.Forms.Button salvarbtn;
        private System.Windows.Forms.Button anteriorbtn;
        private System.Windows.Forms.BindingSource tb_ClienteBindingSource;
        private cadastroDataSet cadastroDataSet;
        private cadastroDataSetTableAdapters.Tb_ClienteTableAdapter tb_ClienteTableAdapter;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}