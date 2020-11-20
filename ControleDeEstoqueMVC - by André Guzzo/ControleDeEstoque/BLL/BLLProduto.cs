using ControleDeEstoque.DAL;
using ControleDeEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.BLL
{
    class BLLProduto
    {
        ConexaoBD conexao;

        public BLLProduto(ConexaoBD cx)
        {
            conexao = cx;
        }

        public void Inserir(Produto produto)
        {
            if (produto.Descricao.Trim().Length == 0) 
            {
                throw new Exception("O campo descrição não foi preenchido!");
            }

            DALProduto objDAL = new DALProduto(conexao);
            objDAL.Inserir(produto);
        }

        public DataTable Pesquisar(string filtro)
        {
            if (false)
            {
                throw new Exception("");
            }
            DALProduto objDAL = new DALProduto(conexao);
            return objDAL.Pesquisar(filtro);
        }

    }
}
