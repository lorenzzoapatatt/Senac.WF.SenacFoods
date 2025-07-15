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
    public partial class FrmMesaCad : Form
    {
        public FrmMesaCad()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            label2.Text = txtNome.Text;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarMesa();
            this.Close();
        }

        private void SalvarMesa()
        {
            using (var b = new ComandaDBContext())
            {
                int.TryParse(txtNome.Text, out int numeromesa);
                var mesa = new Mesa()
                {
                    NumeroMesa = numeromesa
                };
                b.Mesas.Add(mesa);
                b.SaveChanges();
            }
            MessageBox.Show("Mesa salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmMesaCad_Load(object sender, EventArgs e)
        {
            BuscarMesa();
        }

        private void BuscarMesa()
        {
            using (var bd = new ComandaDBContext())
            {
                var mesa = bd.Mesas.AsQueryable();
                dataGridView1.DataSource = mesa.ToList();
            }
        }
    }
}
