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
        private Usuario? _usuario;
        public FrmUsuariosCad()
        {
            InitializeComponent();
        }

        public FrmUsuariosCad(Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();

            //carregar os dados da tela
            CarregarDadosDaTela();
        }

        private void CarregarDadosDaTela()
        {
            //popular os campos de texto e checkbox
            if (_usuario != null)
            {
                txtUsuario.Text = _usuario.Nome;
                txtEmail.Text = _usuario.Email;
                txtSenha.Text = _usuario.Senha;
                txtSenhaConfirmar.Text = _usuario.Senha;
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
                SalvarForm();
        }

        private void SalvarForm()
        {
            if (_usuario != null)
                AtualizarUsuario();
            else
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

        private void AtualizarUsuario()
        {
            using (var banco = new ComandaDBContext())
            {
                string nome = txtUsuario.Text;
                string email = txtEmail.Text;
                string senha = txtSenha.Text;
                string comboboxPerfil = cmbPerfil.Text;
                _usuario.Nome = nome;
                _usuario.Email = email;
                _usuario.Senha = senha;
                _usuario.Perfil = comboboxPerfil;
                banco.Usuarios.Update(_usuario);
                banco.SaveChanges();
            }
            MessageBox.Show("Cardápio salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void InserirUsuario()
        {
            using (var banco = new ComandaDBContext())
            {
                string nome = txtUsuario.Text;
                string email = txtEmail.Text;
                string senha = txtSenha.Text;
                string comboboxPerfil = cmbPerfil.Text;

                var usu = new Usuario()
                {
                    Nome = nome,
                    Email = email,
                    Senha = senha,
                    Perfil = comboboxPerfil,
                    Ativo = true
                };

                banco.Usuarios.Add(usu);
                banco.SaveChanges();
            }

            MessageBox.Show("Usuário salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
