namespace ERP_Shark.Formularios
{
    partial class FormVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendas));
            this.txtBarras = new System.Windows.Forms.TextBox();
            this.cbValidar = new System.Windows.Forms.CheckBox();
            this.lbValidarCod = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRedTrans = new System.Windows.Forms.TextBox();
            this.lbCodigoReduzido = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.lbClienteVendas = new System.Windows.Forms.Label();
            this.lbVendedor = new System.Windows.Forms.Label();
            this.lbOperacao = new System.Windows.Forms.Label();
            this.txtTransacao = new System.Windows.Forms.TextBox();
            this.lbTransacao = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnCancelarTrans = new System.Windows.Forms.Button();
            this.btnConfirmarTrans = new System.Windows.Forms.Button();
            this.cbOperacaoVendas = new System.Windows.Forms.ComboBox();
            this.lbValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtBarras
            // 
            this.txtBarras.Location = new System.Drawing.Point(29, 324);
            this.txtBarras.Multiline = true;
            this.txtBarras.Name = "txtBarras";
            this.txtBarras.Size = new System.Drawing.Size(162, 25);
            this.txtBarras.TabIndex = 2;
            // 
            // cbValidar
            // 
            this.cbValidar.AutoSize = true;
            this.cbValidar.Location = new System.Drawing.Point(362, 333);
            this.cbValidar.Name = "cbValidar";
            this.cbValidar.Size = new System.Drawing.Size(15, 14);
            this.cbValidar.TabIndex = 51;
            this.cbValidar.UseVisualStyleBackColor = true;
            this.cbValidar.CheckedChanged += new System.EventHandler(this.cbValidar_CheckedChanged);
            // 
            // lbValidarCod
            // 
            this.lbValidarCod.AutoSize = true;
            this.lbValidarCod.Location = new System.Drawing.Point(376, 333);
            this.lbValidarCod.Name = "lbValidarCod";
            this.lbValidarCod.Size = new System.Drawing.Size(116, 13);
            this.lbValidarCod.TabIndex = 50;
            this.lbValidarCod.Text = "&Validar  código produto";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(338, 327);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(20, 21);
            this.button1.TabIndex = 49;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtRedTrans
            // 
            this.txtRedTrans.Location = new System.Drawing.Point(248, 327);
            this.txtRedTrans.Name = "txtRedTrans";
            this.txtRedTrans.Size = new System.Drawing.Size(84, 20);
            this.txtRedTrans.TabIndex = 48;
            // 
            // lbCodigoReduzido
            // 
            this.lbCodigoReduzido.AutoSize = true;
            this.lbCodigoReduzido.Location = new System.Drawing.Point(207, 332);
            this.lbCodigoReduzido.Name = "lbCodigoReduzido";
            this.lbCodigoReduzido.Size = new System.Drawing.Size(40, 13);
            this.lbCodigoReduzido.TabIndex = 47;
            this.lbCodigoReduzido.Text = "Codigo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(3, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 149);
            this.panel1.TabIndex = 52;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(71, 47);
            this.txtCliente.Multiline = true;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(54, 21);
            this.txtCliente.TabIndex = 53;
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(71, 74);
            this.txtVendedor.Multiline = true;
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(54, 21);
            this.txtVendedor.TabIndex = 54;
            this.txtVendedor.TextChanged += new System.EventHandler(this.txtVendedor_TextChanged);
            // 
            // lbClienteVendas
            // 
            this.lbClienteVendas.AutoSize = true;
            this.lbClienteVendas.Location = new System.Drawing.Point(26, 50);
            this.lbClienteVendas.Name = "lbClienteVendas";
            this.lbClienteVendas.Size = new System.Drawing.Size(39, 13);
            this.lbClienteVendas.TabIndex = 55;
            this.lbClienteVendas.Text = "Cliente";
            this.lbClienteVendas.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbVendedor
            // 
            this.lbVendedor.AutoSize = true;
            this.lbVendedor.Location = new System.Drawing.Point(12, 77);
            this.lbVendedor.Name = "lbVendedor";
            this.lbVendedor.Size = new System.Drawing.Size(53, 13);
            this.lbVendedor.TabIndex = 56;
            this.lbVendedor.Text = "Vendedor";
            // 
            // lbOperacao
            // 
            this.lbOperacao.AutoSize = true;
            this.lbOperacao.Location = new System.Drawing.Point(12, 104);
            this.lbOperacao.Name = "lbOperacao";
            this.lbOperacao.Size = new System.Drawing.Size(54, 13);
            this.lbOperacao.TabIndex = 58;
            this.lbOperacao.Text = "Operação";
            // 
            // txtTransacao
            // 
            this.txtTransacao.Location = new System.Drawing.Point(500, 74);
            this.txtTransacao.Multiline = true;
            this.txtTransacao.Name = "txtTransacao";
            this.txtTransacao.Size = new System.Drawing.Size(100, 33);
            this.txtTransacao.TabIndex = 59;
            // 
            // lbTransacao
            // 
            this.lbTransacao.AutoSize = true;
            this.lbTransacao.Location = new System.Drawing.Point(438, 84);
            this.lbTransacao.Name = "lbTransacao";
            this.lbTransacao.Size = new System.Drawing.Size(58, 13);
            this.lbTransacao.TabIndex = 60;
            this.lbTransacao.Text = "Transação";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(462, 53);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(30, 13);
            this.lbData.TabIndex = 61;
            this.lbData.Text = "Data";
            this.lbData.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(500, 50);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 62;
            // 
            // btnCancelarTrans
            // 
            this.btnCancelarTrans.Location = new System.Drawing.Point(421, 366);
            this.btnCancelarTrans.Name = "btnCancelarTrans";
            this.btnCancelarTrans.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarTrans.TabIndex = 63;
            this.btnCancelarTrans.Text = "Cancelar";
            this.btnCancelarTrans.UseVisualStyleBackColor = true;
            this.btnCancelarTrans.Click += new System.EventHandler(this.btnCancelarTrans_Click);
            // 
            // btnConfirmarTrans
            // 
            this.btnConfirmarTrans.Location = new System.Drawing.Point(502, 366);
            this.btnConfirmarTrans.Name = "btnConfirmarTrans";
            this.btnConfirmarTrans.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarTrans.TabIndex = 64;
            this.btnConfirmarTrans.Text = "Confirmar";
            this.btnConfirmarTrans.UseVisualStyleBackColor = true;
            // 
            // cbOperacaoVendas
            // 
            this.cbOperacaoVendas.DisplayMember = "Venda";
            this.cbOperacaoVendas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperacaoVendas.FormattingEnabled = true;
            this.cbOperacaoVendas.Items.AddRange(new object[] {
            "001 - Venda Normal",
            "002 - Venda S/NF",
            "003 - Condicional",
            "004 - Devolução de Venda",
            "005 - Bonificação  "});
            this.cbOperacaoVendas.Location = new System.Drawing.Point(72, 101);
            this.cbOperacaoVendas.Name = "cbOperacaoVendas";
            this.cbOperacaoVendas.Size = new System.Drawing.Size(184, 21);
            this.cbOperacaoVendas.TabIndex = 65;
            this.cbOperacaoVendas.SelectedIndexChanged += new System.EventHandler(this.cbOperacaoVendas_SelectedIndexChanged);
            // 
            // lbValue
            // 
            this.lbValue.AutoSize = true;
            this.lbValue.Location = new System.Drawing.Point(271, 104);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(0, 13);
            this.lbValue.TabIndex = 66;
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(612, 401);
            this.Controls.Add(this.lbValue);
            this.Controls.Add(this.cbOperacaoVendas);
            this.Controls.Add(this.btnConfirmarTrans);
            this.Controls.Add(this.btnCancelarTrans);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbTransacao);
            this.Controls.Add(this.txtTransacao);
            this.Controls.Add(this.lbOperacao);
            this.Controls.Add(this.lbVendedor);
            this.Controls.Add(this.lbClienteVendas);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbValidar);
            this.Controls.Add(this.lbValidarCod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRedTrans);
            this.Controls.Add(this.lbCodigoReduzido);
            this.Controls.Add(this.txtBarras);
            this.Name = "FormVendas";
            this.Text = "TRAFM060 - Vendas";
            this.Load += new System.EventHandler(this.FormVendas_Load);
            this.Controls.SetChildIndex(this.txtBarras, 0);
            this.Controls.SetChildIndex(this.lbCodigoReduzido, 0);
            this.Controls.SetChildIndex(this.txtRedTrans, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.lbValidarCod, 0);
            this.Controls.SetChildIndex(this.cbValidar, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.txtCliente, 0);
            this.Controls.SetChildIndex(this.txtVendedor, 0);
            this.Controls.SetChildIndex(this.lbClienteVendas, 0);
            this.Controls.SetChildIndex(this.lbVendedor, 0);
            this.Controls.SetChildIndex(this.lbOperacao, 0);
            this.Controls.SetChildIndex(this.txtTransacao, 0);
            this.Controls.SetChildIndex(this.lbTransacao, 0);
            this.Controls.SetChildIndex(this.lbData, 0);
            this.Controls.SetChildIndex(this.txtData, 0);
            this.Controls.SetChildIndex(this.btnCancelarTrans, 0);
            this.Controls.SetChildIndex(this.btnConfirmarTrans, 0);
            this.Controls.SetChildIndex(this.cbOperacaoVendas, 0);
            this.Controls.SetChildIndex(this.lbValue, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarras;
        private System.Windows.Forms.CheckBox cbValidar;
        private System.Windows.Forms.Label lbValidarCod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRedTrans;
        private System.Windows.Forms.Label lbCodigoReduzido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label lbClienteVendas;
        private System.Windows.Forms.Label lbVendedor;
        private System.Windows.Forms.Label lbOperacao;
        private System.Windows.Forms.TextBox txtTransacao;
        private System.Windows.Forms.Label lbTransacao;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnCancelarTrans;
        private System.Windows.Forms.Button btnConfirmarTrans;
        private System.Windows.Forms.ComboBox cbOperacaoVendas;
        private System.Windows.Forms.Label lbValue;
    }
}
