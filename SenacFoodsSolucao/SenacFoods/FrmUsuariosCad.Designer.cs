namespace SenacFoods
{
    partial class FrmUsuariosCad
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
            txtUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtSenha = new TextBox();
            label4 = new Label();
            txtSenhaConfirmar = new MaskedTextBox();
            button2 = new Button();
            btnSalvar = new Button();
            panel1 = new Panel();
            label5 = new Label();
            btnFechar = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            txtPerfil = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPerfil);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(txtSenhaConfirmar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Location = new Point(12, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1070, 385);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(6, 62);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(496, 31);
            txtUsuario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 1;
            label1.Text = "Nome do usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 101);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 3;
            label2.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(6, 129);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(496, 31);
            txtEmail.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 173);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 5;
            label3.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(6, 201);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(496, 31);
            txtSenha.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 246);
            label4.Name = "label4";
            label4.Size = new Size(144, 25);
            label4.TabIndex = 5;
            label4.Text = "Confirmar Senha";
            // 
            // txtSenhaConfirmar
            // 
            txtSenhaConfirmar.Location = new Point(7, 274);
            txtSenhaConfirmar.Name = "txtSenhaConfirmar";
            txtSenhaConfirmar.Size = new Size(495, 31);
            txtSenhaConfirmar.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(805, 345);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 8;
            button2.Text = "X Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.YellowGreen;
            btnSalvar.Location = new Point(923, 345);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 34);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "# Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1095, 88);
            panel1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 28);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 2;
            label5.Text = "Pesquisar:";
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
            // textBox1
            // 
            textBox1.Location = new Point(99, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(669, 31);
            textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(853, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 9;
            comboBox1.Tag = "";
            // 
            // txtPerfil
            // 
            txtPerfil.AutoSize = true;
            txtPerfil.Location = new Point(853, 27);
            txtPerfil.Name = "txtPerfil";
            txtPerfil.Size = new Size(50, 25);
            txtPerfil.TabIndex = 10;
            txtPerfil.Text = "Perfil";
            // 
            // FrmUsuariosCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 522);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuariosCad";
            Text = "FrmUsuariosCad";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtUsuario;
        private MaskedTextBox txtSenhaConfirmar;
        private Label label4;
        private Label label3;
        private TextBox txtSenha;
        private Label label2;
        private TextBox txtEmail;
        private Button button2;
        private Button btnSalvar;
        private Label txtPerfil;
        private ComboBox comboBox1;
        private Panel panel1;
        private Label label5;
        private Button btnFechar;
        private TextBox textBox1;
    }
}