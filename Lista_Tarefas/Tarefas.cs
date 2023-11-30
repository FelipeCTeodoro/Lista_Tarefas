using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Tarefas
{
    public class Tarefas
    {
        public string Nome_tarefas { get; set; }
        public string Local{ get;}
        public string Observacao { get; set; }

        public  DateTime Data_limite { get; set; }


        public bool Cadastrar()
        {
            string comando = " INSERT INTO tarefas (@nome_tarefa, @local, @observacao, @data_limite)";
            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome_completo", Nome_completo);
            cmd.Parameters.AddWithValue("@cpf", Cpf);
            cmd.Parameters.AddWithValue("@telefone", Telefone.Telefones);

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
