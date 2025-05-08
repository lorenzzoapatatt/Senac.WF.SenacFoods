namespace SenacFoods
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnEntrar = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 482);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEntrar);
            panel2.Controls.Add(txtSenha);
            panel2.Controls.Add(txtLogin);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(334, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(648, 482);
            panel2.TabIndex = 1;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.Black;
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogin.ForeColor = Color.White;
            txtLogin.Location = new Point(118, 97);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(412, 45);
            txtLogin.TabIndex = 0;
            txtLogin.Text = "USUÁRIO";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.Black;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.White;
            txtSenha.Location = new Point(118, 218);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(412, 45);
            txtSenha.TabIndex = 0;
            txtSenha.Text = "SENHA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(114, 100);
            label1.Name = "label1";
            label1.Size = new Size(380, 48);
            label1.TabIndex = 1;
            label1.Text = "________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(112, 221);
            label2.Name = "label2";
            label2.Size = new Size(380, 48);
            label2.TabIndex = 2;
            label2.Text = "________________________";
            // 
            // btnEntrar
            // 
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.White;
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(118, 335);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(374, 62);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(982, 482);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label label1;
        private Label label2;
        private Button btnEntrar;
    }
}
