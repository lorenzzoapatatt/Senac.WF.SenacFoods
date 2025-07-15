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
    public partial class FrmCardapio : Form
    {
        Cardapioitem? cardapioSelecionado;
        public FrmCardapio()
        {
            InitializeComponent();
        }

        private void FrmCardapio_Load(object sender, EventArgs e)
        {
            BuscarCardapio();
        }

        private void BuscarCardapio()
        {
            // conectar no banco de dados
            using (var bd = new ComandaDBContext())
            {
                // consultar a tabela cardapioitem
                var cardapios = bd.Cardapioitems.ToList();
                // popular o grid com a tabela consultada
                dataGridView1.DataSource = cardapios;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //pegar o cardapio selecionado
                cardapioSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as Cardapioitem;
                btnEditar.Enabled = true;
            }
        }

        //clique do editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cardapioSelecionado != null)
            {
                //abrir o formulario de edição
                var cardapioEditar = new FrmCardapioCad(cardapioSelecionado);
                cardapioEditar.Show();
                //atualizar a lista de cardapios
                BuscarCardapio();
                cardapioSelecionado = null;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (cardapioSelecionado != null)
            {
                using (var bancoDeDados = new ComandaDBContext())
                {
                    bancoDeDados.Cardapioitems.Remove(cardapioSelecionado);
                    bancoDeDados.SaveChanges();
                }
                MessageBox.Show("Cardápio excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarCardapio();
                cardapioSelecionado = null;
            }
            else
            {
                MessageBox.Show("Selecione um cardápio para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //button adicionar
            new FrmCardapioCad().ShowDialog();
            BuscarCardapio();
        }
    }
}
