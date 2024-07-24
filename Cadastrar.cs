using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Data.SqlClient;
using windowsFormsTeste.Comandos;

namespace windowsFormsTeste
{
    public partial class Cadastrar : Form
    {

        private Form1 formularioLogin;

        SqlConnection sqlConn;

        public Cadastrar(Form1 form1)
        {
            InitializeComponent();
            formularioLogin = form1;

            string connectionString = "Data Source=172.16.0.185\\DESENVOLVIMENTO;Initial Catalog=DB_WINDOWSFORMS;User ID=squadjedis;password=selbricoh";
            sqlConn = new SqlConnection(connectionString);
        }

        private void btnCriarNovoCadastro_Click(object sender, EventArgs e)
        {
            if (txtSenhaCadastro.Text == txtConfirmarSenha.Text)
            {
                databaseHelper dbHelper = new databaseHelper();
                dbHelper.SetCadastroDb(txtUsuarioCadastro.Text, txtSenhaCadastro.Text);

                this.Hide();
                formularioLogin.Show();
            }
            else
            {
                MessageBox.Show("Senhas nao coincidem!");
            }
        }
    }
}
