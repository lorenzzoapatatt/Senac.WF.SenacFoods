namespace SenacFoods
{
    partial class FrmComandaCad
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
            btnFechar = new Button();
            panel1 = new Panel();
            Comanda = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            btnSalvar = new Button();
            button5 = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            Comanda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(1054, 15);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(27, 34);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnFechar);
            panel1.Location = new Point(-3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1099, 88);
            panel1.TabIndex = 10;
            // 
            // Comanda
            // 
            Comanda.Controls.Add(button5);
            Comanda.Controls.Add(button2);
            Comanda.Controls.Add(btnSalvar);
            Comanda.Controls.Add(dataGridView1);
            Comanda.Controls.Add(comboBox2);
            Comanda.Controls.Add(label3);
            Comanda.Controls.Add(comboBox1);
            Comanda.Controls.Add(label2);
            Comanda.Controls.Add(textBox1);
            Comanda.Controls.Add(label1);
            Comanda.Location = new Point(31, 112);
            Comanda.Name = "Comanda";
            Comanda.Size = new Size(610, 493);
            Comanda.TabIndex = 11;
            Comanda.TabStop = false;
            Comanda.Text = "Comanda";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 36);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome do Cliente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(525, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 132);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 2;
            label2.Text = "Mesa:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(185, 132);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(374, 33);
            comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 187);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 4;
            label3.Text = "Cardápio:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(185, 187);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(256, 33);
            comboBox2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 231);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(525, 204);
            dataGridView1.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(329, 441);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 10;
            button2.Text = "X Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.YellowGreen;
            btnSalvar.Location = new Point(447, 441);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 34);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "# Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Yellow;
            button5.Location = new Point(447, 186);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 11;
            button5.Text = "+ Item";
            button5.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 35);
            label4.Name = "label4";
            label4.Size = new Size(122, 32);
            label4.TabIndex = 6;
            label4.Text = "Comanda";
            // 
            // FrmComandaCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 651);
            Controls.Add(Comanda);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComandaCad";
            Text = "FrmComandaCad";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Comanda.ResumeLayout(false);
            Comanda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnFechar;
        private Panel panel1;
        private GroupBox Comanda;
        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox comboBox2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox1;
        private Button button2;
        private Button btnSalvar;
        private Button button5;
        private Label label4;
    }
}