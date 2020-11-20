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
            if (produto.CodigoBarras.Trim().Length != 9)
            {
                throw new Exception("O campo Codigo de Barras deve possuir 9 caracteres!");
            }
            if (Validador.ETexto(produto.Descricao))
            {
                throw new Exception("Não é permitido valores numéricos no campo descrição.!");
            }

            DALProduto objDAL = new DALProduto(conexao);
            objDAL.Inserir(produto);
        }

        public DataTable Pesquisar(string filtro)
        {
            int ENumero()                                   /**/
            {                                               /**/
                int cont = 0;                               /**/
                char[] caracteres = filtro.ToCharArray();   /**/
                                                            /**/
                foreach (var caracter in caracteres)        /**/
                {                                           /**/
                    if (char.IsDigit(caracter))             /**/
                    {                                       /**/
                        cont++;                             /**/
                    }                                       /**/
                }                                           /**/
                return cont;                                /**/
            }                                               /**/

            if (ENumero() == filtro.Length && ENumero() != 0)               /*     Para     */
            {                                                               /*    Testar    */
                throw new Exception("Este campo não pode ser numérico!");   /*  Validações  */
            }                                                               /*              */
            DALProduto objDAL = new DALProduto(conexao);
            return objDAL.Pesquisar(filtro);
        }

        public Produto Carregar(int cod)
        {
            if (false)                     /*     Para     */
            {                              /*    Testar    */
                throw new Exception("");   /*  Validações  */
            }                              /*              */
            DALProduto objDAL = new DALProduto(conexao);
            return objDAL.Carregar(cod);
        }

        public void Editar(Produto produto, int cod_id)
        {
            if (false)                     /*     Para     */
            {                              /*    Testar    */
                throw new Exception("");   /*  Validações  */
            }                              /*              */
            DALProduto objDAL = new DALProduto(conexao);
            objDAL.Editar(produto, cod_id);
        }
    }
}
