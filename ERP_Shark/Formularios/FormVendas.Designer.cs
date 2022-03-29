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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbValidar = new System.Windows.Forms.CheckBox();
            this.lbValidarCod = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbCodigoReduzido = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 321);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 27);
            this.textBox1.TabIndex = 2;
            // 
            // cbValidar
            // 
            this.cbValidar.AutoSize = true;
            this.cbValidar.Location = new System.Drawing.Point(362, 333);
            this.cbValidar.Name = "cbValidar";
            this.cbValidar.Size = new System.Drawing.Size(15, 14);
            this.cbValidar.TabIndex = 51;
            this.cbValidar.UseVisualStyleBackColor = true;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(248, 327);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(84, 20);
            this.textBox3.TabIndex = 48;
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
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(612, 401);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbValidar);
            this.Controls.Add(this.lbValidarCod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbCodigoReduzido);
            this.Controls.Add(this.textBox1);
            this.Name = "FormVendas";
            this.Load += new System.EventHandler(this.FormVendas_Load);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.lbCodigoReduzido, 0);
            this.Controls.SetChildIndex(this.textBox3, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.lbValidarCod, 0);
            this.Controls.SetChildIndex(this.cbValidar, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox cbValidar;
        private System.Windows.Forms.Label lbValidarCod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbCodigoReduzido;
        private System.Windows.Forms.Panel panel1;
    }
}
