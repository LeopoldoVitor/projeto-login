using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windowsFormsTeste.Comandos;

namespace windowsFormsTeste.Telas
{
    public partial class FormExibirUsuarios : Form
    {
        public FormExibirUsuarios()
        {
            InitializeComponent();
            listarUsuarios();
        }

        public void listarUsuarios()
        {
            databaseHelper dbHelper = new databaseHelper();
            List<Usuario> lstUsuarios = dbHelper.GetLstUsuarios();

            dataGridView1.DataSource = lstUsuarios;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            databaseHelper dbHelper = new databaseHelper();
            List<Usuario> lstUsuarios = dbHelper.GetLstUsuarios();

            for (var i = 0; i < lstUsuarios.Count; i++)
            {
                
            }

        }
    }
}
