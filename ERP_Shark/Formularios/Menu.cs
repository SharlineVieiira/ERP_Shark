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
            
            FormCadastroUsuario CadUser = new FormCadastroUsuario();
            CadUser.Show();
        }
    }
}
