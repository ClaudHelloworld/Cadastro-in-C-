namespace ProjetoCadastro
{
    partial class frmUsuario
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
            System.Windows.Forms.Label cd_usuarioLabel;
            System.Windows.Forms.Label nm_usuarioLabel;
            System.Windows.Forms.Label sg_nivelLabel;
            System.Windows.Forms.Label nm_loginLabel;
            System.Windows.Forms.Label cd_senhaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.anteriorbtn = new System.Windows.Forms.Button();
            this.salvarbtn = new System.Windows.Forms.Button();
            this.proximobtn = new System.Windows.Forms.Button();
            this.cancelarbtn = new System.Windows.Forms.Button();
            this.novobtn = new System.Windows.Forms.Button();
            this.pesquisarbtn = new System.Windows.Forms.Button();
            this.alterarbtn = new System.Windows.Forms.Button();
            this.imprimirbtn = new System.Windows.Forms.Button();
            this.excluirbtn = new System.Windows.Forms.Button();
            this.sairbtn = new System.Windows.Forms.Button();
            this.cadastroDataSet = new ProjetoCadastro.cadastroDataSet();
            this.tb_usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_usuarioTableAdapter = new ProjetoCadastro.cadastroDataSetTableAdapters.tb_usuarioTableAdapter();
            this.cd_usuarioTextBox = new System.Windows.Forms.TextBox();
            this.nm_usuarioTextBox = new System.Windows.Forms.TextBox();
            this.sg_nivelTextBox = new System.Windows.Forms.TextBox();
            this.nm_loginTextBox = new System.Windows.Forms.TextBox();
            this.cd_senhaTextBox = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            cd_usuarioLabel = new System.Windows.Forms.Label();
            nm_usuarioLabel = new System.Windows.Forms.Label();
            sg_nivelLabel = new System.Windows.Forms.Label();
            nm_loginLabel = new System.Windows.Forms.Label();
            cd_senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_usuarioLabel
            // 
            cd_usuarioLabel.AutoSize = true;
            cd_usuarioLabel.Location = new System.Drawing.Point(228, 73);
            cd_usuarioLabel.Name = "cd_usuarioLabel";
            cd_usuarioLabel.Size = new System.Drawing.Size(40, 13);
            cd_usuarioLabel.TabIndex = 11;
            cd_usuarioLabel.Text = "Código";
            // 
            // nm_usuarioLabel
            // 
            nm_usuarioLabel.AutoSize = true;
            nm_usuarioLabel.Location = new System.Drawing.Point(226, 109);
            nm_usuarioLabel.Name = "nm_usuarioLabel";
            nm_usuarioLabel.Size = new System.Drawing.Size(35, 13);
            nm_usuarioLabel.TabIndex = 13;
            nm_usuarioLabel.Text = "Nome";
            // 
            // sg_nivelLabel
            // 
            sg_nivelLabel.AutoSize = true;
            sg_nivelLabel.Location = new System.Drawing.Point(228, 148);
            sg_nivelLabel.Name = "sg_nivelLabel";
            sg_nivelLabel.Size = new System.Drawing.Size(31, 13);
            sg_nivelLabel.TabIndex = 15;
            sg_nivelLabel.Text = "Nivel";
            // 
            // nm_loginLabel
            // 
            nm_loginLabel.AutoSize = true;
            nm_loginLabel.Location = new System.Drawing.Point(226, 190);
            nm_loginLabel.Name = "nm_loginLabel";
            nm_loginLabel.Size = new System.Drawing.Size(33, 13);
            nm_loginLabel.TabIndex = 17;
            nm_loginLabel.Text = "Login";
            // 
            // cd_senhaLabel
            // 
            cd_senhaLabel.AutoSize = true;
            cd_senhaLabel.Location = new System.Drawing.Point(225, 234);
            cd_senhaLabel.Name = "cd_senhaLabel";
            cd_senhaLabel.Size = new System.Drawing.Size(38, 13);
            cd_senhaLabel.TabIndex = 19;
            cd_senhaLabel.Text = "Senha";
            cd_senhaLabel.Click += new System.EventHandler(this.cd_senhaLabel_Click);
            // 
            // anteriorbtn
            // 
            this.anteriorbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anteriorbtn.Location = new System.Drawing.Point(100, 284);
            this.anteriorbtn.Name = "anteriorbtn";
            this.anteriorbtn.Size = new System.Drawing.Size(95, 43);
            this.anteriorbtn.TabIndex = 0;
            this.anteriorbtn.Text = "anterior";
            this.anteriorbtn.UseVisualStyleBackColor = true;
            this.anteriorbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // salvarbtn
            // 
            this.salvarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvarbtn.Location = new System.Drawing.Point(100, 358);
            this.salvarbtn.Name = "salvarbtn";
            this.salvarbtn.Size = new System.Drawing.Size(95, 43);
            this.salvarbtn.TabIndex = 1;
            this.salvarbtn.Text = "Salvar";
            this.salvarbtn.UseVisualStyleBackColor = true;
            this.salvarbtn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // proximobtn
            // 
            this.proximobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proximobtn.Location = new System.Drawing.Point(229, 284);
            this.proximobtn.Name = "proximobtn";
            this.proximobtn.Size = new System.Drawing.Size(95, 43);
            this.proximobtn.TabIndex = 2;
            this.proximobtn.Text = "Próximo";
            this.proximobtn.UseVisualStyleBackColor = true;
            this.proximobtn.Click += new System.EventHandler(this.proximobtn_Click);
            // 
            // cancelarbtn
            // 
            this.cancelarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarbtn.Location = new System.Drawing.Point(229, 358);
            this.cancelarbtn.Name = "cancelarbtn";
            this.cancelarbtn.Size = new System.Drawing.Size(95, 43);
            this.cancelarbtn.TabIndex = 3;
            this.cancelarbtn.Text = "Cancelar";
            this.cancelarbtn.UseVisualStyleBackColor = true;
            this.cancelarbtn.Click += new System.EventHandler(this.cancelarbtn_Click);
            // 
            // novobtn
            // 
            this.novobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novobtn.Location = new System.Drawing.Point(353, 284);
            this.novobtn.Name = "novobtn";
            this.novobtn.Size = new System.Drawing.Size(95, 43);
            this.novobtn.TabIndex = 4;
            this.novobtn.Text = "Novo";
            this.novobtn.UseVisualStyleBackColor = true;
            this.novobtn.Click += new System.EventHandler(this.novobtn_Click);
            // 
            // pesquisarbtn
            // 
            this.pesquisarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pesquisarbtn.Location = new System.Drawing.Point(353, 358);
            this.pesquisarbtn.Name = "pesquisarbtn";
            this.pesquisarbtn.Size = new System.Drawing.Size(95, 43);
            this.pesquisarbtn.TabIndex = 5;
            this.pesquisarbtn.Text = "Pesquisar";
            this.pesquisarbtn.UseVisualStyleBackColor = true;
            this.pesquisarbtn.Click += new System.EventHandler(this.pesquisarbtn_Click);
            // 
            // alterarbtn
            // 
            this.alterarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alterarbtn.Location = new System.Drawing.Point(478, 284);
            this.alterarbtn.Name = "alterarbtn";
            this.alterarbtn.Size = new System.Drawing.Size(95, 43);
            this.alterarbtn.TabIndex = 6;
            this.alterarbtn.Text = "Alterar";
            this.alterarbtn.UseVisualStyleBackColor = true;
            this.alterarbtn.Click += new System.EventHandler(this.alterarbtn_Click);
            // 
            // imprimirbtn
            // 
            this.imprimirbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imprimirbtn.Location = new System.Drawing.Point(478, 358);
            this.imprimirbtn.Name = "imprimirbtn";
            this.imprimirbtn.Size = new System.Drawing.Size(95, 43);
            this.imprimirbtn.TabIndex = 7;
            this.imprimirbtn.Text = "Imprimir";
            this.imprimirbtn.UseVisualStyleBackColor = true;
            this.imprimirbtn.Click += new System.EventHandler(this.imprimirbtn_Click);
            // 
            // excluirbtn
            // 
            this.excluirbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirbtn.Location = new System.Drawing.Point(601, 284);
            this.excluirbtn.Name = "excluirbtn";
            this.excluirbtn.Size = new System.Drawing.Size(95, 43);
            this.excluirbtn.TabIndex = 8;
            this.excluirbtn.Text = "Excluir";
            this.excluirbtn.UseVisualStyleBackColor = true;
            this.excluirbtn.Click += new System.EventHandler(this.excluirbtn_Click);
            // 
            // sairbtn
            // 
            this.sairbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sairbtn.Location = new System.Drawing.Point(601, 358);
            this.sairbtn.Name = "sairbtn";
            this.sairbtn.Size = new System.Drawing.Size(95, 43);
            this.sairbtn.TabIndex = 9;
            this.sairbtn.Text = "Sair";
            this.sairbtn.UseVisualStyleBackColor = true;
            this.sairbtn.Click += new System.EventHandler(this.sairbtn_Click);
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "cadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_usuarioBindingSource
            // 
            this.tb_usuarioBindingSource.DataMember = "tb_usuario";
            this.tb_usuarioBindingSource.DataSource = this.cadastroDataSet;
            // 
            // tb_usuarioTableAdapter
            // 
            this.tb_usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // cd_usuarioTextBox
            // 
            this.cd_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "cd_usuario", true));
            this.cd_usuarioTextBox.Location = new System.Drawing.Point(274, 70);
            this.cd_usuarioTextBox.Name = "cd_usuarioTextBox";
            this.cd_usuarioTextBox.Size = new System.Drawing.Size(145, 20);
            this.cd_usuarioTextBox.TabIndex = 12;
            // 
            // nm_usuarioTextBox
            // 
            this.nm_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "nm_usuario", true));
            this.nm_usuarioTextBox.Location = new System.Drawing.Point(274, 109);
            this.nm_usuarioTextBox.MaxLength = 50;
            this.nm_usuarioTextBox.Name = "nm_usuarioTextBox";
            this.nm_usuarioTextBox.Size = new System.Drawing.Size(307, 20);
            this.nm_usuarioTextBox.TabIndex = 14;
            // 
            // sg_nivelTextBox
            // 
            this.sg_nivelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "sg_nivel", true));
            this.sg_nivelTextBox.Location = new System.Drawing.Point(272, 145);
            this.sg_nivelTextBox.MaxLength = 1;
            this.sg_nivelTextBox.Name = "sg_nivelTextBox";
            this.sg_nivelTextBox.Size = new System.Drawing.Size(32, 20);
            this.sg_nivelTextBox.TabIndex = 16;
            // 
            // nm_loginTextBox
            // 
            this.nm_loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "nm_login", true));
            this.nm_loginTextBox.Location = new System.Drawing.Point(272, 187);
            this.nm_loginTextBox.Name = "nm_loginTextBox";
            this.nm_loginTextBox.Size = new System.Drawing.Size(116, 20);
            this.nm_loginTextBox.TabIndex = 18;
            // 
            // cd_senhaTextBox
            // 
            this.cd_senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "cd_senha", true));
            this.cd_senhaTextBox.Location = new System.Drawing.Point(272, 231);
            this.cd_senhaTextBox.Name = "cd_senhaTextBox";
            this.cd_senhaTextBox.Size = new System.Drawing.Size(145, 20);
            this.cd_senhaTextBox.TabIndex = 20;
            this.cd_senhaTextBox.UseSystemPasswordChar = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 432);
            this.Controls.Add(cd_usuarioLabel);
            this.Controls.Add(this.cd_usuarioTextBox);
            this.Controls.Add(nm_usuarioLabel);
            this.Controls.Add(this.nm_usuarioTextBox);
            this.Controls.Add(sg_nivelLabel);
            this.Controls.Add(this.sg_nivelTextBox);
            this.Controls.Add(nm_loginLabel);
            this.Controls.Add(this.nm_loginTextBox);
            this.Controls.Add(cd_senhaLabel);
            this.Controls.Add(this.cd_senhaTextBox);
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
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button anteriorbtn;
        private System.Windows.Forms.Button salvarbtn;
        private System.Windows.Forms.Button proximobtn;
        private System.Windows.Forms.Button cancelarbtn;
        private System.Windows.Forms.Button novobtn;
        private System.Windows.Forms.Button pesquisarbtn;
        private System.Windows.Forms.Button alterarbtn;
        private System.Windows.Forms.Button imprimirbtn;
        private System.Windows.Forms.Button excluirbtn;
        private System.Windows.Forms.Button sairbtn;
        private cadastroDataSet cadastroDataSet;
        private System.Windows.Forms.BindingSource tb_usuarioBindingSource;
        private cadastroDataSetTableAdapters.tb_usuarioTableAdapter tb_usuarioTableAdapter;
        private System.Windows.Forms.TextBox cd_usuarioTextBox;
        private System.Windows.Forms.TextBox nm_usuarioTextBox;
        private System.Windows.Forms.TextBox sg_nivelTextBox;
        private System.Windows.Forms.TextBox nm_loginTextBox;
        private System.Windows.Forms.TextBox cd_senhaTextBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}