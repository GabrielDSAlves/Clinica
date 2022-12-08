using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProjetoClinico
{
    internal class PacienteDAO
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public PacienteDAO()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }
        public void Inserir(Paciente usuario)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO pacientes(Nome, CPF, Datanascimento, Cidade, Endereco, Numero, Bairro, Email, Telefone) VALUES(@Nome, @CPF, @Datanascimento, @Cidade, @Endereco, @Numero, @Bairro, @Email, @Telefone )";

            Cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
            Cmd.Parameters.AddWithValue("@CPF", usuario.Cpf);
            Cmd.Parameters.AddWithValue("@Datanascimento", usuario.Datanascimento);
            Cmd.Parameters.AddWithValue("@Cidade", usuario.Cidade);
            Cmd.Parameters.AddWithValue("@Endereco", usuario.Endereco);
            Cmd.Parameters.AddWithValue("@Numero", usuario.Numero);
            Cmd.Parameters.AddWithValue("@Bairro", usuario.Bairro);
            Cmd.Parameters.AddWithValue("@Email", usuario.Email);
            Cmd.Parameters.AddWithValue("@Telefone", usuario.Telefone);

            try
            {
                //Executa query definida acima.
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir usuario no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void Atualizar(Paciente usuarioatual)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"Update pacientes set Nome = @Nome, CPF = @CPF, Datanascimento = @Datanascimento, Cidade = @Cidade, Endereco = @Endereco, Numero = @Numero, Bairro = @Bairro, Email = @Email, Telefone = @Telefone WHERE Id = @id";

            Cmd.Parameters.AddWithValue("@Id", usuarioatual.Id);
            Cmd.Parameters.AddWithValue("@Nome", usuarioatual.Nome);
            Cmd.Parameters.AddWithValue("@CPF", usuarioatual.Cpf);
            Cmd.Parameters.AddWithValue("@Datanascimento", usuarioatual.Datanascimento);
            Cmd.Parameters.AddWithValue("@Cidade", usuarioatual.Cidade);
            Cmd.Parameters.AddWithValue("@Endereco", usuarioatual.Endereco);
            Cmd.Parameters.AddWithValue("@Numero", usuarioatual.Numero);
            Cmd.Parameters.AddWithValue("@Bairro", usuarioatual.Bairro);
            Cmd.Parameters.AddWithValue("@Email", usuarioatual.Email);
            Cmd.Parameters.AddWithValue("@Telefone", usuarioatual.Telefone);

            try
            {
                //Executa query definida acima.
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas na atualização do banco de dados usuario no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }


        public List<Paciente> ListarTodosUsuarios()
        {

            Cmd.Connection = Con.ReturnConnection();            

            Cmd.CommandText = "SELECT * FROM pacientes";

            List<Paciente> listaDeUsuarios = new List<Paciente>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    Paciente usuario = new Paciente((int)rd["id"], (string)rd["nome"],
                        (string)rd["cpf"], (string)rd["dataNascimento"],(string)rd["cidade"], (string)rd["endereco"], 
                        (string)rd["numero"], (string)rd["bairro"], (string)rd["email"], (string)rd["telefone"]);
                    listaDeUsuarios.Add(usuario);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

            return listaDeUsuarios;
        }




        public void Excluir(int IdUsuario)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE FROM pacientes WHERE Id = @id";
            Cmd.Parameters.AddWithValue("@id", IdUsuario);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch(Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public List<Paciente> ListarPAC(string consulta)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = consulta;

            List<Paciente> listaDeUsuarios = new List<Paciente>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Paciente usuario = new Paciente((int)rd["id"], (string)rd["nome"],
                        (string)rd["cpf"], (string)rd["dataNascimento"], (string)rd["cidade"], (string)rd["endereco"],
                        (string)rd["numero"], (string)rd["bairro"], (string)rd["email"], (string)rd["telefone"]);
                    listaDeUsuarios.Add(usuario);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

            return listaDeUsuarios;
        }


    }
}
