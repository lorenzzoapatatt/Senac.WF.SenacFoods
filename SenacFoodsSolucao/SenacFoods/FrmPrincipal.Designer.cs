namespace SenacFoods
{
    partial class FrmPrincipal
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
            btnUsuario = new Button();
            button3 = new Button();
            button2 = new Button();
            FRMcardapio_Load = new Button();
            btnFechar = new Button();
            lblMessage = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Black;
            groupBox1.Controls.Add(btnUsuario);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(FRMcardapio_Load);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(122, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(823, 197);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Senac Foods";
            // 
            // btnUsuario
            // 
            btnUsuario.BackColor = Color.FromArgb(255, 128, 0);
            btnUsuario.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuario.ForeColor = Color.Black;
            btnUsuario.Location = new Point(620, 30);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(175, 140);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "Usuário";
            btnUsuario.UseVisualStyleBackColor = false;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(420, 30);
            button3.Name = "button3";
            button3.Size = new Size(175, 140);
            button3.TabIndex = 0;
            button3.Text = "Pedido Cozinha";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(220, 30);
            button2.Name = "button2";
            button2.Size = new Size(175, 140);
            button2.TabIndex = 0;
            button2.Text = "Comanda";
            button2.UseVisualStyleBackColor = false;
            // 
            // FRMcardapio_Load
            // 
            FRMcardapio_Load.BackColor = Color.FromArgb(255, 128, 0);
            FRMcardapio_Load.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            FRMcardapio_Load.FlatAppearance.BorderSize = 0;
            FRMcardapio_Load.FlatStyle = FlatStyle.Flat;
            FRMcardapio_Load.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FRMcardapio_Load.ForeColor = Color.Black;
            FRMcardapio_Load.Location = new Point(20, 30);
            FRMcardapio_Load.Name = "FRMcardapio_Load";
            FRMcardapio_Load.Size = new Size(175, 140);
            FRMcardapio_Load.TabIndex = 0;
            FRMcardapio_Load.Text = "Cardápio";
            FRMcardapio_Load.UseVisualStyleBackColor = false;
            FRMcardapio_Load.Click += FRMcardapio_Load_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(1055, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(27, 34);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.BackColor = Color.Black;
            lblMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = SystemColors.ButtonHighlight;
            lblMessage.Location = new Point(455, 57);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(142, 32);
            lblMessage.TabIndex = 6;
            lblMessage.Text = "lblMessage";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1094, 450);
            Controls.Add(lblMessage);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnUsuario;
        private Button FRMcardapio_Load;
        private Button btnFechar;
        private Label lblMessage;
    }
}