﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsFormsTeste.Comandos
{
    public class databaseHelper
    {
        SqlConnection sqlConn;
        string connectionString = "Data Source=172.16.0.185\\DESENVOLVIMENTO;Initial Catalog=DB_WINDOWSFORMS;User ID=squadjedis;password=selbricoh";

        public string GetUsuarioDb(string txtUsuario)
        {
            sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();

            string queryUsuario = "SELECT Nome FROM usuarios WHERE Nome = @Nome";
            SqlCommand verificaUsuario = new SqlCommand(queryUsuario, sqlConn);
            verificaUsuario.Parameters.AddWithValue("@Nome", txtUsuario);

            // Execute o comando e armazene o resultado
            string resultUsuario = Convert.ToString(verificaUsuario.ExecuteScalar());

            sqlConn.Close();

            return resultUsuario;
        }

        public string GetSenhaDb(string txtUsuario)
        {
            sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();

            string querySenha = "SELECT Senha FROM usuarios WHERE Nome = @Nome";
            SqlCommand verificaSenha = new SqlCommand(querySenha, sqlConn);
            verificaSenha.Parameters.AddWithValue("@Nome", txtUsuario);

            // Execute o comando e armazene o resultado
            string resultSenha = Convert.ToString(verificaSenha.ExecuteScalar());

            sqlConn.Close();

            return resultSenha;
        }

        public List<Usuario> GetLstUsuarios()
        {
            List<Usuario> lstUsuarios = new List<Usuario>();

            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();

                string query = "SELECT Id, Nome FROM Usuarios";
                using (SqlCommand command = new SqlCommand(query, sqlConn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario usuario = new Usuario
                            {
                                Codigo = reader.GetInt32(reader.GetOrdinal("Id")),
                                Nome = reader.GetString(reader.GetOrdinal("Nome"))
                            };
                            lstUsuarios.Add(usuario);
                        }
                    }
                }
            }

            return lstUsuarios;
        }

        public void SetCadastroDb(string txtUsuarioCadastroDb, string txtSenhaCadastroDb)
        {
            sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();

            string queryInsert = "INSERT into Usuarios (Nome, Senha) values (@Usuario, @Senha)";
            SqlCommand InsertDb = new SqlCommand(queryInsert, sqlConn);
            InsertDb.Parameters.AddWithValue("@Usuario", txtUsuarioCadastroDb);
            InsertDb.Parameters.AddWithValue("@Senha", txtSenhaCadastroDb);

            InsertDb.ExecuteNonQuery();

            sqlConn.Close();
        }

<<<<<<< HEAD

=======
>>>>>>> desenvolvimento
        public void DeleteUsuario(int userId)
        {
            sqlConn = new SqlConnection(connectionString);
                sqlConn.Open();

                string query = "DELETE FROM Usuarios WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, sqlConn))
                {
                    cmd.Parameters.AddWithValue("@Id", userId);
                    cmd.ExecuteNonQuery();
                }

                sqlConn.Close(); 
        }

        public void Testando()
        {
            MessageBox.Show("apenas um teste");
        }
    }
}
