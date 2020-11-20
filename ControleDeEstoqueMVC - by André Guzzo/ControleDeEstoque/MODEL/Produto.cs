using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ControleDeEstoque.MODEL
{
    class Produto
    {
        int id;
        string descricao;
        byte[] foto;
        string codigoBarras;
        int qtde;
        double valorUnitario;

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public byte[] Foto { get => foto; set => foto = value; }
        public string CodigoBarras { get => codigoBarras; set => codigoBarras = value; }
        public int Qtde { get => qtde; set => qtde = value; }
        public double ValorUnitario { get => valorUnitario; set => valorUnitario = value; }

        public Produto() { }

        public void CarregarImagem(string imgCaminho)
        {
            try
            {
                if (!string.IsNullOrEmpty(imgCaminho))
                {
                    FileInfo arqImagem = new FileInfo(imgCaminho);
                    FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);
                    this.Foto = new byte[Convert.ToInt32(arqImagem.Length)];
                    int iBytesRead = fs.Read(this.Foto, 0, Convert.ToInt32(arqImagem.Length));
                    fs.Close();
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message.ToString());
            }
        }

        ~Produto() { }
    }
}
