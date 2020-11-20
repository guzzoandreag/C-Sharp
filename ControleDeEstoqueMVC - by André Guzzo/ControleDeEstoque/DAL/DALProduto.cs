using ControleDeEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.DAL
{
    class DALProduto
    {
        ConexaoBD conexao;

        public DALProduto(ConexaoBD cx)
        {
            conexao = cx;
        }

        public void Inserir(Produto produto)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjConexao;
            cmd.CommandText = "INSERT INTO tbl_Produtos VALUES(@codBarras, @desc, @foto, @qtde, @valorUnit); SELECT @@IDENTITY;";
            cmd.Parameters.AddWithValue("@codBarras", produto.CodigoBarras);
            cmd.Parameters.AddWithValue("@desc", produto.Descricao);
            //#############################################################
            cmd.Parameters.Add("@foto", SqlDbType.Image);
            if (produto.Foto == null)
            {
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@foto"].Value = produto.Foto;
            }
            //#############################################################
            cmd.Parameters.AddWithValue("@qtde", produto.Qtde);
            cmd.Parameters.AddWithValue("@valorUnit", produto.ValorUnitario);
            conexao.Conectar();
            produto.Id = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public DataTable Pesquisar(string filtro)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_Produtos WHERE descricao LIKE '%" + filtro + "%'", DadosDaConexao.StringDeConexao);
            da.Fill(tabela);
            return tabela;
        }


    }
}
