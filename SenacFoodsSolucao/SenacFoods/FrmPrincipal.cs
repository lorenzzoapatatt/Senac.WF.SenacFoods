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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FRMcardapio_Load_Click(object sender, EventArgs e)
        {
            var frmCardapio = new FrmCardapio();
            frmCardapio.ShowDialog();
        }

        private void BuscarCardapio()
        {
            using (var bd = new ComandaDBContext())
            {
                var cardapios = bd.Cardapioitems.ToList();

            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
            var frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }
    }
}
