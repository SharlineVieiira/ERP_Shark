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
    public partial class Shar_ERP : Form
    {
        public string NomeUser;
        public Shar_ERP()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != String.Empty && txtSenha.Text.Trim() != String.Empty)
            {
                NomeUser = txtUsuario.Text;


                MessageBox.Show("Bem vindo " + txtUsuario.Text);

            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente");
                txtSenha.Clear();
                txtUsuario.Clear();
            }
            Menu m = new Menu(NomeUser); // abrir outro form 
            m.Show();
            this.Show();
        }
    }
}
