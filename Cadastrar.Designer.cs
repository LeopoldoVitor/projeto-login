namespace windowsFormsTeste
{
    partial class Cadastrar
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
            txtConfirmarSenha = new TextBox();
            labelConfirmarSenha = new Label();
            btnCriarNovoCadastro = new Button();
            label2 = new Label();
            label1 = new Label();
            txtSenhaCadastro = new TextBox();
            txtUsuarioCadastro = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtConfirmarSenha);
            groupBox1.Controls.Add(labelConfirmarSenha);
            groupBox1.Controls.Add(btnCriarNovoCadastro);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSenhaCadastro);
            groupBox1.Controls.Add(txtUsuarioCadastro);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 268);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insira suas informações para o cadastro";
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(22, 195);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(369, 27);
            txtConfirmarSenha.TabIndex = 6;
            txtConfirmarSenha.UseSystemPasswordChar = true;
            // 
            // labelConfirmarSenha
            // 
            labelConfirmarSenha.AutoSize = true;
            labelConfirmarSenha.Location = new Point(20, 172);
            labelConfirmarSenha.Name = "labelConfirmarSenha";
            labelConfirmarSenha.Size = new Size(122, 20);
            labelConfirmarSenha.TabIndex = 5;
            labelConfirmarSenha.Text = "Confirmar Senha:";
            // 
            // btnCriarNovoCadastro
            // 
            btnCriarNovoCadastro.Location = new Point(297, 233);
            btnCriarNovoCadastro.Name = "btnCriarNovoCadastro";
            btnCriarNovoCadastro.Size = new Size(94, 29);
            btnCriarNovoCadastro.TabIndex = 4;
            btnCriarNovoCadastro.Text = "Cadastrar";
            btnCriarNovoCadastro.UseVisualStyleBackColor = true;
            btnCriarNovoCadastro.Click += btnCriarNovoCadastro_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 99);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 3;
            label2.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 24);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 2;
            label1.Text = "Usuário:";
            // 
            // txtSenhaCadastro
            // 
            txtSenhaCadastro.Location = new Point(20, 122);
            txtSenhaCadastro.Name = "txtSenhaCadastro";
            txtSenhaCadastro.Size = new Size(371, 27);
            txtSenhaCadastro.TabIndex = 1;
            txtSenhaCadastro.UseSystemPasswordChar = true;
            // 
            // txtUsuarioCadastro
            // 
            txtUsuarioCadastro.Location = new Point(20, 52);
            txtUsuarioCadastro.Name = "txtUsuarioCadastro";
            txtUsuarioCadastro.Size = new Size(371, 27);
            txtUsuarioCadastro.TabIndex = 0;
            // 
            // Cadastrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 288);
            Controls.Add(groupBox1);
            Name = "Cadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSenhaCadastro;
        private TextBox txtUsuarioCadastro;
        private Label label2;
        private Label label1;
        private Button btnCriarNovoCadastro;
        private Label labelConfirmarSenha;
        private TextBox txtConfirmarSenha;
    }
}