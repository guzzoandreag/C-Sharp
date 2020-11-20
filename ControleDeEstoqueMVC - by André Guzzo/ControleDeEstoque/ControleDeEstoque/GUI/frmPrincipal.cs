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
using System.IO;
using System.Net.NetworkInformation;

namespace ControleDeEstoque
{
    public partial class frmPrincipal : Form
    {
        string opcao = "";
        string fotoCaminho = "";
        int cod = 0;

        public frmPrincipal()
        {
            InitializeComponent();
            opcao = "inicializar";
            FormatarComponentes();
        }

        public void FormatarComponentes()
        {
            if (opcao == "inicializar")
            {
                txtDescricao.Enabled = false;          /*-------------------*/
                txtDescricao.ResetText();              /*                   */
                txtCodigoBarras.Enabled = false;       /*                   */
                txtCodigoBarras.ResetText();           /*                   */
                txtQtde.Enabled = false;               /*     Definindo     */
                txtQtde.ResetText();                   /*       padrão      */
                txtValorUnitario.Enabled = false;      /*         de        */
                txtValorUnitario.ResetText();          /*   inicialização   */
                btnCancelar.Enabled = false;           /*        dos        */
                btnEditar.Enabled = false;             /*    componentes    */
                btnExcluir.Enabled = false;            /*      visuais      */
                btnSalvar.Enabled = false;             /*        ao         */
                btnSelecionarFoto.Enabled = false;     /*     executar      */
                btnLimparFoto.Enabled = false;         /*     o sistema     */
                btnInserir.Enabled = true;             /*     e quando      */
                btnSair.Enabled = true;                /*     chamado.      */
                txtPesquisar.Enabled = true;           /*                   */
                txtPesquisar.ResetText();              /*                   */
                btnPesquisar.Enabled = true;           /*                   */
                pbFoto.Image = null;                   /*-------------------*/
                for (int i = 0; i < dgvSituacaoEstoque.RowCount; i++)          /*----------------*/
                {                                                              /*  Limpando DGV  */
                    dgvSituacaoEstoque.Rows[i].DataGridView.Columns.Clear();   /* (DataGridView) */
                }                                                              /*----------------*/

            }                                                                  
            if (opcao == "inserir")                   /*-------------------*/                         
            {                                         /*                   */
                txtDescricao.Enabled = true;          /*     Definindo     */
                txtCodigoBarras.Enabled = true;       /*       padrão      */
                txtQtde.Enabled = true;               /*                   */
                txtQtde.Text = "0";                   /*  de inserção nos  */
                txtValorUnitario.Enabled = true;      /*    componentes    */
                txtValorUnitario.Text = "0,00";       /*                   */
                btnCancelar.Enabled = true;           /*      visuais      */
                btnSalvar.Enabled = true;             /*   quando estiver  */
                btnSelecionarFoto.Enabled = true;     /*em modo de inserção*/
                btnLimparFoto.Enabled = true;         /*        ou         */
                txtPesquisar.Enabled = false;         /*  quando chamado   */
                btnPesquisar.Enabled = false;         /*     a função.     */
                btnSair.Enabled = false;              /*                   */
                btnInserir.Enabled = false;           /*                   */
                txtDescricao.Focus();                 /*                   */
            }                                         /*-------------------*/

            if (opcao == "editar")                    /*-------------------*/
            {                                         /*                   */
                btnSalvar.Enabled = true;             /*     Definindo     */
                btnEditar.Enabled = false;            /*       padrão      */
                btnInserir.Enabled = false;           /*   de edição nos   */
                btnCancelar.Enabled = true;           /*    componentes    */
                btnPesquisar.Enabled = false;         /*      visuais      */
                txtPesquisar.Enabled = false;         /*   quando estiver  */
                txtDescricao.Enabled = true;          /* em modo de edição */
                txtCodigoBarras.Enabled = true;       /*        ou         */
                txtQtde.Enabled = true;               /*  quando chamado   */
                txtValorUnitario.Enabled = true;      /*     a função.     */
                btnSelecionarFoto.Enabled = true;     /*                   */
                btnLimparFoto.Enabled = true;         /*-------------------*/
            }
        }

