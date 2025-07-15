namespace SenacFoods
{
    partial class FrmMesaCad
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
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            btnSalvar = new Button();
            dataGridView1 = new DataGridView();
            txtNome = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            btnFechar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(995, 407);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Cardapio";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(72, 194);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 155);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Red;
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(587, 358);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(360, 34);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Adicionar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(587, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 294);
            dataGridView1.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(136, 83);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(150, 31);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 83);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 0;
            label2.Text = "Numero Mesa";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(btnFechar);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1025, 60);
            panel1.TabIndex = 2;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(982, 3);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(27, 34);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // FrmMesaCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 484);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "FrmMesaCad";
            Text = "FrmMesaCad";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnSalvar;
        private DataGridView dataGridView1;
        private TextBox txtNome;
        private Button btnFechar;
    }
}