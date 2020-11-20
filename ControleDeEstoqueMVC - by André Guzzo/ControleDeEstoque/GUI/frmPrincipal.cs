using ControleDeEstoque.BLL;
using ControleDeEstoque.DAL;
using ControleDeEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeEstoque
{
    public partial class frmPrincipal : Form
    {
        string opcao = "";
        string fotoCaminho = "";

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            opcao = "inserir";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (opcao == "inserir")
            {
                Produto produto = new Produto();
                produto.Descricao = txtDescricao.Text;
                if (fotoCaminho == "")
                {
                    produto.Foto = null;
                }
                else
                {
                    produto.CarregarImagem(fotoCaminho);
                }
                produto.CodigoBarras = txtCodigoBarras.Text;
                produto.Qtde = Convert.ToInt32(txtQtde.Text);
                produto.ValorUnitario = Convert.ToDouble(txtValorUnitario.Text);

                ConexaoBD conexao = new ConexaoBD(DadosDaConexao.StringDeConexao);
                BLLProduto objBLL = new BLLProduto(conexao);
                objBLL.Inserir(produto);
                MessageBox.Show("Produto cadastrado com sucesso!");
            }
        }

        private void btnSelecionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (!string.IsNullOrEmpty(ofd.FileName))
            {
                fotoCaminho = ofd.FileName;
                pbFoto.Load(fotoCaminho);
            }
        }


        private void btnLimparFoto_Click(object sender, EventArgs e)
        {
            pbFoto.Image = null;
            fotoCaminho = "";
        }

        public void FormatarDGV()
        {
            dgvSituacaoEstoque.Columns[1].HeaderText = "Código de Barras";
            dgvSituacaoEstoque.Columns[2].HeaderText = "Descrição";
            dgvSituacaoEstoque.Columns[4].HeaderText = "Quantidade";
            dgvSituacaoEstoque.Columns[5].HeaderText = "Valor Unitário";

            dgvSituacaoEstoque.Columns[0].Visible = false;
            dgvSituacaoEstoque.Columns[3].Visible = false;

            dgvSituacaoEstoque.Columns[2].Width = 150;

            dgvSituacaoEstoque.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ConexaoBD conexao = new ConexaoBD(DadosDaConexao.StringDeConexao);
            BLLProduto objBLL = new BLLProduto(conexao);
            dgvSituacaoEstoque.DataSource = objBLL.Pesquisar(txtPesquisar.Text);

            FormatarDGV();
        }

    }
}
