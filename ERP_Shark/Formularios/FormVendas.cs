using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP_Shark.Formularios
{
    public partial class FormVendas : ERP_Shark.FormBase
    {
        public FormVendas()
        {
            InitializeComponent();
        }

        private void FormVendas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void label1_Click_1(object sender, EventArgs e)
        {
           
           
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtBarras.Text = string.Empty;
            txtCliente.Text = string.Empty;
            txtData.Text = string.Empty;
            txtRedTrans.Text = string.Empty;
            txtTransacao.Text = string.Empty;
            txtVendedor.Text = string.Empty;    
            

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void cbValidar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtVendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarTrans_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Op_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbOperacaoVendas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbValue.Text = cbOperacaoVendas.Text; // puxa o nome da operação de vendas no campo vazio 
        }
    }
}