        public void FormatarDGV() /*-<<- Metodo de configuração visual do dgv(DataGridView). */
        {
            dgvSituacaoEstoque.Columns[0].HeaderText = "Código";         /*----------------------*/
            dgvSituacaoEstoque.Columns[1].HeaderText = "Cód. Barras";    /*                      */
            dgvSituacaoEstoque.Columns[2].HeaderText = "Descrição";      /* Definição de Título  */
            dgvSituacaoEstoque.Columns[3].HeaderText = "Foto";           /* do dgv(DataGridView) */
            dgvSituacaoEstoque.Columns[4].HeaderText = "Qtd";            /*                      */
            dgvSituacaoEstoque.Columns[5].HeaderText = "Valor Uni.";     /*----------------------*/

            dgvSituacaoEstoque.RowHeadersVisible = false;      /*-<<- Parametro do dgv(DataGridView) para não mostrar coluna de movimentação. */
            dgvSituacaoEstoque.Columns[0].Visible = false;  /*-<<- Ocultar uma Coluna. */
            dgvSituacaoEstoque.Columns[3].Visible = false;  /*-<<- Ocultar uma Coluna. */

            dgvSituacaoEstoque.Columns["cod_barras"].Width = 55;    /*-----------------------------*/
            dgvSituacaoEstoque.Columns[2].Width = 180;              /* Definindo Largura da Coluna */
            dgvSituacaoEstoque.Columns["qtde"].Width = 25;          /*    do dgv(DataGridView)     */
            dgvSituacaoEstoque.Columns[5].Width = 65;               /*-----------------------------*/

            dgvSituacaoEstoque.Columns["cod_barras"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;   /*--------------------------------*/
            dgvSituacaoEstoque.Columns["qtde"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;         /* Alinhamento do Texto na Celula */
            dgvSituacaoEstoque.Columns["vr_unitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  /*--------------------------------*/

            dgvSituacaoEstoque.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);       /*-<<- Formatar Título do DataGridView(Configurações de Fonte). */

            dgvSituacaoEstoque.GridColor = Color.BlueViolet;        /*-<<- Alterar a Cor da Linha de Grade do dgv(DataGridView). */

            dgvSituacaoEstoque.DefaultCellStyle.Font = new Font("Arial", 11);       /*-<<- Especificar a Fonte dos registros do dgv(DataGridView). */

            dgvSituacaoEstoque.DefaultCellStyle.ForeColor = Color.Blue;     /*-<<- Especificar as Cores da Fonte dos registros do dgv(DataGridView). */
            dgvSituacaoEstoque.DefaultCellStyle.BackColor = Color.Beige;        /*-<<- Especificar as Cores do fundo dos registros do dgv(DataGridView). */

            //Especificar as Cores de Fundo e da Fonte Das Células Selecionadas.
            dgvSituacaoEstoque.DefaultCellStyle.SelectionForeColor = Color.Yellow;      /*-<<- Especificar a Cor da Fonte da celula selecionada do dgv(DataGridView). */
            dgvSituacaoEstoque.DefaultCellStyle.SelectionBackColor = Color.Black;       /*-<<- Especificar a Cor da Fundo da celula selecionada do dgv(DataGridView). */

                                                                               /*--------------------------*/
                                                                               /*   FORMATAÇÃO NUMÉRICA    */
                                                                               /*                          */
            //dgvSituacaoEstoque.Columns[0].DefaultCellStyle.Format = "d";     /*        <<  Data          */
            //Tempo                                                            /*                          */
            //dgvSituacaoEstoque.Columns[0].DefaultCellStyle.Format = "t";     /*       <<  Tempo          */
            //Moeda                                                            /*                          */
            //dgvSituacaoEstoque.Columns[0].DefaultCellStyle.Format = "C2";    /*        << Moeda          */
            //Número com casas decimais                                        /*                          */
            dgvSituacaoEstoque.Columns[5].DefaultCellStyle.Format = "N2";      /* << Nº com casas decimais */
        }                                                                      /*--------------------------*/             

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.opcao = "inserir";
            FormatarComponentes();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (opcao == "inserir")
                {
                    Produto produto = new Produto();        /*-<<- Instanciando objeto do produto */
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
                    opcao = "inicializar";
                }
            }
            catch (Exception erro)      /*-<<- Instanciado objeto da classe exception para tratamento de erro para visualização do usuario. */
            {
                MessageBox.Show(erro.Message);      /*-<<- Abrindo dialogo do objeto "erro" para interação com usuario. */
            }

            try
            {
                if (opcao == "editar")
                {
                    ConexaoBD conexao = new ConexaoBD(DadosDaConexao.StringDeConexao);
                    BLLProduto objBLL = new BLLProduto(conexao);

                    Produto produto = new Produto();
                    produto.Descricao = txtDescricao.Text;
                    if (fotoCaminho == "fotoOriginal")
                    {
                        Produto produtotemporario = objBLL.Carregar(this.cod);
                        produto.Foto = produtotemporario.Foto;
                    }
                    else
                    {
                        produto.CarregarImagem(fotoCaminho);
                    }
                    produto.CodigoBarras = txtCodigoBarras.Text;
                    produto.Qtde = Convert.ToInt32(txtQtde.Text);
                    produto.ValorUnitario = Convert.ToDouble(txtValorUnitario.Text);

                    objBLL.Editar(produto, cod);
                    MessageBox.Show("Produto atualizado com sucesso!");
                    opcao = "inicializar";
                }
            }
            catch (Exception erro)      /*-<<- Instanciado objeto da classe exception para tratamento de erro para visualização do usuario. */
            {
                MessageBox.Show(erro.Message);      /*-<<- Abrindo dialogo do objeto "erro" para interação com usuario. */
            }

            FormatarComponentes();
        }

