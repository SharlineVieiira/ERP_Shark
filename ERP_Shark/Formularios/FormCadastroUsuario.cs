using ERP_Shark.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP_Shark
{
    public partial class FormCadastroUsuario : ERP_Shark.FormBase
    {
        public FormCadastroUsuario()
        {
            InitializeComponent();
            BloqueiaCampos();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            Model get = new Model();
            List<DtoUsuario2> lista = get.ListUsuarios();
            this.dataGridView1.DataSource = lista;
            this.dataGridView1.Refresh();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNomeBox.Text = string.Empty;
            txtLoginBox.Text = string.Empty;
            txtSenhaBox.Text = string.Empty;
            LiberaCampos();
            txtNomeBox.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Model set = new Model();
                DtoUsuario u = new DtoUsuario();
                u.nome = txtNomeBox.Text;
                u.login = txtLoginBox.Text;
                u.senha = txtSenhaBox.Text;
                if (txtIdBox.Text != string.Empty)
                {
                    u.id = int.Parse(txtIdBox.Text);
                 set.EditUsuario(u);
                }
                else
                {
                 set.SetUsuario(u);
                }

                BloqueiaCampos();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        #region Tratamento Visual
        private void LiberaCampos()
        {
            txtNomeBox.Enabled = true;
            txtLoginBox.Enabled = true;
            txtSenhaBox.Enabled = true;
        }
        private void BloqueiaCampos()
        {
            txtIdBox.Enabled = false;
            txtNomeBox.Enabled = false;
            txtLoginBox.Enabled = false;
            txtSenhaBox.Enabled = false;
        }
        #endregion

        private void btnEdit_Click(object sender, EventArgs e)
        {
            LiberaCampos();  
            txtNomeBox.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtIdBox.Text != string.Empty)
            {
                Model del = new Model();
                del.DeletarUsuario(int.Parse(txtIdBox.Text));
                BloqueiaCampos();
                CarregarGrid();
            }
        }
        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int ID = (Int32)dataGridView1.CurrentRow.Cells[0].Value;

            Model get = new Model();
            DtoUsuario2 d = get.GetUsuarioId(ID);
            txtIdBox.Text = d.id.ToString();
            txtNomeBox.Text = d.nome;
            LiberaCampos();
            txtNomeBox.Focus();
        }
}
}
