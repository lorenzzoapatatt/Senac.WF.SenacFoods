using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacFoods
{
    public partial class FrmUsuariosCad : Form
    {
        public FrmUsuariosCad()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
                SalvarForm();
        }

        private void SalvarForm()
        {
            InserirUsuario();
        }

        private bool ValidarForm()
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("O campo email é obrigatório");
                txtEmail.Focus();
                return false;
            }
            else if (txtUsuario.Text == "")
            {
                MessageBox.Show("O campo usuario é obrigatório");
                txtEmail.Focus();
                return false;
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("O campo senha é obrigatório");
                txtSenha.Focus();
                return false;
            }
            else if (txtSenhaConfirmar.Text == "")
            {
                MessageBox.Show("O campo senha é obrigatório");
                txtSenhaConfirmar.Focus();
                return false;
            }

            if (txtSenha.Text != txtSenhaConfirmar.Text)
            {
                MessageBox.Show("As senhas não conferem");
                txtSenha.Focus();
                return false;
            }

            if (txtSenha.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres");
                txtSenha.Focus();
                return false;
            }



            return true;
        }

        private void InserirUsuario()
        {
            using (var banco = new ComandaDBContext())
            {
                string nome = txtUsuario.Text;
                string email = txtEmail.Text;
                string senha = txtSenha.Text;

                var usu = new Usuario()
                {
                    Nome = nome,
                    Email = email,
                    Senha = senha,
                    Ativo = true
                };

                banco.Usuarios.Add(usu);
                banco.SaveChanges();
            }

            MessageBox.Show("Usuário salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

    }
}
