namespace SenacFoods
{
    partial class FrmCardapio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Cardapio = new GroupBox();
            button5 = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            btnFechar = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Cardapio.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(852, 347);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Cardapio
            // 
            Cardapio.Controls.Add(button5);
            Cardapio.Controls.Add(btnExcluir);
            Cardapio.Controls.Add(btnEditar);
            Cardapio.Controls.Add(dataGridView1);
            Cardapio.Location = new Point(98, 93);
            Cardapio.Name = "Cardapio";
            Cardapio.Size = new Size(900, 484);
            Cardapio.TabIndex = 1;
            Cardapio.TabStop = false;
            Cardapio.Text = "Cardapio";
            // 
            // button5
            // 
            button5.BackColor = Color.Yellow;
            button5.Location = new Point(22, 46);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 4;
            button5.Text = "+ Item";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.Location = new Point(644, 439);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(112, 34);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "X Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.YellowGreen;
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(762, 439);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "# Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 28);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 2;
            label1.Text = "Pesquisar:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(99, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(669, 31);
            textBox1.TabIndex = 3;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(1055, 7);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(27, 34);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1095, 88);
            panel1.TabIndex = 6;
            // 
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1094, 670);
            Controls.Add(panel1);
            Controls.Add(Cardapio);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            Load += FrmCardapio_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Cardapio.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Cardapio;
        private Button btnEditar;
        private Button button4;
        private Button button3;
        private Button btnExcluir;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Button btnFechar;
        private Button button5;
        private Panel panel1;
    }
}