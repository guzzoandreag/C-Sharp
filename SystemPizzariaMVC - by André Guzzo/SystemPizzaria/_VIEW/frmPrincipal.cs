using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using SystemPizzaria._CONTROLLER.DAL;
using SystemPizzaria._MODAL;
using SystemPizzaria._CONTROLLER.BLL;

namespace SystemPizzaria
{
    public partial class frmPrincipal : Form
    {
        int codigoDGVIndex = 0;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btMontarPizza_Click(object sender, EventArgs e)
        {
            if (this.Size.Width == 739)
            {
                if (txtHora.Text == "00:00")
                {
                    DateTime horaatual = DateTime.Now;
                    txtHora.Text = horaatual.ToShortTimeString();
                }
                this.Size = new Size(935, 661);
            }
            else
            {
                this.Size = new Size(739, 661);
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            btMontarPizza_Click(sender, e);

            txtHora.Text = "00:00";
            mtxtFone.Focus();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente objBLL = new BLLCliente(conexao);

                Cliente cliente = new Cliente();
                cliente.Cli_Telefone = mtxtFone.Text;
                cliente.Cli_Nome = txtNome.Text;
                cliente.Cli_Cep = mtxtCEP.Text;
                cliente.Cli_Logradouro = txtLogradouro.Text;
                cliente.Cli_Bairro = txtBairro.Text;
                cliente.Cli_PontoReferencia = txtReferencia.Text;
                cliente.Cli_PercentualEncargos = Convert.ToDouble(txtEncargo.Text);
                cliente.Cli_ConcederDescontoNoPreco = checkBoxDesconto.Checked;

                objBLL.Inserir(cliente);
                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btProcurarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente objBLL = new BLLCliente(conexao);
                dgvClientes.DataSource = objBLL.Pesquisar(mtxtFone.Text);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void mtxtFone_TextChanged(object sender, EventArgs e)
        {
            //btProcurarCliente_Click(sender, e);
        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                btProcurarCliente_Click(sender, e);
            }
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigoDGVIndex = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells[0].Value);
            }
            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente objBLL = new BLLCliente(conexao);

                Cliente cliente = objBLL.Carregar(codigoDGVIndex);
                mtxtFone.Text = cliente.Cli_Telefone;
                txtNome.Text = cliente.Cli_Nome;
                mtxtCEP.Text = cliente.Cli_Cep;
                txtLogradouro.Text = cliente.Cli_Logradouro;
                txtBairro.Text = cliente.Cli_Bairro;
                txtReferencia.Text = cliente.Cli_PontoReferencia;
                txtEncargo.Text = cliente.Cli_PercentualEncargos.ToString();
                checkBoxDesconto.Checked = cliente.Cli_ConcederDescontoNoPreco;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            mtxtFone.ResetText();
            txtNome.ResetText();
            mtxtCEP.ResetText();
            txtLogradouro.ResetText();
            txtBairro.ResetText();
            txtReferencia.ResetText();
            txtEncargo.ResetText();
            checkBoxDesconto.Checked = false;
            for (int i = 0; i < dgvClientes.RowCount; i++)
            {
                dgvClientes.Rows[i].DataGridView.Columns.Clear();
            }
        }

        private double CalcularValorTotal()
        {
            double lTamanhoPizza = 0;
            double lValorTotal = 0;

            if (rbPequena.Checked)
            {
                lTamanhoPizza = Convert.ToDouble(txtPequena.Text);
            }
            else
            {
                if (rbMedia.Checked)
                {
                    lTamanhoPizza = Convert.ToDouble(txtMedia.Text);
                }
                else
                {
                    if (rbGrande.Checked)
                    {
                        lTamanhoPizza = Convert.ToDouble(txtGrande.Text);
                    }
                }
            }

            lValorTotal = lTamanhoPizza;

            if (cbQueijoExtra.Checked)
            {
                lValorTotal += Convert.ToDouble(txtQueijoExtra.Text);
            }
            if (cbCogumelo.Checked)
            {
                lValorTotal += Convert.ToDouble(txtCagumelo.Text);
            }
            if (cbAzeitona.Checked)
            {
                lValorTotal += Convert.ToDouble(txtAzeitona.Text);
            }
            if (cbCebola.Checked)
            {
                lValorTotal += Convert.ToDouble(txtCebola.Text);
            }
            if (cbTomate.Checked)
            {
                lValorTotal += Convert.ToDouble(txtTomate.Text);
            }
            if (cbCalabreza.Checked)
            {
                lValorTotal += Convert.ToDouble(txtCalabreza.Text);
            }
            if (cbOvo.Checked)
            {
                lValorTotal += Convert.ToDouble(txtOvo.Text);
            }
            if (cbPresunto.Checked)
            {
                lValorTotal += Convert.ToDouble(txtPresunto.Text);
            }
            if (cbCamarao.Checked)
            {
                lValorTotal += Convert.ToDouble(txtCamarao.Text);
            }
            if (cbEntregar.Checked)
            {
                lValorTotal += Convert.ToDouble(txtEntregar.Text);
            }
            if (cbBorda.Checked)
            {
                lValorTotal += Convert.ToDouble(txtBorda.Text);
            }
            return lValorTotal;
        }

