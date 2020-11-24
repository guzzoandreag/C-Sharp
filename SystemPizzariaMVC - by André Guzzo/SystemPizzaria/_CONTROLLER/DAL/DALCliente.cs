using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SystemPizzaria._MODAL;
using System.Data.SqlClient;
using System.Data;

namespace SystemPizzaria._CONTROLLER.DAL
{
    class DALCliente
    {
        DALConexao conexao;

        public DALCliente(DALConexao cx)
        {
            conexao = cx;
        }

        public void Inserir(Cliente cliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjConexao;
            cmd.CommandText = "INSERT INTO TBL_CLIENTES VALUES(@CLI_TELEFONE, @CLI_NOME, @CLI_CEP, @CLI_LOGRADOURO, @CLI_BAIRRO, @CLI_PONTOREFERENCIA, @CLI_PERCENTUALENCARGOS, @CLI_CONCEDERDESCONTONOPRECO)";
            cmd.Parameters.AddWithValue("@CLI_TELEFONE", cliente.Cli_Telefone);
            cmd.Parameters.AddWithValue("@CLI_NOME", cliente.Cli_Nome);
            cmd.Parameters.AddWithValue("@CLI_CEP", cliente.Cli_Cep);
            cmd.Parameters.AddWithValue("@CLI_LOGRADOURO", cliente.Cli_Logradouro);
            cmd.Parameters.AddWithValue("@CLI_BAIRRO", cliente.Cli_Bairro);
            cmd.Parameters.AddWithValue("@CLI_PONTOREFERENCIA", cliente.Cli_PontoReferencia);
            cmd.Parameters.AddWithValue("@CLI_PERCENTUALENCARGOS", cliente.Cli_PercentualEncargos);
            cmd.Parameters.AddWithValue("@CLI_CONCEDERDESCONTONOPRECO",cliente.Cli_ConcederDescontoNoPreco);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Pesquisar(string filtro)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_CLIENTES WHERE CLI_TELEFONE LIKE '%" + filtro + "%'", DadosDaConexao.StringDeConexao);
            da.Fill(tabela);
            return tabela;
        }
        
        public Cliente Carregar(int cod)
        {
            Cliente cliente = new Cliente();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjConexao;
            cmd.CommandText = "SELECT * FROM TBL_CLIENTES WHERE CLI_ID = @cod";
            cmd.Parameters.AddWithValue("@cod", cod);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                cliente.Cli_Telefone = registro["CLI_TELEFONE"].ToString();
                cliente.Cli_Nome = registro["CLI_NOME"].ToString();
                cliente.Cli_Cep = registro["CLI_CEP"].ToString();
                cliente.Cli_Logradouro = registro["CLI_LOGRADOURO"].ToString();
                cliente.Cli_Bairro = registro["CLI_BAIRRO"].ToString();
                cliente.Cli_PontoReferencia = registro["CLI_PONTOREFERENCIA"].ToString();
                cliente.Cli_PercentualEncargos = Convert.ToDouble(registro["CLI_PERCENTUALENCARGOS"]);
                cliente.Cli_ConcederDescontoNoPreco = Convert.ToBoolean(registro["CLI_CONCEDERDESCONTONOPRECO"]);
            }
            conexao.Desconectar();
            return cliente;
        }

        /*
        public void Atualizar(Pedidos pedido, int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjConexao;
            cmd.CommandText = "UPDATE tbl_sessao SET descricao = @descricao, genero = @genero, linguagem = @linguagem, autor = @autor, valor = @valor, horario = @horario, dt_filme = @data, disponibilidade = @disponibilidade, ambiente = @ambiente, foto = @foto WHERE id = @cod";
            cmd.Parameters.AddWithValue("@descricao", sessao.Descricao);
            cmd.Parameters.AddWithValue("@genero", sessao.Genero);
            cmd.Parameters.AddWithValue("@linguagem", sessao.Linguagem);
            cmd.Parameters.AddWithValue("@autor", sessao.Autor);
            cmd.Parameters.AddWithValue("@valor", sessao.Valor);
            cmd.Parameters.AddWithValue("@horario", sessao.Horario);
            cmd.Parameters.AddWithValue("@data", sessao.Data);
            cmd.Parameters.AddWithValue("@disponibilidade", sessao.Disponibilidade);
            cmd.Parameters.AddWithValue("@ambiente", sessao.Ambiente);
            //#############################################################
            cmd.Parameters.Add("@foto", SqlDbType.Image);
            if (sessao.Foto == null)
            {
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@foto"].Value = sessao.Foto;
            }
            //#############################################################
            cmd.Parameters.AddWithValue("@cod", id);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjConexao;
            cmd.CommandText = "DELETE FROM tbl_sessao WHERE id = @cod";
            cmd.Parameters.AddWithValue("@cod", id);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
    */
    }
}
