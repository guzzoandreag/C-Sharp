using SistemaCinema._Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCinema._Controller.DAL
{
    class DAL_dtoBilhete
    {
        //#################################################################################################################################
        //-- ATRIBUTOS DA CLASSE;
        _ConnectingDatabase connectingDB;
        //*********************************************************************************************************************************

        //#################################################################################################################################
        //-- CONSTRUTORES
        public DAL_dtoBilhete(_ConnectingDatabase localConnectingDB)
        {
            connectingDB = localConnectingDB; //-- Encapsulamento do Objeto de Conexão (Ctrl+R+E);
        }
        //*********************************************************************************************************************************

        //#################################################################################################################################
        //-- PROCEDIMENTOS E FUNÇÕES DA CLASSE;
        public void Insert(dtoBilhete bilhete)
        {
            SqlCommand commandSQL = new SqlCommand();
            commandSQL.Connection = connectingDB.ObjConnection;
            commandSQL.CommandText = "INSERT INTO BLT_00 VALUES(@BLT_FILME, @BLT_GENERO, @BLT_LINGUAGEM, @BLT_AUTOR, @BLT_VALOR, " +
                                     "@BLT_HORARIO, @BLT_DATA, @BLT_DISPONIBILIDADE, @BLT_SALA, @BLT_ENCARTE);";
            commandSQL.Parameters.AddWithValue("@BLT_FILME", bilhete.Blt_Filme);
            commandSQL.Parameters.AddWithValue("@BLT_GENERO", bilhete.Blt_Filme);
            commandSQL.Parameters.AddWithValue("@BLT_LINGUAGEM", bilhete.Blt_Filme);
            commandSQL.Parameters.AddWithValue("@BLT_AUTOR", bilhete.Blt_Filme);
            commandSQL.Parameters.AddWithValue("@BLT_VALOR", bilhete.Blt_Filme);
            commandSQL.Parameters.AddWithValue("@BLT_HORARIO", bilhete.Blt_Filme);
            commandSQL.Parameters.AddWithValue("@BLT_DATA", bilhete.Blt_Filme);
            commandSQL.Parameters.AddWithValue("@BLT_DISPONIBILIDADE", bilhete.Blt_Filme);
            commandSQL.Parameters.AddWithValue("@BLT_SALA", bilhete.Blt_Filme);
            commandSQL.Parameters.Add("@BLT_ENCARTE", SqlDbType.Image);
            if (bilhete.Blt_Encarte == null)
            {
                commandSQL.Parameters["@BLT_ENCARTE"].Value = DBNull.Value;
            }
            else
            {
                commandSQL.Parameters["@BLT_ENCARTE"].Value = bilhete.Blt_Encarte;
            }
            connectingDB.ObjConnection.Open();
            commandSQL.ExecuteNonQuery();
            connectingDB.ObjConnection.Close();
        }
        
        public void Update(dtoBilhete bilhete, int localBLT_CODIGO)
        {
            SqlCommand commandSQL = new SqlCommand();
            commandSQL.Connection = connectingDB.ObjConnection;
            commandSQL.CommandText = "UPDATE BLT_00 SET BLT_FILME = @BLT_FILME, BLT_GENERO = @BLT_GENERO, BLT_LINGUAGEM = @BLT_LINGUAGEM, " +
                                     "BLT_AUTOR = @BLT_AUTOR, BLT_VALOR = @BLT_VALOR, BLT_HORARIO = @BLT_HORARIO, BLT_DATA = @BLT_DATA, " +
                                     "BLT_DISPONIBILIDADE = @BLT_DISPONIBILIDADE, BLT_SALA = @BLT_SALA, BLT_ENCARTE = @BLT_ENCARTE  " +
                                     "WHERE BLT_CODIGO = @BLT_CODIGO";
            commandSQL.Parameters.AddWithValue("@BLT_FILME", bilhete.Blt_Filme);
            commandSQL.Parameters.AddWithValue("@BLT_GENERO", bilhete.Blt_Genero);
            commandSQL.Parameters.AddWithValue("@BLT_LINGUAGEM", bilhete.Blt_Linguagem);
            commandSQL.Parameters.AddWithValue("@BLT_AUTOR", bilhete.Blt_Autor);
            commandSQL.Parameters.AddWithValue("@BLT_VALOR", bilhete.Blt_Valor);
            commandSQL.Parameters.AddWithValue("@BLT_HORARIO", bilhete.Blt_Horario);
            commandSQL.Parameters.AddWithValue("@BLT_DATA", bilhete.Blt_Data);
            commandSQL.Parameters.AddWithValue("@BLT_DISPONIBILIDADE", bilhete.Blt_Disponibilidade);
            commandSQL.Parameters.AddWithValue("@BLT_SALA", bilhete.Blt_Sala);
            commandSQL.Parameters.AddWithValue("@BLT_ENCARTE", SqlDbType.Image);
            if (bilhete.Blt_Encarte == null)
            {
                commandSQL.Parameters["@BLT_ENCARTE"].Value = DBNull.Value;
            }
            else
            {
                commandSQL.Parameters["@BLT_ENCARTE"].Value = bilhete.Blt_Encarte;
            }
            commandSQL.Parameters.AddWithValue("@BLT_CODIGO", localBLT_CODIGO);
            connectingDB.ObjConnection.Open();
            commandSQL.ExecuteNonQuery();
            connectingDB.ObjConnection.Close();
        }
        //*********************************************************************************************************************************

        //#################################################################################################################################
        //-- DESTRUTORES
        ~DAL_dtoBilhete() { }
        //*********************************************************************************************************************************

    }
}
