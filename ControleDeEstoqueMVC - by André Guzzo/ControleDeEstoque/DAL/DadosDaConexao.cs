﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.DAL
{
    class DadosDaConexao
    {
        static string servidor = @".\SQLEXPRESS";
        static string banco = "dbControleDeEstoque";
        //static string usuario = "sa";
        //static string senha = "sql2017";

        public static string StringDeConexao
        {
            get
            {
                return @"Data Source="+servidor+";Initial Catalog="+banco+";Integrated Security=True";

                //return @"Data Source ="+servidor+"; Initial Catalog = "+banco+"; User ID = "+usuario+"; Password = "+senha+"";
            }
        }
    }
}
