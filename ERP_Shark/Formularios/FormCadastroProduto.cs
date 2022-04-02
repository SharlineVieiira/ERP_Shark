using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP_Shark
{
    public partial class FormCadastroProduto : ERP_Shark.FormBase
    {
        public string NomeUser;
        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtDescriPD.Text = string.Empty;
            txtCGrupo.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtFornec.Text = string.Empty;

            LilberaCampos();
            txtFornec.Focus();
        }
        private void CarregarGrid()
        {
            Model get = new Model();
            List<DtoProduto2> lista1 = get.ListProduto();
            this.dataGridView2.DataSource = lista1;
            this.dataGridView2.Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            LilberaCampos();
            txtCGrupo.Focus();
        }

        private void txtOperador_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Model set = new Model();
                DtoProduto pd = new DtoProduto();
                pd.descricaoproduto = txtDescriPD.Text;
                pd.unidade =    txtEspecie.Text;

                if (txtReduzidoPD.Text != string.Empty)
                {
                    pd.idProduto = int.Parse(txtReduzidoPD.Text);
                    set.EditProduto(pd);
                }
                else
                {
                   set.SetProduto(pd);
                }

                BloqueiaCampos();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LilberaCampos()
            {
                txtCGrupo.Enabled = true;
                txtDescriPD.Enabled = true;
                txtValor.Enabled = true;
            }
            private void BloqueiaCampos()
            {
                txtReduzidoPD.Enabled = false;
                txtEspecie.Enabled = false;
                txtDescricaoValor.Enabled = false;

            }

        }
    }

