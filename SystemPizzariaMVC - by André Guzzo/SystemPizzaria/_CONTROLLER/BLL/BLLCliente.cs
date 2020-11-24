using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SystemPizzaria._CONTROLLER.DAL;
using SystemPizzaria._MODAL;
using System.Data;

namespace SystemPizzaria._CONTROLLER.BLL
{
    class BLLCliente
    {
        DALConexao conexao;

        public BLLCliente(DALConexao cx)
        {
            conexao = cx;
        }

        public void Inserir(Cliente cliente)
        {
            if (cliente.Cli_Telefone.Trim().Length != 15)
            {
                throw new Exception("O telefone deve conter 11 digitos(DDD+Número)!!");
            }

            DALCliente objDAL = new DALCliente(conexao);
            objDAL.Inserir(cliente);
        }

        
        public DataTable Pesquisar(string filtro)
        {
            if (false)
            {
                throw new Exception("");
            }
            DALCliente objDAL = new DALCliente(conexao);
            return objDAL.Pesquisar(filtro);
        }
        
        public Cliente Carregar(int cod)
        {
            if (false)
            {
                throw new Exception("");
            }
            DALCliente objDAL = new DALCliente(conexao);
            return objDAL.Carregar(cod);
        }

        /*
        public void Atualizar(Sessao sessao, int id)
        {
            if (false)
            {
                throw new Exception("");
            }

            DALSessao objDAL = new DALSessao(conexao);
            objDAL.Atualizar(sessao, id);
        }

        public void Excluir(int id)
        {
            if (false)
            {
                throw new Exception("");
            }

            DALSessao objDAL = new DALSessao(conexao);
            objDAL.Excluir(id);
        }
        */
    }
}
