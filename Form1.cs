using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using windowsFormsTeste.Comandos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace windowsFormsTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
           databaseHelper dbHelper = new databaseHelper();

            string usuario = dbHelper.GetUsuarioDb(txtUsuarioLogin.Text);

            string Senha = dbHelper.GetSenhaDb(txtUsuarioLogin.Text);

            if (usuario == txtUsuarioLogin.Text && Senha == txtSenhaLogin.Text)
            {
                menu menu = new menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario ou senha inválidos!");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar(this);
            this.Hide();
            cadastrar.Show();
        }
    }
}
