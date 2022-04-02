namespace ERP_Shark
{
    partial class FormCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProduto));
            this.cbValidar = new System.Windows.Forms.CheckBox();
            this.lbValidarCod = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtReduzidoPD = new System.Windows.Forms.TextBox();
            this.lbCodigoReduzido = new System.Windows.Forms.Label();
            this.txtDescriPD = new System.Windows.Forms.TextBox();
            this.txtFornec = new System.Windows.Forms.TextBox();
            this.lbDescricaoPrincipal = new System.Windows.Forms.Label();
            this.lbCodigoGrupo = new System.Windows.Forms.Label();
            this.btnDuplicar = new System.Windows.Forms.Button();
            this.btnAlterarValor = new System.Windows.Forms.Button();
            this.gbValor = new System.Windows.Forms.GroupBox();
            this.txtOperador = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescricaoValor = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.lbDescricaoValor = new System.Windows.Forms.Label();
            this.lbCodigoValor = new System.Windows.Forms.Label();
            this.gpDadosProduto = new System.Windows.Forms.GroupBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.lbEspecie = new System.Windows.Forms.Label();
            this.txtCGrupo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDescrib = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gbValor.SuspendLayout();
            this.gpDadosProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // cbValidar
            // 
            this.cbValidar.AutoSize = true;
            this.cbValidar.Location = new System.Drawing.Point(477, 54);
            this.cbValidar.Name = "cbValidar";
            this.cbValidar.Size = new System.Drawing.Size(15, 14);
            this.cbValidar.TabIndex = 46;
            this.cbValidar.UseVisualStyleBackColor = true;
            // 
            // lbValidarCod
            // 
            this.lbValidarCod.AutoSize = true;
            this.lbValidarCod.Location = new System.Drawing.Point(491, 54);
            this.lbValidarCod.Name = "lbValidarCod";
            this.lbValidarCod.Size = new System.Drawing.Size(116, 13);
            this.lbValidarCod.TabIndex = 45;
            this.lbValidarCod.Text = "&Validar  código produto";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(453, 48);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(20, 21);
            this.button1.TabIndex = 44;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtReduzidoPD
            // 
            this.txtReduzidoPD.Location = new System.Drawing.Point(363, 48);
            this.txtReduzidoPD.Name = "txtReduzidoPD";
            this.txtReduzidoPD.Size = new System.Drawing.Size(84, 20);
            this.txtReduzidoPD.TabIndex = 45;
            // 
            // lbCodigoReduzido
            // 
            this.lbCodigoReduzido.AutoSize = true;
            this.lbCodigoReduzido.Location = new System.Drawing.Point(322, 53);
            this.lbCodigoReduzido.Name = "lbCodigoReduzido";
            this.lbCodigoReduzido.Size = new System.Drawing.Size(40, 13);
            this.lbCodigoReduzido.TabIndex = 42;
            this.lbCodigoReduzido.Text = "Codigo";
            // 
            // txtDescriPD
            // 
            this.txtDescriPD.Location = new System.Drawing.Point(82, 73);
            this.txtDescriPD.Name = "txtDescriPD";
            this.txtDescriPD.Size = new System.Drawing.Size(182, 20);
            this.txtDescriPD.TabIndex = 42;
            // 
            // txtFornec
            // 
            this.txtFornec.Location = new System.Drawing.Point(67, 48);
            this.txtFornec.Name = "txtFornec";
            this.txtFornec.Size = new System.Drawing.Size(73, 20);
            this.txtFornec.TabIndex = 40;
            // 
            // lbDescricaoPrincipal
            // 
            this.lbDescricaoPrincipal.AutoSize = true;
            this.lbDescricaoPrincipal.Location = new System.Drawing.Point(7, 76);
            this.lbDescricaoPrincipal.Name = "lbDescricaoPrincipal";
            this.lbDescricaoPrincipal.Size = new System.Drawing.Size(59, 13);
            this.lbDescricaoPrincipal.TabIndex = 39;
            this.lbDescricaoPrincipal.Text = "Descrição*";
            // 
            // lbCodigoGrupo
            // 
            this.lbCodigoGrupo.AutoSize = true;
            this.lbCodigoGrupo.Location = new System.Drawing.Point(148, 50);
            this.lbCodigoGrupo.Name = "lbCodigoGrupo";
            this.lbCodigoGrupo.Size = new System.Drawing.Size(74, 13);
            this.lbCodigoGrupo.TabIndex = 38;
            this.lbCodigoGrupo.Text = "Codigo grupo*";
            // 
            // btnDuplicar
            // 
            this.btnDuplicar.Location = new System.Drawing.Point(526, 366);
            this.btnDuplicar.Name = "btnDuplicar";
            this.btnDuplicar.Size = new System.Drawing.Size(75, 23);
            this.btnDuplicar.TabIndex = 37;
            this.btnDuplicar.Text = "&Duplicar ";
            this.btnDuplicar.UseVisualStyleBackColor = true;
            // 
            // btnAlterarValor
            // 
            this.btnAlterarValor.Location = new System.Drawing.Point(442, 366);
            this.btnAlterarValor.Name = "btnAlterarValor";
            this.btnAlterarValor.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarValor.TabIndex = 36;
            this.btnAlterarValor.Text = "&Alterar Valor";
            this.btnAlterarValor.UseVisualStyleBackColor = true;
            // 
            // gbValor
            // 
            this.gbValor.Controls.Add(this.txtOperador);
            this.gbValor.Controls.Add(this.txtValor);
            this.gbValor.Controls.Add(this.txtDescricaoValor);
            this.gbValor.Controls.Add(this.txtCodigo);
            this.gbValor.Controls.Add(this.label1);
            this.gbValor.Controls.Add(this.lbValor);
            this.gbValor.Controls.Add(this.lbDescricaoValor);
            this.gbValor.Controls.Add(this.lbCodigoValor);
            this.gbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbValor.Location = new System.Drawing.Point(220, 252);
            this.gbValor.Name = "gbValor";
            this.gbValor.Size = new System.Drawing.Size(388, 75);
            this.gbValor.TabIndex = 35;
            this.gbValor.TabStop = false;
            this.gbValor.Text = "Valor";
            // 
            // txtOperador
            // 
            this.txtOperador.Location = new System.Drawing.Point(198, 34);
            this.txtOperador.Name = "txtOperador";
            this.txtOperador.Size = new System.Drawing.Size(95, 20);
            this.txtOperador.TabIndex = 11;
            this.txtOperador.TextChanged += new System.EventHandler(this.txtOperador_TextChanged);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(133, 34);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(57, 20);
            this.txtValor.TabIndex = 10;
            // 
            // txtDescricaoValor
            // 
            this.txtDescricaoValor.Location = new System.Drawing.Point(57, 34);
            this.txtDescricaoValor.Name = "txtDescricaoValor";
            this.txtDescricaoValor.Size = new System.Drawing.Size(66, 20);
            this.txtDescricaoValor.TabIndex = 9;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(4, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(41, 20);
            this.txtCodigo.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Operador/Atualização";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor.Location = new System.Drawing.Point(140, 18);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(31, 13);
            this.lbValor.TabIndex = 6;
            this.lbValor.Text = "Valor";
            // 
            // lbDescricaoValor
            // 
            this.lbDescricaoValor.AutoSize = true;
            this.lbDescricaoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricaoValor.Location = new System.Drawing.Point(64, 18);
            this.lbDescricaoValor.Name = "lbDescricaoValor";
            this.lbDescricaoValor.Size = new System.Drawing.Size(55, 13);
            this.lbDescricaoValor.TabIndex = 5;
            this.lbDescricaoValor.Text = "Descrição";
            // 
            // lbCodigoValor
            // 
            this.lbCodigoValor.AutoSize = true;
            this.lbCodigoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoValor.Location = new System.Drawing.Point(5, 18);
            this.lbCodigoValor.Name = "lbCodigoValor";
            this.lbCodigoValor.Size = new System.Drawing.Size(40, 13);
            this.lbCodigoValor.TabIndex = 4;
            this.lbCodigoValor.Text = "Codigo";
            // 
            // gpDadosProduto
            // 
            this.gpDadosProduto.Controls.Add(this.txtEspecie);
            this.gpDadosProduto.Controls.Add(this.lbEspecie);
            this.gpDadosProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDadosProduto.Location = new System.Drawing.Point(1, 253);
            this.gpDadosProduto.Name = "gpDadosProduto";
            this.gpDadosProduto.Size = new System.Drawing.Size(175, 60);
            this.gpDadosProduto.TabIndex = 34;
            this.gpDadosProduto.TabStop = false;
            this.gpDadosProduto.Text = "Dados do Produto";
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(57, 12);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(31, 20);
            this.txtEspecie.TabIndex = 43;
            // 
            // lbEspecie
            // 
            this.lbEspecie.AutoSize = true;
            this.lbEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEspecie.Location = new System.Drawing.Point(4, 16);
            this.lbEspecie.Name = "lbEspecie";
            this.lbEspecie.Size = new System.Drawing.Size(49, 13);
            this.lbEspecie.TabIndex = 3;
            this.lbEspecie.Text = "Espécie*";
            // 
            // txtCGrupo
            // 
            this.txtCGrupo.Location = new System.Drawing.Point(224, 47);
            this.txtCGrupo.Name = "txtCGrupo";
            this.txtCGrupo.Size = new System.Drawing.Size(73, 20);
            this.txtCGrupo.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Fornecedor*";
            // 
            // lbDescrib
            // 
            this.lbDescrib.AutoSize = true;
            this.lbDescrib.Location = new System.Drawing.Point(275, 79);
            this.lbDescrib.Name = "lbDescrib";
            this.lbDescrib.Size = new System.Drawing.Size(0, 13);
            this.lbDescrib.TabIndex = 49;
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(273, 77);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(0, 13);
            this.lbDesc.TabIndex = 50;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1, 99);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(607, 147);
            this.dataGridView2.TabIndex = 51;
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(612, 401);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.lbDescrib);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCGrupo);
            this.Controls.Add(this.cbValidar);
            this.Controls.Add(this.lbValidarCod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtReduzidoPD);
            this.Controls.Add(this.lbCodigoReduzido);
            this.Controls.Add(this.txtDescriPD);
            this.Controls.Add(this.txtFornec);
            this.Controls.Add(this.lbDescricaoPrincipal);
            this.Controls.Add(this.lbCodigoGrupo);
            this.Controls.Add(this.btnDuplicar);
            this.Controls.Add(this.btnAlterarValor);
            this.Controls.Add(this.gbValor);
            this.Controls.Add(this.gpDadosProduto);
            this.Name = "FormCadastroProduto";
            this.Text = "PRDFM236 - Cadastro de Produto";
            this.Controls.SetChildIndex(this.gpDadosProduto, 0);
            this.Controls.SetChildIndex(this.gbValor, 0);
            this.Controls.SetChildIndex(this.btnAlterarValor, 0);
            this.Controls.SetChildIndex(this.btnDuplicar, 0);
            this.Controls.SetChildIndex(this.lbCodigoGrupo, 0);
            this.Controls.SetChildIndex(this.lbDescricaoPrincipal, 0);
            this.Controls.SetChildIndex(this.txtFornec, 0);
            this.Controls.SetChildIndex(this.txtDescriPD, 0);
            this.Controls.SetChildIndex(this.lbCodigoReduzido, 0);
            this.Controls.SetChildIndex(this.txtReduzidoPD, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.lbValidarCod, 0);
            this.Controls.SetChildIndex(this.cbValidar, 0);
            this.Controls.SetChildIndex(this.txtCGrupo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lbDescrib, 0);
            this.Controls.SetChildIndex(this.lbDesc, 0);
            this.Controls.SetChildIndex(this.dataGridView2, 0);
            this.gbValor.ResumeLayout(false);
            this.gbValor.PerformLayout();
            this.gpDadosProduto.ResumeLayout(false);
            this.gpDadosProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbValidar;
        private System.Windows.Forms.Label lbValidarCod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtReduzidoPD;
        private System.Windows.Forms.Label lbCodigoReduzido;
        private System.Windows.Forms.TextBox txtDescriPD;
        private System.Windows.Forms.TextBox txtFornec;
        private System.Windows.Forms.Label lbDescricaoPrincipal;
        private System.Windows.Forms.Label lbCodigoGrupo;
        private System.Windows.Forms.Button btnDuplicar;
        private System.Windows.Forms.Button btnAlterarValor;
        private System.Windows.Forms.GroupBox gbValor;
        private System.Windows.Forms.TextBox txtOperador;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDescricaoValor;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label lbDescricaoValor;
        private System.Windows.Forms.Label lbCodigoValor;
        private System.Windows.Forms.GroupBox gpDadosProduto;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.Label lbEspecie;
        private System.Windows.Forms.TextBox txtCGrupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDescrib;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
