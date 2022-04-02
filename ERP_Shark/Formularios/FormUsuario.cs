using ERP_Shark.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP_Shark.Formularios
{
    public partial class FormUsuario : ERP_Shark.FormBase
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = string.Empty;
            textBoxLogin.Text = string.Empty;
            textBoxSenha.Text = string.Empty;
            LilberaCampos();
            textBoxNome.Focus();
        }
        private void CarregarGrid()
        {
            Model get = new Model();
            List<DtoUsuario2> lista = get.ListUsuarios();
            this.dataGridView1.DataSource = lista;
            this.dataGridView1.Refresh();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Model set = new Model();
                DtoUsuario u = new DtoUsuario();
                u.nome = textBoxNome.Text;
                u.login = textBoxLogin.Text;
                u.senha = textBoxSenha.Text;
                if (textBoxID.Text != string.Empty)
                {
                    u.id = int.Parse(textBoxID.Text);
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
        private void LilberaCampos()
        {
            textBoxNome.Enabled = true;
            textBoxLogin.Enabled = true;
            textBoxSenha.Enabled = true;
        }
        private void BloqueiaCampos()
        {
            textBoxID.Enabled = false;
            textBoxNome.Enabled = false;
            textBoxLogin.Enabled = false;
            textBoxSenha.Enabled = false;
        }
        #endregion

        private void btnEdit_Click(object sender, EventArgs e)
        {
            LilberaCampos();
            textBoxNome.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

