namespace ERP_Shark.Formularios
{
    partial class Executar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Executar));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnConfirmarExe = new System.Windows.Forms.Button();
            this.btnCancelarExe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnConfirmarExe
            // 
            this.btnConfirmarExe.Location = new System.Drawing.Point(103, 56);
            this.btnConfirmarExe.Name = "btnConfirmarExe";
            this.btnConfirmarExe.Size = new System.Drawing.Size(66, 23);
            this.btnConfirmarExe.TabIndex = 1;
            this.btnConfirmarExe.Text = "Confirmar";
            this.btnConfirmarExe.UseVisualStyleBackColor = true;
            // 
            // btnCancelarExe
            // 
            this.btnCancelarExe.Location = new System.Drawing.Point(175, 56);
            this.btnCancelarExe.Name = "btnCancelarExe";
            this.btnCancelarExe.Size = new System.Drawing.Size(66, 23);
            this.btnCancelarExe.TabIndex = 2;
            this.btnCancelarExe.Text = "Cancelar";
            this.btnCancelarExe.UseVisualStyleBackColor = true;
            this.btnCancelarExe.Click += new System.EventHandler(this.btnCancelarExe_Click);
            // 
            // Executar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 91);
            this.Controls.Add(this.btnCancelarExe);
            this.Controls.Add(this.btnConfirmarExe);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Executar";
            this.Text = "Executar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnConfirmarExe;
        private System.Windows.Forms.Button btnCancelarExe;
    }
}