        private void rbPequena_CheckedChanged(object sender, EventArgs e)
        {
            txtValorTotal.Text = CalcularValorTotal().ToString();
        }

        private void rbMedia_CheckedChanged(object sender, EventArgs e)
        {
            txtValorTotal.Text = CalcularValorTotal().ToString();
        }

        private void rbGrande_CheckedChanged(object sender, EventArgs e)
        {
            txtValorTotal.Text = CalcularValorTotal().ToString();
        }

        private void cbQueijoExtra_CheckedChanged(object sender, EventArgs e)
        {
            txtValorTotal.Text = CalcularValorTotal().ToString();
        }

        private void cbCogumelo_CheckedChanged(object sender, EventArgs e)
        {
            txtValorTotal.Text = CalcularValorTotal().ToString();
        }

        private void cbAzeitona_CheckedChanged(object sender, EventArgs e)
        {
            txtValorTotal.Text = CalcularValorTotal().ToString();
        }

        private void cbCebola_CheckedChanged(object sender, EventArgs e)
        {
            txtValorTotal.Text = CalcularValorTotal().ToString();
        }

        private void cbTomate_CheckedChanged(object sender, EventArgs e)
        {
            txtValorTotal.Text = CalcularValorTotal().ToString();
        }

        private void cbCalabreza_CheckedChanged(object sender, EventArgs e)
        {
            txtValorTotal.Text = CalcularValorTotal().ToString();
        }

        private void cbOvo_CheckedChanged(object sender, EventArgs e)
        {
            txtValorTotal.Text = CalcularValorTotal().ToString();
        }

        private void cbPresunto_CheckedChanged(object sender, EventArgs e)
        {
            txtValorTotal.Text = CalcularValorTotal().ToString();
        }

        private void cbCamarao_CheckedChanged(object sender, EventArgs e)
        {
            txtValorTotal.Text = CalcularValorTotal().ToString();
        }

        private void cbEntregar_CheckedChanged(object sender, EventArgs e)
        {
            txtValorTotal.Text = CalcularValorTotal().ToString();
        }

