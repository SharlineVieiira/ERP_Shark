using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Shark.Formularios
{
    public partial class Executar : Form
    {
        public Executar()
        {
            InitializeComponent();
        }

        private void btnCancelarExe_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
