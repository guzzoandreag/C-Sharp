using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCinema._Controller.DAL
{
    class __LinkConnection
    {
        //#################################################################################################################################
        //-- ATRIBUTOS DA CLASSE;
        static string host;
        static string database;
        static string user;
        static string password;
        //*********************************************************************************************************************************

        //#################################################################################################################################
        //-- ENCAPSULAMENTOS DOS ATRIBUTOS DO OBJETO;
        public static string Host { get => host; set => host = value; }
        public static string Database { get => database; set => database = value; }
        public static string User { get => user; set => user = value; }
        public static string Password { get => password; set => password = value; }
        //*********************************************************************************************************************************

        //#################################################################################################################################
        //-- CONSTRUTORES
        public __LinkConnection()
        {
            Host = @".\SQLEXPRESS";
            Database = @"zzDB_SISTEMA_CINEMA";
            User = @"sa";
            Password = @"Neski5500*";
        }
        //*********************************************************************************************************************************

        //#################################################################################################################################
        //-- PROCEDIMENTOS E FUNÇÕES DA CLASSE;
        public static string StringConnection()
        {
            return @"Data Source =" + Host + "; Initial Catalog = " + Database + "; User ID = " + User + "; Password = " + Password + "";
        }
        //*********************************************************************************************************************************

        //#################################################################################################################################
        //-- DESTRUTORES
        ~__LinkConnection() { }
        //*********************************************************************************************************************************
    }
}
