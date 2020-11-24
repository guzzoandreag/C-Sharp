using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace SystemPizzaria._CONTROLLER.DAL
{
    class DALConexao
    {
        string str;
        SqlConnection objConexao;

        public string Str { get => str; set => str = value; }
        public SqlConnection ObjConexao { get => objConexao; set => objConexao = value; }

        public DALConexao(string dadosDaConexao)
        {
            Str = dadosDaConexao;
            ObjConexao = new SqlConnection(Str);
        }

        public void Conectar()
        {
            ObjConexao.Open();
        }

        public void Desconectar()
        {
            ObjConexao.Close();
        }
    }
}
