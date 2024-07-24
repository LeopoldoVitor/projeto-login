namespace windowsFormsTeste
{
    partial class menu
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
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            menuSair = new ToolStripMenuItem();
            voltarAoLoginToolStripMenuItem = new ToolStripMenuItem();
            aDMToolStripMenuItem = new ToolStripMenuItem();
            listarUsuariosCadastradosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, aDMToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuSair, voltarAoLoginToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(59, 24);
            cadastroToolStripMenuItem.Text = "Inicio";
            // 
            // menuSair
            // 
            menuSair.Name = "menuSair";
            menuSair.Size = new Size(190, 26);
            menuSair.Text = "sair";
            menuSair.Click += menuSair_Click;
            // 
            // voltarAoLoginToolStripMenuItem
            // 
            voltarAoLoginToolStripMenuItem.Name = "voltarAoLoginToolStripMenuItem";
            voltarAoLoginToolStripMenuItem.Size = new Size(190, 26);
            voltarAoLoginToolStripMenuItem.Text = "Voltar ao login";
            voltarAoLoginToolStripMenuItem.Click += voltarAoLoginToolStripMenuItem_Click;
            // 
            // aDMToolStripMenuItem
            // 
            aDMToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listarUsuariosCadastradosToolStripMenuItem });
            aDMToolStripMenuItem.Name = "aDMToolStripMenuItem";
            aDMToolStripMenuItem.Size = new Size(57, 24);
            aDMToolStripMenuItem.Text = "ADM";
            // 
            // listarUsuariosCadastradosToolStripMenuItem
            // 
            listarUsuariosCadastradosToolStripMenuItem.Name = "listarUsuariosCadastradosToolStripMenuItem";
            listarUsuariosCadastradosToolStripMenuItem.Size = new Size(273, 26);
            listarUsuariosCadastradosToolStripMenuItem.Text = "Listar Usuarios Cadastrados";
            listarUsuariosCadastradosToolStripMenuItem.Click += listarUsuariosCadastradosToolStripMenuItem_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "menu";
            Text = "menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem menuSair;
        private ToolStripMenuItem voltarAoLoginToolStripMenuItem;
        private ToolStripMenuItem aDMToolStripMenuItem;
        private ToolStripMenuItem listarUsuariosCadastradosToolStripMenuItem;
    }
}