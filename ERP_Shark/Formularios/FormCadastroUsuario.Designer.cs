namespace ERP_Shark
{
    partial class FormCadastroUsuario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSenhaBox = new System.Windows.Forms.TextBox();
            this.txtLoginBox = new System.Windows.Forms.TextBox();
            this.txtNomeBox = new System.Windows.Forms.TextBox();
            this.txtIdBox = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Usuario});
            this.dataGridView1.Location = new System.Drawing.Point(35, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 102);
            this.dataGridView1.TabIndex = 18;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // txtSenhaBox
            // 
            this.txtSenhaBox.Location = new System.Drawing.Point(60, 182);
            this.txtSenhaBox.Name = "txtSenhaBox";
            this.txtSenhaBox.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaBox.TabIndex = 17;
            // 
            // txtLoginBox
            // 
            this.txtLoginBox.Location = new System.Drawing.Point(60, 148);
            this.txtLoginBox.Name = "txtLoginBox";
            this.txtLoginBox.Size = new System.Drawing.Size(100, 20);
            this.txtLoginBox.TabIndex = 16;
            // 
            // txtNomeBox
            // 
            this.txtNomeBox.Location = new System.Drawing.Point(60, 111);
            this.txtNomeBox.Name = "txtNomeBox";
            this.txtNomeBox.Size = new System.Drawing.Size(136, 20);
            this.txtNomeBox.TabIndex = 15;
            // 
            // txtIdBox
            // 
            this.txtIdBox.Location = new System.Drawing.Point(60, 72);
            this.txtIdBox.Name = "txtIdBox";
            this.txtIdBox.Size = new System.Drawing.Size(100, 20);
            this.txtIdBox.TabIndex = 14;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(19, 187);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(38, 13);
            this.lbSenha.TabIndex = 13;
            this.lbSenha.Text = "Senha";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(19, 150);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(33, 13);
            this.lbLogin.TabIndex = 12;
            this.lbLogin.Text = "Login";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(20, 114);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 11;
            this.lbNome.Text = "Nome";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(32, 76);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(16, 13);
            this.lbId.TabIndex = 10;
            this.lbId.Text = "Id";
            // 
            // FormCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(612, 401);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSenhaBox);
            this.Controls.Add(this.txtLoginBox);
            this.Controls.Add(this.txtNomeBox);
            this.Controls.Add(this.txtIdBox);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbId);
            this.Name = "FormCadastroUsuario";
            this.Text = "Cadastro de Usuarios";
            this.Controls.SetChildIndex(this.lbId, 0);
            this.Controls.SetChildIndex(this.lbNome, 0);
            this.Controls.SetChildIndex(this.lbLogin, 0);
            this.Controls.SetChildIndex(this.lbSenha, 0);
            this.Controls.SetChildIndex(this.txtIdBox, 0);
            this.Controls.SetChildIndex(this.txtNomeBox, 0);
            this.Controls.SetChildIndex(this.txtLoginBox, 0);
            this.Controls.SetChildIndex(this.txtSenhaBox, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.TextBox txtSenhaBox;
        private System.Windows.Forms.TextBox txtLoginBox;
        private System.Windows.Forms.TextBox txtNomeBox;
        private System.Windows.Forms.TextBox txtIdBox;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbId;
    }
}
