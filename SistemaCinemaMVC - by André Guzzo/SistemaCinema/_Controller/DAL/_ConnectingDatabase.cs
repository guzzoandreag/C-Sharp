using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCinema._Controller.DAL
{
    class _ConnectingDatabase
    {
        //#################################################################################################################################
        //-- ATRIBUTOS DA CLASSE;
        string StringConnection;
        SqlConnection objConnection;
        //*********************************************************************************************************************************

        //#################################################################################################################################
        //-- ENCAPSULAMENTOS DOS ATRIBUTOS DO OBJETO;
        public string StringConnection1 { get => StringConnection; set => StringConnection = value; }
        public SqlConnection ObjConnection { get => objConnection; set => objConnection = value; }
        //*********************************************************************************************************************************

        //#################################################################################################################################
        //-- CONSTRUTORES
        public _ConnectingDatabase(string strConnection)
        {
            StringConnection = strConnection;
            ObjConnection = new SqlConnection(StringConnection);
        }
        //*********************************************************************************************************************************

        //#################################################################################################################################
        //-- PROCEDIMENTOS E FUNÇÕES DA CLASSE;
        //
        //
        //*********************************************************************************************************************************

        //#################################################################################################################################
        //-- DESTRUTORES
        ~_ConnectingDatabase() { }
        //*********************************************************************************************************************************
    }
}