        private void cbBorda_CheckedChanged(object sender, EventArgs e)
        {
            txtValorTotal.Text = CalcularValorTotal().ToString();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Sair do Sistema ?", "Sair do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btCancelarPedido_Click(object sender, EventArgs e)
        {
            rbPequena.Checked = false;
            rbMedia.Checked = false;
            rbGrande.Checked = false;
            cbQueijoExtra.Checked = false;
            cbCogumelo.Checked = false;
            cbAzeitona.Checked = false;
            cbCebola.Checked = false;
            cbTomate.Checked = false;
            cbCalabreza.Checked = false;
            cbOvo.Checked = false;
            cbPresunto.Checked = false;
            cbCamarao.Checked = false;
            cbEntregar.Checked = false;
            cbBorda.Checked = false;
            frmPrincipal_Load(sender, e);
            btCancelar_Click(sender, e);
        }

        private void btGerarPedido_Click(object sender, EventArgs e)
        {
            string pedido = "Data : " + dtpDataPedido.Text + "\t\t\t\t" + "Horario : " + txtHora.Text + "\r\n" +
                            "Cliente : " + txtNome.Text + "\t\t" + "Contato : " + mtxtFone.Text + "\r\n" +
                            "Tamanho : ";
            if (!rbPequena.Checked && !rbMedia.Checked && !rbGrande.Checked)
            {
                pedido = pedido + "\r\n";
            }
            if (rbPequena.Checked)
            {
                pedido = pedido + "Pequena" + "\r\n";
            }
            else
            {
                if (rbMedia.Checked)
                {
                    pedido = pedido + "Média" + "\r\n";
                }
                else
                {
                    if (rbGrande.Checked)
                    {
                        pedido = pedido + "Grande" + "\r\n";
                    }
                }
            }
            pedido = pedido + "Ingredientes : ";
            if  (!cbQueijoExtra.Checked && !cbCogumelo.Checked && !cbAzeitona.Checked && !cbCebola.Checked &&
                    !cbTomate.Checked && !cbCalabreza.Checked && !cbOvo.Checked &&
                    !cbPresunto.Checked && !cbCamarao.Checked)
            {
                pedido = pedido + "\r\n";
            }
                if (cbQueijoExtra.Checked)
            {
                pedido = pedido + "Queijo Extra";
                if (cbCogumelo.Checked || cbAzeitona.Checked || cbCebola.Checked || 
                    cbTomate.Checked || cbCalabreza.Checked || cbOvo.Checked || 
                    cbPresunto.Checked || cbCamarao.Checked)
                {
                    pedido = pedido + ", ";
                }
                else
                {
                    pedido = pedido + "\r\n";
                }
            }
            if (cbCogumelo.Checked)
            {
                pedido = pedido + "Cogumelo";
                if (cbAzeitona.Checked || cbCebola.Checked || cbTomate.Checked ||
                    cbCalabreza.Checked || cbOvo.Checked || cbPresunto.Checked ||
                    cbCamarao.Checked)
                {
                    pedido = pedido + ", ";
                }
                else
                {
                    pedido = pedido + "\r\n";
                }
            }
            if (cbAzeitona.Checked)
            {
                pedido = pedido + "Azeitona";
                if (cbCebola.Checked || cbTomate.Checked || cbCalabreza.Checked ||
                    cbOvo.Checked || cbPresunto.Checked || cbCamarao.Checked)
                {
                    pedido = pedido + ", ";
                }
                else
                {
                    pedido = pedido + "\r\n";
                }
            }
            if (cbCebola.Checked)
            {
                pedido = pedido + "Cebola";
                if (cbTomate.Checked || cbCalabreza.Checked || cbOvo.Checked ||
                    cbPresunto.Checked || cbCamarao.Checked)
                {
                    pedido = pedido + ", ";
                }
                else
                {
                    pedido = pedido + "\r\n";
                }
            }
            if (cbTomate.Checked)
            {
                pedido = pedido + "Tomate";
                if (cbCalabreza.Checked || cbOvo.Checked || cbPresunto.Checked ||
                    cbCamarao.Checked)
                {
                    pedido = pedido + ", ";
                }
                else
                {
                    pedido = pedido + "\r\n";
                }
            }
            if (cbCalabreza.Checked)
            {
                pedido = pedido + "Calabreza";
                if (cbOvo.Checked || cbPresunto.Checked ||
                    cbCamarao.Checked)
                {
                    pedido = pedido + ", ";
                }
                else
                {
                    pedido = pedido + "\r\n";
                }
            }
            if (cbOvo.Checked)
            {
                pedido = pedido + "Ovo";
                if (cbPresunto.Checked || cbCamarao.Checked)
                {
                    pedido = pedido + ", ";
                }
                else
                {
                    pedido = pedido + "\r\n";
                }
            }
            if (cbPresunto.Checked)
            {
                pedido = pedido + "Presunto";
                if (cbCamarao.Checked)
                {
                    pedido = pedido + ", ";
                }
                else
                {
                    pedido = pedido + "\r\n";
                }
            }
            if (cbCamarao.Checked)
            {
                pedido = pedido + "Camarão" + "\r\n";

            }
            if (cbEntregar.Checked)
            {
                pedido = pedido + "Entrega : Sim" + "\r\n";
            }
            else
            {
                pedido = pedido + "Entrega : Não" + "\r\n";
            }
            if (cbBorda.Checked)
            {
                pedido = pedido + "Borda : Sim" + "\r\n";
            }
            else
            {
                pedido = pedido + "Borda : Não" + "\r\n";
            }
            if (checkBoxDesconto.Checked)
            {
                txtValorTotal.Text = Convert.ToString(CalcularValorTotal());
                txtValorTotal.Text = Convert.ToString(Convert.ToDouble(txtValorTotal.Text) - ((Convert.ToDouble(txtValorTotal.Text) * (Convert.ToDouble(txtEncargo.Text)/100))));
            }
            else
            {
                txtValorTotal.Text = Convert.ToString(CalcularValorTotal());
            }
            txtDescricao.Text = pedido;
        }
    }
}
