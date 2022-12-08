using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;


namespace ProjetoClinico
{
    internal class FuncionarioDAO
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public FuncionarioDAO()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }

        public SqlDataReader rd;
        public bool Login(string email, string senha, string cargo)
        {
            bool vdd = false, tem = false;
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"SELECT * FROM funcionarios WHERE Email_Func = @Email AND Cargo_func = @cargo";
            Cmd.Parameters.AddWithValue("@Email", email);
            Cmd.Parameters.AddWithValue("@cargo", cargo);

            DataTable dt = new DataTable();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(Cmd);
                da.Fill(dt);
                da.Dispose();

                string senhaveri = "";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    senhaveri = dt.Rows[i]["Senha_Func"].ToString();
                }

                if (!(senhaveri == ""))
                    vdd = BCrypt.Net.BCrypt.Verify(senha, senhaveri);

                rd = Cmd.ExecuteReader();
                if (vdd)
                {
                    if (rd.HasRows)
                        tem = true;
                }

            }
            catch (SqlException err)
            {
                throw new Exception("Erro: Problemas no banco de dados.\n" + err.Message);
            }
            rd.Close();

            return tem;
        }



        public void Inserir(Funcionario usuario)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO funcionarios(Nome_Func, CPF_Func, Datanascimento_Func, Cidade_Func, Endereco_Func, Numero_Func, Bairro_Func, Email_Func, Telefone_Func, Senha_Func, Cargo_func) VALUES(@Nome, @CPF, @Datanascimento, @Cidade, @Endereco, @Numero, @Bairro, @Email, @Telefone, @Senha, @cargo)";

            Cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
            Cmd.Parameters.AddWithValue("@CPF", usuario.Cpf);
            Cmd.Parameters.AddWithValue("@Datanascimento", usuario.Datanascimento);
            Cmd.Parameters.AddWithValue("@Cidade", usuario.Cidade);
            Cmd.Parameters.AddWithValue("@Endereco", usuario.Endereco);
            Cmd.Parameters.AddWithValue("@Numero", usuario.Numero);
            Cmd.Parameters.AddWithValue("@Bairro", usuario.Bairro);
            Cmd.Parameters.AddWithValue("@Email", usuario.Email);
            Cmd.Parameters.AddWithValue("@Telefone", usuario.Telefone);
            Cmd.Parameters.AddWithValue("@Senha", usuario.Senha);
            Cmd.Parameters.AddWithValue("@cargo", usuario.Cargo);

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

        public void Atualizar(Funcionario usuarioatual)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"Update funcionarios set Nome_Func = @Nome, CPF_Func = @CPF, Datanascimento_Func = @Datanascimento, Cidade_Func = @Cidade, Endereco_Func = @Endereco, Numero_Func = @Numero, Bairro_Func = @Bairro, Email_Func = @Email, Telefone_Func = @Telefone, Cargo_func = @cargo WHERE ID_Func = @id";

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
            Cmd.Parameters.AddWithValue("@cargo", usuarioatual.Cargo);

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


        public List<Funcionario> ListarTodosUsuarios()
        {

            Cmd.Connection = Con.ReturnConnection();            

            Cmd.CommandText = "SELECT * FROM funcionarios";

            List<Funcionario> listaDeUsuarios = new List<Funcionario>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    Funcionario usuario = new Funcionario((int)rd["ID_Func"], (string)rd["Nome_Func"],
                        (string)rd["CPF_Func"], (string)rd["Datanascimento_Func"],(string)rd["Cidade_Func"], (string)rd["Endereco_Func"], 
                        (string)rd["Numero_Func"], (string)rd["Bairro_Func"], (string)rd["Email_Func"], (string)rd["Telefone_Func"], (string)rd["Senha_Func"], (string)rd["Cargo_func"]);
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
            Cmd.CommandText = @"DELETE FROM funcionarios WHERE ID_Func = @id";
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


        public List<Funcionario> ListarFUC(string consulta)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = consulta;

            List<Funcionario> listaDeUsuarios = new List<Funcionario>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Funcionario usuario = new Funcionario((int)rd["ID_Func"], (string)rd["Nome_Func"],
                        (string)rd["CPF_Func"], (string)rd["Datanascimento_Func"], (string)rd["Cidade_Func"], (string)rd["Endereco_Func"],
                        (string)rd["Numero_Func"], (string)rd["Bairro_Func"], (string)rd["Email_Func"], (string)rd["Telefone_Func"], (string)rd["Senha_Func"], (string)rd["Cargo_func"]);
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
