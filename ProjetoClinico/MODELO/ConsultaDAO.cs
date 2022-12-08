using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;


namespace ProjetoClinico
{
    internal class ConsultaDAO
    {

        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public ConsultaDAO()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }
        public void Inserir(Consultar usuario)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO consulta(DataAtual_Consulta, DataMarcada_Consulta, HoraInicio_Consulta, HoraFim_Consulta, ID_Func, ID_Pac, ID_Dent) VALUES(@dataatual, @datamarcada, @horainicio, @horafim, @idfunc, @idpac, @iddent)";

            Cmd.Parameters.AddWithValue("@dataatual", usuario.DataAtual);
            Cmd.Parameters.AddWithValue("@datamarcada", usuario.DataMarcada);
            Cmd.Parameters.AddWithValue("@horainicio", usuario.Horainicio);
            Cmd.Parameters.AddWithValue("@horafim", usuario.HoraFim);
            Cmd.Parameters.AddWithValue("@idfunc", usuario.IdFunc);
            Cmd.Parameters.AddWithValue("@idpac", usuario.IdPac);
            Cmd.Parameters.AddWithValue("@iddent", usuario.IdDent);


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

        
        public List<ConsultaJoin> ListarTodosUsuarios()
        {

            Cmd.Connection = Con.ReturnConnection();

            Cmd.CommandText = @"SELECT 
            consulta.ID_Consulta            ,
            consulta.DataAtual_Consulta     ,
            consulta.DataMarcada_Consulta   ,
            consulta.HoraInicio_Consulta    ,
            consulta.HoraFim_Consulta       ,
            pacientes.Nome                  ,
            funcionarios.Nome_Func          ,
            DENTISTA.Nome_Dent
            FROM consulta LEFT JOIN pacientes
            ON consulta.ID_Pac = pacientes.ID
            LEFT JOIN funcionarios ON consulta.ID_Func = funcionarios.ID_Func
            LEFT JOIN DENTISTA ON consulta.ID_Dent = DENTISTA.ID_Dent";

            List<ConsultaJoin> listaDeUsuarios = new List<ConsultaJoin>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    ConsultaJoin usuario = new ConsultaJoin((int)rd["ID_Consulta"], (string)rd["DataAtual_Consulta"],
                        (string)rd["DataMarcada_Consulta"], (string)rd["HoraInicio_Consulta"], (string)rd["HoraFim_Consulta"], (string)rd["Nome"],
                        (string)rd["Nome_Func"], (string)rd["Nome_Dent"]);
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
            Cmd.CommandText = @"DELETE FROM consulta WHERE ID_Consulta = @id";
            Cmd.Parameters.AddWithValue("@id", IdUsuario);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public List<ConsultaJoin> ListarCON(string str)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = $@"SELECT 
            consulta.ID_Consulta            ,
            consulta.DataAtual_Consulta     ,
            consulta.DataMarcada_Consulta   ,
            consulta.HoraInicio_Consulta    ,
            consulta.HoraFim_Consulta       ,
            pacientes.Nome                  ,
            funcionarios.Nome_Func          ,
            DENTISTA.Nome_Dent
            FROM consulta LEFT JOIN pacientes
            ON consulta.ID_Pac = pacientes.ID
            LEFT JOIN funcionarios ON consulta.ID_Func = funcionarios.ID_Func
            LEFT JOIN DENTISTA ON consulta.ID_Dent = DENTISTA.ID_Dent
            WHERE pacientes.Nome like '%{str}%' or funcionarios.Nome_Func like '%{str}%' or DENTISTA.Nome_Dent like '%{str}%'";

            List<ConsultaJoin> listaDeUsuarios = new List<ConsultaJoin>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    ConsultaJoin usuario = new ConsultaJoin((int)rd["ID_Consulta"], (string)rd["DataAtual_Consulta"],
                        (string)rd["DataMarcada_Consulta"], (string)rd["HoraInicio_Consulta"], (string)rd["HoraFim_Consulta"], (string)rd["Nome"],
                        (string)rd["Nome_Func"], (string)rd["Nome_Dent"]);
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
