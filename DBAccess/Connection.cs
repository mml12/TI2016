using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess
{
    public class Connection
    {
        static MySqlConnection conectar;

        public static MySqlConnection Connect
        {
            get { return conectar; }
            set { conectar = value; }
        }

        public static String CreateConnection(string user, string password, string database)
        {
            // verificando se existe uma conexão, fecha esta conexão
            if (conectar != null)
            {
                conectar.Close();
            }

            // serve para configurar os parametros do banco de dados
            string configuracao = string.Format("server={0};user id={1}; password={2};database=mysql; pooling=false", "127.0.0.1", user, password);

            // tenta estabelecer conectar
            try
            {
                conectar = new MySqlConnection(configuracao);
                conectar.Open();
            }// caso não consiga exibe erro de conexão
            catch (MySqlException erro)
            {
                return ("Erro ao conectar " + erro);
            }

            // criar um banco em branco na memória
            MySqlDataReader banco = null;

            // fazer uso do banco escolhido
            MySqlCommand usar = new MySqlCommand("use " + database, conectar);

            // tenta criar o banco
            try
            {
                banco = usar.ExecuteReader();
            }// caso ocorra erro
            catch (MySqlException erro)
            {
                return ("Failed to populate database list: " + erro);
            }// no fim fecha
            finally
            {
                if (banco != null)
                {
                    banco.Close();
                }
            }

            return ("Connected");
        }
    }
}
