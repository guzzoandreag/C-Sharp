using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.DAL
{
    class ConexaoBD
    {
        string str;
        SqlConnection objConexao;

        public string Str { get => str; set => str = value; }
        public SqlConnection ObjConexao { get => objConexao; set => objConexao = value; }

        public ConexaoBD(string dadosDaConexao)
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
