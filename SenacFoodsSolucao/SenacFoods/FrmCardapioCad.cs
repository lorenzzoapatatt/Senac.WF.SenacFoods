using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacFoods
{
    public partial class FrmCardapioCad : Form
    {
        private Cardapioitem _cardapioItem;
        public FrmCardapioCad()
        {
            InitializeComponent();
        }

        public FrmCardapioCad(Cardapioitem cardapioitem)
        {
            _cardapioItem = cardapioitem;
            InitializeComponent();

            //carregar os dados da tela
            CarregarDadosDaTela();
        }

        private void CarregarDadosDaTela()
        {
            //popular os campos de texto e checkbox
            if (_cardapioItem != null)
            {
                txtTitulo.Text = _cardapioItem.Titulo;
                txtDescricao.Text = _cardapioItem.Descricao;
                txtPreco.Text = _cardapioItem.Preco.ToString("F2");
                chkPossuiPreparo.Checked = _cardapioItem.PossuiPreparo;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //inserir
            if (_cardapioItem == null)
            {
                InserirCardapio();
            }
            //atualizar
            else
            {
                AtualizarCardapio();
            }
        }

        private void AtualizarCardapio()
        {
            using (var banco = new ComandaDBContext())
            {
                string titulo = txtTitulo.Text;
                string descricao = txtDescricao.Text;
                decimal.TryParse(txtPreco.Text, out var preco);
                bool possuiPreparo = chkPossuiPreparo.Checked;
                //atualizar o cardapio
                var cardapioItem = banco.Cardapioitems.First(x => x.Id == _cardapioItem.Id);
                cardapioItem.Titulo = titulo;
                cardapioItem.Descricao = descricao;
                cardapioItem.Preco = preco;
                cardapioItem.PossuiPreparo = possuiPreparo;
                //salvar as alterações no banco de dados
                banco.Cardapioitems.Update(cardapioItem);
                banco.SaveChanges();
            }
            MessageBox.Show("Cardápio salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void InserirCardapio()
        {
            // conectar
            using (var banco = new ComandaDBContext())
            {
                // captar os dados da tela
                string titulo = txtTitulo.Text;
                string descricao = txtDescricao.Text;
                decimal.TryParse(txtPreco.Text, out var preco);
                bool possuiPreparo = chkPossuiPreparo.Checked;
                // criar um novo cardapio
                var cardapio = new Cardapioitem()
                {
                    Descricao = descricao,
                    Titulo = titulo,
                    Preco = preco,
                    PossuiPreparo = possuiPreparo
                };
                // adicionar o cardapio //salvar as alterações no banco de dados
                banco.Cardapioitems.Add(cardapio);
                banco.SaveChanges();
            }
            MessageBox.Show("Cardápio salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
