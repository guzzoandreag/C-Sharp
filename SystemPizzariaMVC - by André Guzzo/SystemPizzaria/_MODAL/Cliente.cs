using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemPizzaria._MODAL
{
    class Cliente
    {
        int cli_Id;
        string cli_Telefone;
        string cli_Nome;
        string cli_Cep;
        string cli_Logradouro;
        string cli_Bairro;
        string cli_PontoReferencia;
        double cli_PercentualEncargos;
        bool cli_ConcederDescontoNoPreco;

        public Cliente() { }

        public int Cli_Id { get => cli_Id; set => cli_Id = value; }
        public string Cli_Telefone { get => cli_Telefone; set => cli_Telefone = value; }
        public string Cli_Nome { get => cli_Nome; set => cli_Nome = value; }
        public string Cli_Cep { get => cli_Cep; set => cli_Cep = value; }
        public string Cli_Logradouro { get => cli_Logradouro; set => cli_Logradouro = value; }
        public string Cli_Bairro { get => cli_Bairro; set => cli_Bairro = value; }
        public string Cli_PontoReferencia { get => cli_PontoReferencia; set => cli_PontoReferencia = value; }
        public double Cli_PercentualEncargos { get => cli_PercentualEncargos; set => cli_PercentualEncargos = value; }
        public bool Cli_ConcederDescontoNoPreco { get => cli_ConcederDescontoNoPreco; set => cli_ConcederDescontoNoPreco = value; }

        ~Cliente() { }

    }
}
