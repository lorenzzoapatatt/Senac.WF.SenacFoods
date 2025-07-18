namespace SenacFoods
{
    partial class FrmCardapioCad
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
            panel1 = new Panel();
            label1 = new Label();
            btnFechar = new Button();
            Cardapio = new GroupBox();
            txtDescricao = new RichTextBox();
            txtPreco = new TextBox();
            txtTitulo = new TextBox();
            chkPossuiPreparo = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            btnSalvar = new Button();
            panel1.SuspendLayout();
            Cardapio.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnFechar);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1095, 88);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 29);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 6;
            label1.Text = "Cadastro de Cardapio";
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
            // Cardapio
            // 
            Cardapio.Controls.Add(txtDescricao);
            Cardapio.Controls.Add(txtPreco);
            Cardapio.Controls.Add(txtTitulo);
            Cardapio.Controls.Add(chkPossuiPreparo);
            Cardapio.Controls.Add(label4);
            Cardapio.Controls.Add(label3);
            Cardapio.Controls.Add(label2);
            Cardapio.Controls.Add(button2);
            Cardapio.Controls.Add(btnSalvar);
            Cardapio.Location = new Point(99, 120);
            Cardapio.Name = "Cardapio";
            Cardapio.Size = new Size(900, 484);
            Cardapio.TabIndex = 8;
            Cardapio.TabStop = false;
            Cardapio.Text = "Cardapio";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(18, 149);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(583, 93);
            txtDescricao.TabIndex = 11;
            txtDescricao.Text = "";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(18, 273);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(583, 31);
            txtPreco.TabIndex = 10;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(18, 88);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(583, 31);
            txtTitulo.TabIndex = 8;
            // 
            // chkPossuiPreparo
            // 
            chkPossuiPreparo.AutoSize = true;
            chkPossuiPreparo.Location = new Point(18, 310);
            chkPossuiPreparo.Name = "chkPossuiPreparo";
            chkPossuiPreparo.Size = new Size(164, 29);
            chkPossuiPreparo.TabIndex = 7;
            chkPossuiPreparo.Text = "Possui preparo?";
            chkPossuiPreparo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 245);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 6;
            label4.Text = "Preço:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 121);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 5;
            label3.Text = "Descrição:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 60);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 4;
            label2.Text = "Titulo";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(644, 439);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 3;
            button2.Text = "X Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.YellowGreen;
            btnSalvar.Location = new Point(762, 439);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 34);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "# Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FrmCardapioCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 636);
            Controls.Add(Cardapio);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapioCad";
            Text = "FrmCardapioCad";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Cardapio.ResumeLayout(false);
            Cardapio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnFechar;
        private GroupBox Cardapio;
        private Button button2;
        private Button btnSalvar;
        private CheckBox chkPossuiPreparo;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtPreco;
        private TextBox txtTitulo;
        private RichTextBox txtDescricao;
        private Label label1;
    }
}