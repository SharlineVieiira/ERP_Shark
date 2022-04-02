using ERP_Shark.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Shark
{
    public partial class Menu : Form
    {
        public Menu(string Nome)
        {
            InitializeComponent();
            textBox2.Text = Nome;
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            FormCadastroProduto CadProduto = new FormCadastroProduto();
            CadProduto.Show();
            
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            FormEntrada formEntrada = new FormEntrada();
            formEntrada.Show();
        }

        private void btnUsuarioMenu_Click(object sender, EventArgs e)
        {

            FormUsuario f = new FormUsuario();
            f.Show();

        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            FormVendas vendas = new FormVendas();   
            vendas.Show();  
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Shar_ERP shar_ERP = new Shar_ERP();
           
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FECHAR TUDO.... ERRO 
            
            this.Close(); 
        }

        private void executarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Executar executar = new Executar();
            executar.Show();    
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
