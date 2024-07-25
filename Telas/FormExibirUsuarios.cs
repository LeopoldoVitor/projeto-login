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
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir este usuário?", "Confirmação",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                        int userId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["Codigo"].Value);

                        databaseHelper dbHelper = new databaseHelper();
                        dbHelper.DeleteUsuario(userId);

                        // Atualiza a lista de usuários após a exclusão
                        listarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("Exclusão cancelada!");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um usuário para excluir.");
                }
            
        }
    }
}