        private void btnSelecionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();      /*-<<- Instanciando objeto para utilização de buscar foto externa ao Sistema. */
            ofd.ShowDialog();       /*-<<- Chamando metodo do objeto acima para abrir dialogo e realizar a seleção da foto. */
            if (!string.IsNullOrEmpty(ofd.FileName))        /*-<<- Validação para saber se foi selecionada alguma foto. */
            {
                fotoCaminho = ofd.FileName;     /*-<<- Guardando o caminho da foto para utilizar na gravação da mesma e funcionalidades durante o sistema. */
                pbFoto.Load(fotoCaminho);       /*-<<- Carregando componente visual com a foto atraves do caminho guardado(para utilização durante a foto não esta gravada no banco). */
            }
        }

        private void btnLimparFoto_Click(object sender, EventArgs e)
        {
            pbFoto.Image = null;     /*-<<- Atribuindo Nulo ao componente visual foto. */
            fotoCaminho = "";    /*-<<- Atribuindo vazio(Limpando variavel de caminho de origem da foto). */
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                ConexaoBD conexao = new ConexaoBD(DadosDaConexao.StringDeConexao);     /*-<<- Criando Objeto de Conexão e atribuindo a string de conexão ao mesmo. */
                BLLProduto objBLL = new BLLProduto(conexao);            /*-<<- Criando Objeto com metodos de validação para       */
                                                                        /*     fazer os comandos SQL conectado ao banco de dados. */
                dgvSituacaoEstoque.DataSource = objBLL.Pesquisar(txtPesquisar.Text);       /*-<<- Populando registros retornados atraves do SELECT realizado no banco para o dgv(DataGridView). */
                FormatarDGV();
            }
            catch (Exception erro)     /*-<<- Instanciado objeto da classe exception para tratamento de erro para visualização do usuario. */   
            {
                MessageBox.Show(erro.Message);     /*-<<- Abrindo dialogo do objeto "erro" para interação com usuario. */
            }
        }

        private void dgvSituacaoEstoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            if (e.RowIndex >= 0)      /*-<<- Tratamento para ignorar DoubleClick no cabeçalho do dgv(DataGridView) - Ele Pega a RowIndex(Numero da Linha) que disparou o evendo(e). */
            {
                this.cod = Convert.ToInt32(dgvSituacaoEstoque.Rows[e.RowIndex].Cells["id"/*-<<- Pode ser danto o nome da coluna q usa no banco ou o numero correspondente nesse caso = 0 */].Value);
                 
                ConexaoBD conexao = new ConexaoBD(DadosDaConexao.StringDeConexao);    /*-<<- Criando Objeto de Conexão e atribuindo a string de conexão ao mesmo. */
                BLLProduto objBLL = new BLLProduto(conexao);         /*-<<- Criando Objeto com metodos de validação para       */
                                                                     /*     fazer os comandos SQL conectado ao banco de dados. */
                Produto produto = objBLL.Carregar(cod);    /*-<<- Criando Objeto produto carregado com os dados do banco de dados coletados atravas do SELECT. */                    

                txtDescricao.Text = produto.Descricao;                     /*-<<-------------------------------*/
                txtCodigoBarras.Text = produto.CodigoBarras;               /*                                  */
                if (produto.Foto == null)                                  /* Atribuindo valores do banco car- */
                {                                                          /* regado no objeto para colocar    */
                    pbFoto.Image = null;                                   /* nos componentes visuais.         */
                }                                                          /*                                  */
                else                                                       /*                                  */
                {                                                          /*----------------------------------*/
                    MemoryStream ms = new MemoryStream(produto.Foto);      /* -<<- Objeto de conversão da foto */
                    pbFoto.Image = Image.FromStream(ms);                   /*      do banco carregado no obje- */
                    this.fotoCaminho = "fotoOriginal";                     /*      to foto para o PictureBox.  */
                }                                                          /*----------------------------------*/
                txtQtde.Text = produto.Qtde.ToString();                    /*                                  */
                txtValorUnitario.Text = produto.ValorUnitario.ToString();  /*----------------------------------*/
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.opcao = "editar";
            FormatarComponentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.opcao = "inicializar";
            FormatarComponentes();
        }

        private void txtPesquisar_Leave(object sender, EventArgs e)   /*-<<- Evento disparado ao sair do foco de objeto correspondente. */
        {
            if (txtPesquisar.Text.Length > 2)
            {
                btnPesquisar_Click(sender, e);                        /*-<<- Chamando evento Click do btnPesquisar. */
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)             /*-<<- Evento disparado ao trocar valor TEXT. */
        {
            if ((txtPesquisar.Text.Length > 2) || (dgvSituacaoEstoque.RowCount >= 1)) /*-<<------------------*/
            {                                                                         /*     Pesquisando     */
                btnPesquisar_Click(sender, e);                                        /*  a partir 3 letras  */
            }                                                                         /*---------------------*/

            if ((txtPesquisar.Text.Length < 3) && (dgvSituacaoEstoque.RowCount >= 1)) /*-<<-------------*/
            {                                                                         /*                */
                for (int i = 0; i < dgvSituacaoEstoque.RowCount; i++)                 /*  Limpando DGV  */
                {                                                                     /* (DataGridView) */
                    dgvSituacaoEstoque.Rows[i].DataGridView.Columns.Clear();          /*                */
                }                                                                     /*                */
            }                                                                         /*----------------*/
        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)                /*-<<------------------*/
        {                                                                               /*                     */
            if (e.KeyCode == Keys.Enter)                                                /*    Se tecla enter   */
            {                                                                           /* for pressionada faz */
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true); /*    função do TAB.   */
            }                                                                           /*---------------------*/
            if (e.KeyCode == Keys.F3)
            {
                btnPesquisar_Click(sender, e);
            }
        }                                                                               

        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)                          
        {
            Validador.ENumero(e);
            //                                                                                               /*-<<-----------------*/         
            //                                                                                               /*                    */
            //if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')  /*                    */
            //{                                                                                              /*Evento ao pressionar*/
            //    e.Handled = true;                                                                          /*     no textbox     */
            //}                                                                                              /* proibir caracteres */
            //if (e.KeyChar == ',' || e.KeyChar == '.')                                                      /*     permitindo     */
            //{                                                                                              /*       somente      */
            //    if (!txtCodigoBarras.Text.Contains(","))                                                   /*       numeros      */
            //    {                                                                                          /*          e         */
            //        e.KeyChar = ',';                                                                       /*      "," e "."     */
            //    }                                                                                          /*                    */
            //    else e.Handled = true;                                                                     /*                    */
            //}                                                                                              /*                    */
        }   //                                                                                               /*--------------------*/

        private void txtValorUnitario_Leave(object sender, EventArgs e)                      /*-<<-----------------*/
        {                                                                                    /*                    */
            if (txtValorUnitario.Text.Contains(",") == false)                                /*                    */
                txtValorUnitario.Text += ",00";                                              /*                    */
            else                                                                             /*                    */
            {                                                                                /*   Evento ao sair   */
                if (txtValorUnitario.Text.IndexOf(",") == txtValorUnitario.Text.Length - 1)  /*     do textbox     */
                    txtValorUnitario.Text += "00";                                           /*  adiciona as ",00" */
            }                                                                                /*     ou "00" caso   */
            try                                                                              /*    ja tenha a ","  */
            {                                                                                /*       e "0,00"     */
                double d = Convert.ToDouble(txtValorUnitario.Text);                          /*   quando deixado   */
            }                                                                                /*     em branco      */
            catch                                                                            /*                    */
            {                                                                                /*                    */
                txtValorUnitario.Text = "0,00";                                              /*                    */
            }                                                                                /*                    */
        }                                                                                    /*--------------------*/

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Falta Implementar.
        }
    }                                                                                        
}
