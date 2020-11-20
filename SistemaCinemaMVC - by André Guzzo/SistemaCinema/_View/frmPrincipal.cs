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

namespace SistemaCinema
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lbTitulo.Parent = pbFundo;
            lbTitulo.BackColor = Color.Transparent;
            gbAmbiente.Parent = pbFundo;
            gbAmbiente.BackColor = Color.Transparent;
            lbEmCartaz.Parent = pbFundo;
            lbEmCartaz.BackColor = Color.Transparent;
            gbMovimentacao.Parent = pbFundo;
            gbMovimentacao.BackColor = Color.Transparent;
            lbFilme.Parent = pbFundo;
            lbFilme.BackColor = Color.Transparent;
            lbGenero.Parent = pbFundo;
            lbGenero.BackColor = Color.Transparent;
            lbLinguagem.Parent = pbFundo;
            lbLinguagem.BackColor = Color.Transparent;
            lbAutor.Parent = pbFundo;
            lbAutor.BackColor = Color.Transparent;
            lbValor.Parent = pbFundo;
            lbValor.BackColor = Color.Transparent;
            lbHorario.Parent = pbFundo;
            lbHorario.BackColor = Color.Transparent;
            lbData.Parent = pbFundo;
            lbData.BackColor = Color.Transparent;
            lbDisponibilidade.Parent = pbFundo;
            lbDisponibilidade.BackColor = Color.Transparent;
        }
    }
}
