using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lista_Tarefas
{
    public class Tarefas
    {
        public int Id { get; set; }
        public string Nome_tarefas { get; set; }
        public string Local { get; set; }
        public string Observacao { get; set; }

        public DateTime Data_limite { get; set; }


        public bool Cadastrar()
        {
            string comando = " INSERT INTO tarefas (nome_tarefa, local, observacao, data_limite) VALUES (@NOMETF, @LOCAL, @OBSERVACAO, @DATA)";
            Banco.BancoConexao conexaoBD = new Banco.BancoConexao();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@NOMETF", Nome_tarefas);
            cmd.Parameters.AddWithValue("@LOCAL", Local);
            cmd.Parameters.AddWithValue("@OBSERVACAO", Observacao);
            cmd.Parameters.AddWithValue("@DATA", Data_limite);

            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }

        public DataTable ListarTudo()
        {
            string comando = "SELECT * FROM tarefas";

            Banco.BancoConexao conexaoBD = new Banco.BancoConexao();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }

        public bool Editar()
        {
            string comando = "UPDATE tarefas  SET nome_tarefa = @NOMETF, local = @LOCAL, observacao = @OBSERVACAO, data_limite = @DATA " +
                "WHERE id = @id";

            Banco.BancoConexao conexaoBD = new Banco.BancoConexao();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@NOMETF", Nome_tarefas);
            cmd.Parameters.AddWithValue("@LOCAL", Local);
            cmd.Parameters.AddWithValue("@OBSERVACAO", Observacao);
            cmd.Parameters.AddWithValue("@DATA", Data_limite);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }

        }

        public bool Apagar()
        {
            string comando = "DELETE FROM tarefas WHERE id = @id";
            Banco.BancoConexao conexaoBD = new Banco.BancoConexao();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
    }
}
