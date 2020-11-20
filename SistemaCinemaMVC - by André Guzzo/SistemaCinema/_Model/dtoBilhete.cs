using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCinema._Model
{
    class dtoBilhete
    {
        //#################################################################################################################################
        //-- ATRIBUTOS DA CLASSE;
        int blt_Codigo;
        string blt_Filme;
        string blt_Genero;
        string blt_Linguagem;
        string blt_Autor;
        double blt_Valor;
        DateTime blt_Horario; //-- VERIFICAR TIPO SE ESTA CORRETO;
        DateTime blt_Data;    //-- VERIFICAR TIPO SE ESTA CORRETO;
        Int16 blt_Disponibilidade;
        Int16 blt_Sala;
        byte[] blt_Encarte;
        //*********************************************************************************************************************************

        //#################################################################################################################################
        //-- ENCAPSULAMENTOS DOS ATRIBUTOS DO OBJETO;
        public int Blt_Codigo { get => blt_Codigo; set => blt_Codigo = value; }
        public string Blt_Filme { get => blt_Filme; set => blt_Filme = value; }
        public string Blt_Genero { get => blt_Genero; set => blt_Genero = value; }
        public string Blt_Linguagem { get => blt_Linguagem; set => blt_Linguagem = value; }
        public string Blt_Autor { get => blt_Autor; set => blt_Autor = value; }
        public double Blt_Valor { get => blt_Valor; set => blt_Valor = value; }
        public DateTime Blt_Horario { get => blt_Horario; set => blt_Horario = value; }
        public DateTime Blt_Data { get => blt_Data; set => blt_Data = value; }
        public short Blt_Disponibilidade { get => blt_Disponibilidade; set => blt_Disponibilidade = value; }
        public short Blt_Sala { get => blt_Sala; set => blt_Sala = value; }
        public byte[] Blt_Encarte { get => blt_Encarte; set => blt_Encarte = value; }
        //*********************************************************************************************************************************

        //#################################################################################################################################
        //-- CONSTRUTORES
        public dtoBilhete() { }
        //*********************************************************************************************************************************

        //#################################################################################################################################
        //-- PROCEDIMENTOS E FUNÇÕES DA CLASSE;
        public void CarregaEncarte(string imgCaminho)
        {
            try
            {
                if (!string.IsNullOrEmpty(imgCaminho))
                {
                    FileInfo arqImagem = new FileInfo(imgCaminho);
                    FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);
                    this.Blt_Encarte = new byte[Convert.ToInt32(arqImagem.Length)];
                    int iBytesRead = fs.Read(this.Blt_Encarte, 0, Convert.ToInt32(arqImagem.Length));
                    fs.Close();
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message.ToString());
            }
        }
        //*********************************************************************************************************************************

        //#################################################################################################################################
        //-- DESTRUTORES
        ~dtoBilhete() { }
        //*********************************************************************************************************************************
    }
}
