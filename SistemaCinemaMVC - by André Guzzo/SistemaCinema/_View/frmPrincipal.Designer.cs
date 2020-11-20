namespace SistemaCinema
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitulo = new System.Windows.Forms.Label();
            this.rbSala3 = new System.Windows.Forms.RadioButton();
            this.gbMovimentacao = new System.Windows.Forms.GroupBox();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRecibi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDisponibilidade = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lbValor = new System.Windows.Forms.Label();
            this.lbEmCartaz = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.rbSala2 = new System.Windows.Forms.RadioButton();
            this.gbAmbiente = new System.Windows.Forms.GroupBox();
            this.rbSala4 = new System.Windows.Forms.RadioButton();
            this.rbSala1 = new System.Windows.Forms.RadioButton();
            this.lbDisponibilidade = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.mtxtHorario = new System.Windows.Forms.MaskedTextBox();
            this.lbHorario = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lbAutor = new System.Windows.Forms.Label();
            this.lbLinguagem = new System.Windows.Forms.Label();
            this.lbGenero = new System.Windows.Forms.Label();
            this.txtFilme = new System.Windows.Forms.TextBox();
            this.lbFilme = new System.Windows.Forms.Label();
            this.dgvEmCartaz = new System.Windows.Forms.DataGridView();
            this.btnRemoverFoto = new System.Windows.Forms.Button();
            this.btnAdicionarFoto = new System.Windows.Forms.Button();
            this.cbLinguagem = new System.Windows.Forms.ComboBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbFundo = new System.Windows.Forms.PictureBox();
            this.gbMovimentacao.SuspendLayout();
            this.gbAmbiente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmCartaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(340, 11);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(292, 42);
            this.lbTitulo.TabIndex = 60;
            this.lbTitulo.Text = "Cine Hollywood";
            // 
            // rbSala3
            // 
            this.rbSala3.AutoSize = true;
            this.rbSala3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSala3.ForeColor = System.Drawing.Color.Black;
            this.rbSala3.Location = new System.Drawing.Point(312, 26);
            this.rbSala3.Margin = new System.Windows.Forms.Padding(4);
            this.rbSala3.Name = "rbSala3";
            this.rbSala3.Size = new System.Drawing.Size(89, 29);
            this.rbSala3.TabIndex = 2;
            this.rbSala3.Text = "Sala 3";
            this.rbSala3.UseVisualStyleBackColor = true;
            // 
            // gbMovimentacao
            // 
            this.gbMovimentacao.Controls.Add(this.btnFinalizarVenda);
            this.gbMovimentacao.Controls.Add(this.btnVender);
            this.gbMovimentacao.Controls.Add(this.txtTroco);
            this.gbMovimentacao.Controls.Add(this.label11);
            this.gbMovimentacao.Controls.Add(this.txtRecibi);
            this.gbMovimentacao.Controls.Add(this.label10);
            this.gbMovimentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMovimentacao.ForeColor = System.Drawing.Color.White;
            this.gbMovimentacao.Location = new System.Drawing.Point(631, 468);
            this.gbMovimentacao.Margin = new System.Windows.Forms.Padding(4);
            this.gbMovimentacao.Name = "gbMovimentacao";
            this.gbMovimentacao.Padding = new System.Windows.Forms.Padding(4);
            this.gbMovimentacao.Size = new System.Drawing.Size(292, 287);
            this.gbMovimentacao.TabIndex = 58;
            this.gbMovimentacao.TabStop = false;
            this.gbMovimentacao.Text = "Movimentação";
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.BackColor = System.Drawing.Color.White;
            this.btnFinalizarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenda.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizarVenda.Location = new System.Drawing.Point(22, 220);
            this.btnFinalizarVenda.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(247, 37);
            this.btnFinalizarVenda.TabIndex = 36;
            this.btnFinalizarVenda.Text = "Finalizar Venda (10)";
            this.btnFinalizarVenda.UseVisualStyleBackColor = false;
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.White;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.ForeColor = System.Drawing.Color.Black;
            this.btnVender.Location = new System.Drawing.Point(22, 105);
            this.btnVender.Margin = new System.Windows.Forms.Padding(4);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(247, 37);
            this.btnVender.TabIndex = 35;
            this.btnVender.Text = "Vender (F9)";
            this.btnVender.UseVisualStyleBackColor = false;
            // 
            // txtTroco
            // 
            this.txtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.Location = new System.Drawing.Point(24, 174);
            this.txtTroco.Margin = new System.Windows.Forms.Padding(4);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(245, 30);
            this.txtTroco.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(42, 146);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "Troco R$";
            // 
            // txtRecibi
            // 
            this.txtRecibi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecibi.Location = new System.Drawing.Point(24, 59);
            this.txtRecibi.Margin = new System.Windows.Forms.Padding(4);
            this.txtRecibi.Name = "txtRecibi";
            this.txtRecibi.Size = new System.Drawing.Size(245, 30);
            this.txtRecibi.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(19, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "Recebi R$";
            // 
            // txtDisponibilidade
            // 
            this.txtDisponibilidade.Enabled = false;
            this.txtDisponibilidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisponibilidade.Location = new System.Drawing.Point(348, 332);
            this.txtDisponibilidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtDisponibilidade.Name = "txtDisponibilidade";
            this.txtDisponibilidade.Size = new System.Drawing.Size(256, 30);
            this.txtDisponibilidade.TabIndex = 57;
            this.txtDisponibilidade.Text = "30";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(348, 271);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(256, 30);
            this.txtValor.TabIndex = 56;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor.ForeColor = System.Drawing.Color.Black;
            this.lbValor.Location = new System.Drawing.Point(343, 242);
            this.lbValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(87, 25);
            this.lbValor.TabIndex = 55;
            this.lbValor.Text = "Valor R$";
            // 
            // lbEmCartaz
            // 
            this.lbEmCartaz.AutoSize = true;
            this.lbEmCartaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmCartaz.ForeColor = System.Drawing.Color.White;
            this.lbEmCartaz.Location = new System.Drawing.Point(20, 468);
            this.lbEmCartaz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmCartaz.Name = "lbEmCartaz";
            this.lbEmCartaz.Size = new System.Drawing.Size(132, 29);
            this.lbEmCartaz.TabIndex = 54;
            this.lbEmCartaz.Text = "Em Cartaz";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(547, 64);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(167, 37);
            this.btnExcluir.TabIndex = 53;
            this.btnExcluir.Text = "Excluir (F6)";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.White;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(364, 64);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(180, 37);
            this.btnAtualizar.TabIndex = 52;
            this.btnAtualizar.Text = "Atualizar (F5)";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(195, 64);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(167, 37);
            this.btnSalvar.TabIndex = 51;
            this.btnSalvar.Text = "Salvar (F4)";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.White;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(25, 64);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(167, 37);
            this.btnInserir.TabIndex = 50;
            this.btnInserir.Text = "Inserir (F3)";
            this.btnInserir.UseVisualStyleBackColor = false;
            // 
            // rbSala2
            // 
            this.rbSala2.AutoSize = true;
            this.rbSala2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSala2.ForeColor = System.Drawing.Color.Black;
            this.rbSala2.Location = new System.Drawing.Point(173, 26);
            this.rbSala2.Margin = new System.Windows.Forms.Padding(4);
            this.rbSala2.Name = "rbSala2";
            this.rbSala2.Size = new System.Drawing.Size(89, 29);
            this.rbSala2.TabIndex = 1;
            this.rbSala2.Text = "Sala 2";
            this.rbSala2.UseVisualStyleBackColor = true;
            // 
            // gbAmbiente
            // 
            this.gbAmbiente.Controls.Add(this.rbSala4);
            this.gbAmbiente.Controls.Add(this.rbSala3);
            this.gbAmbiente.Controls.Add(this.rbSala2);
            this.gbAmbiente.Controls.Add(this.rbSala1);
            this.gbAmbiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAmbiente.ForeColor = System.Drawing.Color.White;
            this.gbAmbiente.Location = new System.Drawing.Point(23, 380);
            this.gbAmbiente.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.gbAmbiente.Name = "gbAmbiente";
            this.gbAmbiente.Padding = new System.Windows.Forms.Padding(4);
            this.gbAmbiente.Size = new System.Drawing.Size(583, 66);
            this.gbAmbiente.TabIndex = 49;
            this.gbAmbiente.TabStop = false;
            this.gbAmbiente.Text = "Ambiente";
            // 
            // rbSala4
            // 
            this.rbSala4.AutoSize = true;
            this.rbSala4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSala4.ForeColor = System.Drawing.Color.Black;
            this.rbSala4.Location = new System.Drawing.Point(451, 26);
            this.rbSala4.Margin = new System.Windows.Forms.Padding(4);
            this.rbSala4.Name = "rbSala4";
            this.rbSala4.Size = new System.Drawing.Size(89, 29);
            this.rbSala4.TabIndex = 19;
            this.rbSala4.Text = "Sala 4";
            this.rbSala4.UseVisualStyleBackColor = true;
            // 
            // rbSala1
            // 
            this.rbSala1.AutoSize = true;
            this.rbSala1.Checked = true;
            this.rbSala1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSala1.ForeColor = System.Drawing.Color.Black;
            this.rbSala1.Location = new System.Drawing.Point(35, 26);
            this.rbSala1.Margin = new System.Windows.Forms.Padding(4);
            this.rbSala1.Name = "rbSala1";
            this.rbSala1.Size = new System.Drawing.Size(89, 29);
            this.rbSala1.TabIndex = 0;
            this.rbSala1.TabStop = true;
            this.rbSala1.Text = "Sala 1";
            this.rbSala1.UseVisualStyleBackColor = true;
            // 
            // lbDisponibilidade
            // 
            this.lbDisponibilidade.AutoSize = true;
            this.lbDisponibilidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisponibilidade.ForeColor = System.Drawing.Color.Black;
            this.lbDisponibilidade.Location = new System.Drawing.Point(343, 306);
            this.lbDisponibilidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDisponibilidade.Name = "lbDisponibilidade";
            this.lbDisponibilidade.Size = new System.Drawing.Size(144, 25);
            this.lbDisponibilidade.TabIndex = 48;
            this.lbDisponibilidade.Text = "Disponibilidade";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.ForeColor = System.Drawing.Color.Black;
            this.lbData.Location = new System.Drawing.Point(152, 306);
            this.lbData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(53, 25);
            this.lbData.TabIndex = 47;
            this.lbData.Text = "Data";
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(157, 330);
            this.dtpData.Margin = new System.Windows.Forms.Padding(4);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(160, 30);
            this.dtpData.TabIndex = 46;
            // 
            // mtxtHorario
            // 
            this.mtxtHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtHorario.Location = new System.Drawing.Point(23, 332);
            this.mtxtHorario.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtHorario.Mask = "00:00";
            this.mtxtHorario.Name = "mtxtHorario";
            this.mtxtHorario.Size = new System.Drawing.Size(62, 30);
            this.mtxtHorario.TabIndex = 45;
            this.mtxtHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtHorario.ValidatingType = typeof(System.DateTime);
            // 
            // lbHorario
            // 
            this.lbHorario.AutoSize = true;
            this.lbHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHorario.ForeColor = System.Drawing.Color.Black;
            this.lbHorario.Location = new System.Drawing.Point(20, 306);
            this.lbHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(75, 25);
            this.lbHorario.TabIndex = 44;
            this.lbHorario.Text = "Horário";
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(23, 271);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(295, 30);
            this.txtAutor.TabIndex = 43;
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutor.ForeColor = System.Drawing.Color.Black;
            this.lbAutor.Location = new System.Drawing.Point(17, 242);
            this.lbAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(99, 25);
            this.lbAutor.TabIndex = 42;
            this.lbAutor.Text = "Autor (es)";
            // 
            // lbLinguagem
            // 
            this.lbLinguagem.AutoSize = true;
            this.lbLinguagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLinguagem.ForeColor = System.Drawing.Color.Black;
            this.lbLinguagem.Location = new System.Drawing.Point(343, 177);
            this.lbLinguagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLinguagem.Name = "lbLinguagem";
            this.lbLinguagem.Size = new System.Drawing.Size(109, 25);
            this.lbLinguagem.TabIndex = 40;
            this.lbLinguagem.Text = "Linguagem";
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenero.ForeColor = System.Drawing.Color.Black;
            this.lbGenero.Location = new System.Drawing.Point(17, 176);
            this.lbGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(77, 25);
            this.lbGenero.TabIndex = 38;
            this.lbGenero.Text = "Gênero";
            // 
            // txtFilme
            // 
            this.txtFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilme.Location = new System.Drawing.Point(23, 142);
            this.txtFilme.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilme.Name = "txtFilme";
            this.txtFilme.Size = new System.Drawing.Size(581, 30);
            this.txtFilme.TabIndex = 37;
            // 
            // lbFilme
            // 
            this.lbFilme.AutoSize = true;
            this.lbFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilme.ForeColor = System.Drawing.Color.Black;
            this.lbFilme.Location = new System.Drawing.Point(17, 113);
            this.lbFilme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFilme.Name = "lbFilme";
            this.lbFilme.Size = new System.Drawing.Size(59, 25);
            this.lbFilme.TabIndex = 36;
            this.lbFilme.Text = "Filme";
            // 
            // dgvEmCartaz
            // 
            this.dgvEmCartaz.AllowUserToAddRows = false;
            this.dgvEmCartaz.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmCartaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmCartaz.Location = new System.Drawing.Point(23, 505);
            this.dgvEmCartaz.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmCartaz.Name = "dgvEmCartaz";
            this.dgvEmCartaz.ReadOnly = true;
            this.dgvEmCartaz.RowHeadersWidth = 51;
            this.dgvEmCartaz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmCartaz.Size = new System.Drawing.Size(583, 250);
            this.dgvEmCartaz.TabIndex = 34;
            // 
            // btnRemoverFoto
            // 
            this.btnRemoverFoto.BackColor = System.Drawing.Color.White;
            this.btnRemoverFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverFoto.Location = new System.Drawing.Point(631, 406);
            this.btnRemoverFoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoverFoto.Name = "btnRemoverFoto";
            this.btnRemoverFoto.Size = new System.Drawing.Size(292, 41);
            this.btnRemoverFoto.TabIndex = 62;
            this.btnRemoverFoto.Text = "Remover Encarte (F8)";
            this.btnRemoverFoto.UseVisualStyleBackColor = false;
            // 
            // btnAdicionarFoto
            // 
            this.btnAdicionarFoto.BackColor = System.Drawing.Color.White;
            this.btnAdicionarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarFoto.Location = new System.Drawing.Point(631, 142);
            this.btnAdicionarFoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionarFoto.Name = "btnAdicionarFoto";
            this.btnAdicionarFoto.Size = new System.Drawing.Size(292, 43);
            this.btnAdicionarFoto.TabIndex = 61;
            this.btnAdicionarFoto.Text = "Adicionar Encarte (F7)";
            this.btnAdicionarFoto.UseVisualStyleBackColor = false;
            // 
            // cbLinguagem
            // 
            this.cbLinguagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLinguagem.FormattingEnabled = true;
            this.cbLinguagem.Items.AddRange(new object[] {
            "Dublado",
            "Legendado"});
            this.cbLinguagem.Location = new System.Drawing.Point(348, 204);
            this.cbLinguagem.Margin = new System.Windows.Forms.Padding(4);
            this.cbLinguagem.Name = "cbLinguagem";
            this.cbLinguagem.Size = new System.Drawing.Size(256, 33);
            this.cbLinguagem.TabIndex = 41;
            // 
            // cbGenero
            // 
            this.cbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Ação",
            "Animação",
            "Aventura",
            "Comédia",
            "Documentários",
            "Drama"});
            this.cbGenero.Location = new System.Drawing.Point(23, 204);
            this.cbGenero.Margin = new System.Windows.Forms.Padding(4);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(295, 33);
            this.cbGenero.TabIndex = 63;
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(231, 465);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(373, 30);
            this.txtFiltro.TabIndex = 64;
            this.txtFiltro.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(716, 64);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(207, 37);
            this.btnCancelar.TabIndex = 65;
            this.btnCancelar.Text = "Cancelar (Esc)";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::SistemaCinema.Properties.Resources.Avatar2;
            this.pictureBox1.Location = new System.Drawing.Point(631, 142);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // pbFundo
            // 
            this.pbFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFundo.Image = global::SistemaCinema.Properties.Resources.fundo;
            this.pbFundo.Location = new System.Drawing.Point(0, 0);
            this.pbFundo.Margin = new System.Windows.Forms.Padding(4);
            this.pbFundo.Name = "pbFundo";
            this.pbFundo.Size = new System.Drawing.Size(936, 768);
            this.pbFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFundo.TabIndex = 66;
            this.pbFundo.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(936, 768);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.btnAdicionarFoto);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.gbMovimentacao);
            this.Controls.Add(this.txtDisponibilidade);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.lbEmCartaz);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnRemoverFoto);
            this.Controls.Add(this.gbAmbiente);
            this.Controls.Add(this.lbDisponibilidade);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.mtxtHorario);
            this.Controls.Add(this.lbHorario);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.cbLinguagem);
            this.Controls.Add(this.lbLinguagem);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.txtFilme);
            this.Controls.Add(this.lbFilme);
            this.Controls.Add(this.dgvEmCartaz);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbFundo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda de Bilhetes";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gbMovimentacao.ResumeLayout(false);
            this.gbMovimentacao.PerformLayout();
            this.gbAmbiente.ResumeLayout(false);
            this.gbAmbiente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmCartaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.RadioButton rbSala3;
        private System.Windows.Forms.GroupBox gbMovimentacao;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRecibi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDisponibilidade;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label lbEmCartaz;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.RadioButton rbSala2;
        private System.Windows.Forms.GroupBox gbAmbiente;
        private System.Windows.Forms.RadioButton rbSala1;
        private System.Windows.Forms.Label lbDisponibilidade;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.MaskedTextBox mtxtHorario;
        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.Label lbLinguagem;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.TextBox txtFilme;
        private System.Windows.Forms.Label lbFilme;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.DataGridView dgvEmCartaz;
        private System.Windows.Forms.Button btnRemoverFoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdicionarFoto;
        private System.Windows.Forms.ComboBox cbLinguagem;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.RadioButton rbSala4;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbFundo;
        private System.Windows.Forms.Button btnFinalizarVenda;
    }
}

