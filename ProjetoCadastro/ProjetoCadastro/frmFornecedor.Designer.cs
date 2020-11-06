namespace ProjetoCadastro
{
    partial class frmFornecedor
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
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.sg_nivelFornecedorTextBox = new System.Windows.Forms.TextBox();
            this.cd_FornecedorTextBox = new System.Windows.Forms.TextBox();
            this.nm_fornecedorTextBox = new System.Windows.Forms.TextBox();
            this.nm_EstadoTextBox = new System.Windows.Forms.TextBox();
            this.rg = new System.Windows.Forms.Label();
            this.tipocliente = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.Label();
            this.ie = new System.Windows.Forms.Label();
            this.cnpj = new System.Windows.Forms.Label();
            this.contato = new System.Windows.Forms.Label();
            this.telefone = new System.Windows.Forms.Label();
            this.cep = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.Label();
            this.cidade = new System.Windows.Forms.Label();
            this.bairro = new System.Windows.Forms.Label();
            this.endereco = new System.Windows.Forms.Label();
            this.nomecliente = new System.Windows.Forms.Label();
            this.codigocliente = new System.Windows.Forms.Label();
            this.tb_FornecedorbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroDataSet = new ProjetoCadastro.cadastroDataSet();
            this.tb_fornecedorTableAdapter = new ProjetoCadastro.cadastroDataSetTableAdapters.Tb_fornecedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tb_FornecedorbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sairbtn
            // 
            this.sairbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sairbtn.Location = new System.Drawing.Point(904, 591);
            this.sairbtn.Name = "sairbtn";
            this.sairbtn.Size = new System.Drawing.Size(95, 43);
            this.sairbtn.TabIndex = 79;
            this.sairbtn.Text = "Sair";
            this.sairbtn.UseVisualStyleBackColor = true;
            this.sairbtn.Click += new System.EventHandler(this.sairbtn_Click);
            // 
            // excluirbtn
            // 
            this.excluirbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirbtn.Location = new System.Drawing.Point(904, 517);
            this.excluirbtn.Name = "excluirbtn";
            this.excluirbtn.Size = new System.Drawing.Size(95, 43);
            this.excluirbtn.TabIndex = 78;
            this.excluirbtn.Text = "Excluir";
            this.excluirbtn.UseVisualStyleBackColor = true;
            this.excluirbtn.Click += new System.EventHandler(this.excluirbtn_Click);
            // 
            // imprimirbtn
            // 
            this.imprimirbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imprimirbtn.Location = new System.Drawing.Point(781, 591);
            this.imprimirbtn.Name = "imprimirbtn";
            this.imprimirbtn.Size = new System.Drawing.Size(95, 43);
            this.imprimirbtn.TabIndex = 77;
            this.imprimirbtn.Text = "Imprimir";
            this.imprimirbtn.UseVisualStyleBackColor = true;
            // 
            // alterarbtn
            // 
            this.alterarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alterarbtn.Location = new System.Drawing.Point(781, 517);
            this.alterarbtn.Name = "alterarbtn";
            this.alterarbtn.Size = new System.Drawing.Size(95, 43);
            this.alterarbtn.TabIndex = 76;
            this.alterarbtn.Text = "Alterar";
            this.alterarbtn.UseVisualStyleBackColor = true;
            this.alterarbtn.Click += new System.EventHandler(this.alterarbtn_Click);
            // 
            // pesquisarbtn
            // 
            this.pesquisarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pesquisarbtn.Location = new System.Drawing.Point(656, 591);
            this.pesquisarbtn.Name = "pesquisarbtn";
            this.pesquisarbtn.Size = new System.Drawing.Size(95, 43);
            this.pesquisarbtn.TabIndex = 75;
            this.pesquisarbtn.Text = "Pesquisar";
            this.pesquisarbtn.UseVisualStyleBackColor = true;
            // 
            // novobtn
            // 
            this.novobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novobtn.Location = new System.Drawing.Point(656, 517);
            this.novobtn.Name = "novobtn";
            this.novobtn.Size = new System.Drawing.Size(95, 43);
            this.novobtn.TabIndex = 74;
            this.novobtn.Text = "Novo";
            this.novobtn.UseVisualStyleBackColor = true;
            this.novobtn.Click += new System.EventHandler(this.novobtn_Click);
            // 
            // cancelarbtn
            // 
            this.cancelarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarbtn.Location = new System.Drawing.Point(532, 591);
            this.cancelarbtn.Name = "cancelarbtn";
            this.cancelarbtn.Size = new System.Drawing.Size(95, 43);
            this.cancelarbtn.TabIndex = 73;
            this.cancelarbtn.Text = "Cancelar";
            this.cancelarbtn.UseVisualStyleBackColor = true;
            this.cancelarbtn.Click += new System.EventHandler(this.cancelarbtn_Click);
            // 
            // proximobtn
            // 
            this.proximobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proximobtn.Location = new System.Drawing.Point(532, 517);
            this.proximobtn.Name = "proximobtn";
            this.proximobtn.Size = new System.Drawing.Size(95, 43);
            this.proximobtn.TabIndex = 72;
            this.proximobtn.Text = "Próximo";
            this.proximobtn.UseVisualStyleBackColor = true;
            this.proximobtn.Click += new System.EventHandler(this.proximobtn_Click);
            // 
            // salvarbtn
            // 
            this.salvarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvarbtn.Location = new System.Drawing.Point(403, 591);
            this.salvarbtn.Name = "salvarbtn";
            this.salvarbtn.Size = new System.Drawing.Size(95, 43);
            this.salvarbtn.TabIndex = 71;
            this.salvarbtn.Text = "Salvar";
            this.salvarbtn.UseVisualStyleBackColor = true;
            this.salvarbtn.Click += new System.EventHandler(this.salvarbtn_Click);
            // 
            // anteriorbtn
            // 
            this.anteriorbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anteriorbtn.Location = new System.Drawing.Point(403, 517);
            this.anteriorbtn.Name = "anteriorbtn";
            this.anteriorbtn.Size = new System.Drawing.Size(95, 43);
            this.anteriorbtn.TabIndex = 70;
            this.anteriorbtn.Text = "anterior";
            this.anteriorbtn.UseVisualStyleBackColor = true;
            this.anteriorbtn.Click += new System.EventHandler(this.anteriorbtn_Click);
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(837, 87);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(189, 20);
            this.textBox15.TabIndex = 69;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(837, 119);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(189, 20);
            this.textBox14.TabIndex = 68;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(837, 152);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(119, 20);
            this.textBox13.TabIndex = 67;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(837, 183);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(123, 20);
            this.textBox12.TabIndex = 66;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(837, 217);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(123, 20);
            this.textBox11.TabIndex = 65;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(837, 250);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(162, 20);
            this.textBox10.TabIndex = 64;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(837, 290);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(189, 20);
            this.textBox9.TabIndex = 63;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(343, 276);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(138, 20);
            this.textBox8.TabIndex = 62;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(343, 310);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(128, 20);
            this.textBox7.TabIndex = 61;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(343, 350);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(286, 20);
            this.textBox6.TabIndex = 60;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(343, 385);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(286, 20);
            this.textBox5.TabIndex = 59;
            // 
            // sg_nivelFornecedorTextBox
            // 
            this.sg_nivelFornecedorTextBox.Location = new System.Drawing.Point(343, 153);
            this.sg_nivelFornecedorTextBox.Name = "sg_nivelFornecedorTextBox";
            this.sg_nivelFornecedorTextBox.Size = new System.Drawing.Size(100, 20);
            this.sg_nivelFornecedorTextBox.TabIndex = 58;
            // 
            // cd_FornecedorTextBox
            // 
            this.cd_FornecedorTextBox.Location = new System.Drawing.Point(343, 115);
            this.cd_FornecedorTextBox.Name = "cd_FornecedorTextBox";
            this.cd_FornecedorTextBox.Size = new System.Drawing.Size(100, 20);
            this.cd_FornecedorTextBox.TabIndex = 57;
            // 
            // nm_fornecedorTextBox
            // 
            this.nm_fornecedorTextBox.Location = new System.Drawing.Point(343, 84);
            this.nm_fornecedorTextBox.Name = "nm_fornecedorTextBox";
            this.nm_fornecedorTextBox.Size = new System.Drawing.Size(245, 20);
            this.nm_fornecedorTextBox.TabIndex = 56;
            this.nm_fornecedorTextBox.TextChanged += new System.EventHandler(this.nm_clienteTextBox_TextChanged);
            // 
            // nm_EstadoTextBox
            // 
            this.nm_EstadoTextBox.Location = new System.Drawing.Point(343, 236);
            this.nm_EstadoTextBox.Name = "nm_EstadoTextBox";
            this.nm_EstadoTextBox.Size = new System.Drawing.Size(79, 20);
            this.nm_EstadoTextBox.TabIndex = 55;
            // 
            // rg
            // 
            this.rg.Location = new System.Drawing.Point(775, 215);
            this.rg.Name = "rg";
            this.rg.Size = new System.Drawing.Size(100, 23);
            this.rg.TabIndex = 54;
            this.rg.Text = "RG";
            this.rg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tipocliente
            // 
            this.tipocliente.Location = new System.Drawing.Point(258, 150);
            this.tipocliente.Name = "tipocliente";
            this.tipocliente.Size = new System.Drawing.Size(100, 23);
            this.tipocliente.TabIndex = 53;
            this.tipocliente.Text = "Tipo Cliente";
            this.tipocliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(775, 248);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 23);
            this.email.TabIndex = 52;
            this.email.Text = "E-Mail";
            this.email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cpf
            // 
            this.cpf.Location = new System.Drawing.Point(775, 183);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(100, 23);
            this.cpf.TabIndex = 51;
            this.cpf.Text = "CPF";
            this.cpf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ie
            // 
            this.ie.Location = new System.Drawing.Point(775, 287);
            this.ie.Name = "ie";
            this.ie.Size = new System.Drawing.Size(100, 23);
            this.ie.TabIndex = 50;
            this.ie.Text = "IE";
            this.ie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cnpj
            // 
            this.cnpj.Location = new System.Drawing.Point(775, 150);
            this.cnpj.Name = "cnpj";
            this.cnpj.Size = new System.Drawing.Size(100, 23);
            this.cnpj.TabIndex = 49;
            this.cnpj.Text = "CNPJ";
            this.cnpj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contato
            // 
            this.contato.Location = new System.Drawing.Point(775, 116);
            this.contato.Name = "contato";
            this.contato.Size = new System.Drawing.Size(100, 23);
            this.contato.TabIndex = 48;
            this.contato.Text = "Contato";
            this.contato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(775, 84);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(100, 23);
            this.telefone.TabIndex = 47;
            this.telefone.Text = "Telefone";
            this.telefone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cep
            // 
            this.cep.Location = new System.Drawing.Point(258, 310);
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(100, 23);
            this.cep.TabIndex = 46;
            this.cep.Text = "CEP";
            this.cep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(258, 234);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(100, 23);
            this.estado.TabIndex = 45;
            this.estado.Text = "Estado";
            this.estado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cidade
            // 
            this.cidade.Location = new System.Drawing.Point(258, 273);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(100, 23);
            this.cidade.TabIndex = 44;
            this.cidade.Text = "Cidade";
            this.cidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bairro
            // 
            this.bairro.Location = new System.Drawing.Point(258, 383);
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(100, 23);
            this.bairro.TabIndex = 43;
            this.bairro.Text = "Bairro";
            this.bairro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // endereco
            // 
            this.endereco.Location = new System.Drawing.Point(258, 347);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(100, 23);
            this.endereco.TabIndex = 42;
            this.endereco.Text = "Endereço";
            this.endereco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nomecliente
            // 
            this.nomecliente.Location = new System.Drawing.Point(237, 81);
            this.nomecliente.Name = "nomecliente";
            this.nomecliente.Size = new System.Drawing.Size(100, 23);
            this.nomecliente.TabIndex = 41;
            this.nomecliente.Text = "Nome Fornecedor";
            this.nomecliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // codigocliente
            // 
            this.codigocliente.Location = new System.Drawing.Point(237, 107);
            this.codigocliente.Name = "codigocliente";
            this.codigocliente.Size = new System.Drawing.Size(100, 34);
            this.codigocliente.TabIndex = 40;
            this.codigocliente.Text = "Código Fornecedor";
            this.codigocliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_FornecedorbindingSource
            // 
            this.tb_FornecedorbindingSource.DataMember = "Tb_fornecedor";
            this.tb_FornecedorbindingSource.DataSource = this.cadastroDataSet;
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "cadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_fornecedorTableAdapter
            // 
            this.tb_fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 716);
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
            this.Controls.Add(this.sg_nivelFornecedorTextBox);
            this.Controls.Add(this.cd_FornecedorTextBox);
            this.Controls.Add(this.nm_fornecedorTextBox);
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
            this.Name = "frmFornecedor";
            this.Text = "frm_Fornecedor";
            this.Load += new System.EventHandler(this.frmFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_FornecedorbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox sg_nivelFornecedorTextBox;
        private System.Windows.Forms.TextBox cd_FornecedorTextBox;
        private System.Windows.Forms.TextBox nm_fornecedorTextBox;
        private System.Windows.Forms.TextBox nm_EstadoTextBox;
        private System.Windows.Forms.Label rg;
        private System.Windows.Forms.Label tipocliente;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.Label ie;
        private System.Windows.Forms.Label cnpj;
        private System.Windows.Forms.Label contato;
        private System.Windows.Forms.Label telefone;
        private System.Windows.Forms.Label cep;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.Label cidade;
        private System.Windows.Forms.Label bairro;
        private System.Windows.Forms.Label endereco;
        public System.Windows.Forms.Label nomecliente;
        private System.Windows.Forms.Label codigocliente;
        private System.Windows.Forms.BindingSource tb_FornecedorbindingSource;
        private cadastroDataSet cadastroDataSet;
        private cadastroDataSetTableAdapters.Tb_fornecedorTableAdapter tb_fornecedorTableAdapter;
    }
}