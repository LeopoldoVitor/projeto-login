namespace windowsFormsTeste
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            btnEntrar = new Button();
            btnCadastrar = new Button();
            label2 = new Label();
            label1 = new Label();
            txtSenhaLogin = new TextBox();
            txtUsuarioLogin = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEntrar);
            groupBox1.Controls.Add(btnCadastrar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSenhaLogin);
            groupBox1.Controls.Add(txtUsuarioLogin);
            groupBox1.Location = new Point(18, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 235);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(257, 172);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(94, 29);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(147, 172);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(94, 29);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 104);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 3;
            label2.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 33);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 2;
            label1.Text = "Usuário:";
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.Location = new Point(22, 127);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.Size = new Size(329, 27);
            txtSenhaLogin.TabIndex = 1;
            txtSenhaLogin.UseSystemPasswordChar = true;
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.Location = new Point(22, 56);
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.Size = new Size(329, 27);
            txtUsuarioLogin.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 266);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrar";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnEntrar;
        private Button btnCadastrar;
        private Label label2;
        private Label label1;
        private TextBox txtSenhaLogin;
        private TextBox txtUsuarioLogin;
    }
}
