namespace SystemPizzaria
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBorda = new System.Windows.Forms.TextBox();
            this.cbEntregar = new System.Windows.Forms.CheckBox();
            this.txtEntregar = new System.Windows.Forms.TextBox();
            this.cbBorda = new System.Windows.Forms.CheckBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btCancelarPedido = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataPedido = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBoxDesconto = new System.Windows.Forms.CheckBox();
            this.txtEncargo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.mtxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btProcurarCliente = new System.Windows.Forms.Button();
            this.mtxtFone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCamarao = new System.Windows.Forms.TextBox();
            this.cbCamarao = new System.Windows.Forms.CheckBox();
            this.txtPresunto = new System.Windows.Forms.TextBox();
            this.cbPresunto = new System.Windows.Forms.CheckBox();
            this.txtOvo = new System.Windows.Forms.TextBox();
            this.cbOvo = new System.Windows.Forms.CheckBox();
            this.txtCalabreza = new System.Windows.Forms.TextBox();
            this.cbCalabreza = new System.Windows.Forms.CheckBox();
            this.txtTomate = new System.Windows.Forms.TextBox();
            this.cbTomate = new System.Windows.Forms.CheckBox();
            this.txtCebola = new System.Windows.Forms.TextBox();
            this.cbCebola = new System.Windows.Forms.CheckBox();
            this.txtAzeitona = new System.Windows.Forms.TextBox();
            this.cbAzeitona = new System.Windows.Forms.CheckBox();
            this.txtCagumelo = new System.Windows.Forms.TextBox();
            this.cbCogumelo = new System.Windows.Forms.CheckBox();
            this.txtQueijoExtra = new System.Windows.Forms.TextBox();
            this.cbQueijoExtra = new System.Windows.Forms.CheckBox();
            this.gBoxTamanho = new System.Windows.Forms.GroupBox();
            this.txtGrande = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtPequena = new System.Windows.Forms.TextBox();
            this.rbGrande = new System.Windows.Forms.RadioButton();
            this.rbMedia = new System.Windows.Forms.RadioButton();
            this.rbPequena = new System.Windows.Forms.RadioButton();
            this.btGerarPedido = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btMontarPizza = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gBoxTamanho.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Controls.Add(this.txtValorTotal);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.btCancelarPedido);
            this.panel4.Controls.Add(this.dgvClientes);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.gBoxTamanho);
            this.panel4.Controls.Add(this.btGerarPedido);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.btMontarPizza);
            this.panel4.Controls.Add(this.txtDescricao);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(919, 622);
            this.panel4.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBorda);
            this.groupBox3.Controls.Add(this.cbEntregar);
            this.groupBox3.Controls.Add(this.txtEntregar);
            this.groupBox3.Controls.Add(this.cbBorda);
            this.groupBox3.Location = new System.Drawing.Point(727, 463);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 77);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Outros";
            // 
            // txtBorda
            // 
            this.txtBorda.Location = new System.Drawing.Point(103, 45);
            this.txtBorda.Name = "txtBorda";
            this.txtBorda.Size = new System.Drawing.Size(61, 20);
            this.txtBorda.TabIndex = 25;
            this.txtBorda.Text = "2,00";
            this.txtBorda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbEntregar
            // 
            this.cbEntregar.AutoSize = true;
            this.cbEntregar.Location = new System.Drawing.Point(19, 21);
            this.cbEntregar.Name = "cbEntregar";
            this.cbEntregar.Size = new System.Drawing.Size(66, 17);
            this.cbEntregar.TabIndex = 0;
            this.cbEntregar.Text = "Entregar";
            this.cbEntregar.UseVisualStyleBackColor = true;
            this.cbEntregar.CheckedChanged += new System.EventHandler(this.cbEntregar_CheckedChanged);
            // 
            // txtEntregar
            // 
            this.txtEntregar.Location = new System.Drawing.Point(103, 19);
            this.txtEntregar.Name = "txtEntregar";
            this.txtEntregar.Size = new System.Drawing.Size(61, 20);
            this.txtEntregar.TabIndex = 24;
            this.txtEntregar.Text = "5,00";
            this.txtEntregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbBorda
            // 
            this.cbBorda.AutoSize = true;
            this.cbBorda.Location = new System.Drawing.Point(19, 47);
            this.cbBorda.Name = "cbBorda";
            this.cbBorda.Size = new System.Drawing.Size(54, 17);
            this.cbBorda.TabIndex = 1;
            this.cbBorda.Text = "Borda";
            this.cbBorda.UseVisualStyleBackColor = true;
            this.cbBorda.CheckedChanged += new System.EventHandler(this.cbBorda_CheckedChanged);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(813, 552);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(76, 20);
            this.txtValorTotal.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(731, 556);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Valor Total (R$)";
            // 
            // btCancelarPedido
            // 
            this.btCancelarPedido.Location = new System.Drawing.Point(723, 579);
            this.btCancelarPedido.Name = "btCancelarPedido";
            this.btCancelarPedido.Size = new System.Drawing.Size(98, 28);
            this.btCancelarPedido.TabIndex = 1;
            this.btCancelarPedido.Text = "Cancelar Pedido";
            this.btCancelarPedido.UseVisualStyleBackColor = true;
            this.btCancelarPedido.Click += new System.EventHandler(this.btCancelarPedido_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 149);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(316, 217);
            this.dgvClientes.TabIndex = 17;
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtHora);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpDataPedido);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 40);
            this.panel1.TabIndex = 1;
            // 
            // txtHora
            // 
            this.txtHora.Enabled = false;
            this.txtHora.Location = new System.Drawing.Point(220, 9);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(86, 20);
            this.txtHora.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hora";
            // 
            // dtpDataPedido
            // 
            this.dtpDataPedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPedido.Location = new System.Drawing.Point(88, 9);
            this.dtpDataPedido.Name = "dtpDataPedido";
            this.dtpDataPedido.Size = new System.Drawing.Size(86, 20);
            this.dtpDataPedido.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Pedido";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.checkBoxDesconto);
            this.panel2.Controls.Add(this.txtEncargo);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtReferencia);
            this.panel2.Controls.Add(this.txtBairro);
            this.panel2.Controls.Add(this.btCancelar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btSalvar);
            this.panel2.Controls.Add(this.mtxtCEP);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtLogradouro);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btProcurarCliente);
            this.panel2.Controls.Add(this.mtxtFone);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(334, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 279);
            this.panel2.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(290, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Nome";
            // 
            // checkBoxDesconto
            // 
            this.checkBoxDesconto.AutoSize = true;
            this.checkBoxDesconto.Location = new System.Drawing.Point(147, 216);
            this.checkBoxDesconto.Name = "checkBoxDesconto";
            this.checkBoxDesconto.Size = new System.Drawing.Size(164, 17);
            this.checkBoxDesconto.TabIndex = 8;
            this.checkBoxDesconto.Text = "Conceder desconto no preço";
            this.checkBoxDesconto.UseVisualStyleBackColor = true;
            // 
            // txtEncargo
            // 
            this.txtEncargo.Location = new System.Drawing.Point(85, 213);
            this.txtEncargo.Name = "txtEncargo";
            this.txtEncargo.Size = new System.Drawing.Size(43, 20);
            this.txtEncargo.TabIndex = 7;
            this.txtEncargo.Text = "5,00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Encardos (%)";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(13, 186);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(293, 20);
            this.txtReferencia.TabIndex = 6;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(13, 144);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(293, 20);
            this.txtBairro.TabIndex = 5;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(157, 240);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(150, 24);
            this.btCancelar.TabIndex = 10;
            this.btCancelar.Text = "Cancelar Cadastro";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Bairro";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(12, 240);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(145, 24);
            this.btSalvar.TabIndex = 9;
            this.btSalvar.Text = "Salvar Cliente";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // mtxtCEP
            // 
            this.mtxtCEP.Location = new System.Drawing.Point(234, 77);
            this.mtxtCEP.Mask = "00000-999";
            this.mtxtCEP.Name = "mtxtCEP";
            this.mtxtCEP.Size = new System.Drawing.Size(72, 20);
            this.mtxtCEP.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "CEP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ponto Referência";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(13, 105);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(293, 20);
            this.txtLogradouro.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Logradouro";
            // 
            // btProcurarCliente
            // 
            this.btProcurarCliente.Location = new System.Drawing.Point(161, 6);
            this.btProcurarCliente.Name = "btProcurarCliente";
            this.btProcurarCliente.Size = new System.Drawing.Size(121, 23);
            this.btProcurarCliente.TabIndex = 1;
            this.btProcurarCliente.Text = "Procurar Cliente (F10)";
            this.btProcurarCliente.UseVisualStyleBackColor = true;
            this.btProcurarCliente.Click += new System.EventHandler(this.btProcurarCliente_Click);
            // 
            // mtxtFone
            // 
            this.mtxtFone.Location = new System.Drawing.Point(55, 7);
            this.mtxtFone.Mask = "(99) 00000-0000";
            this.mtxtFone.Name = "mtxtFone";
            this.mtxtFone.Size = new System.Drawing.Size(100, 20);
            this.mtxtFone.TabIndex = 0;
            this.mtxtFone.TextChanged += new System.EventHandler(this.mtxtFone_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(125, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(517, 79);
            this.label10.TabIndex = 16;
            this.label10.Text = "Pizzaria Mama Mia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SystemPizzaria.Properties.Resources.pizza;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCamarao);
            this.groupBox2.Controls.Add(this.cbCamarao);
            this.groupBox2.Controls.Add(this.txtPresunto);
            this.groupBox2.Controls.Add(this.cbPresunto);
            this.groupBox2.Controls.Add(this.txtOvo);
            this.groupBox2.Controls.Add(this.cbOvo);
            this.groupBox2.Controls.Add(this.txtCalabreza);
            this.groupBox2.Controls.Add(this.cbCalabreza);
            this.groupBox2.Controls.Add(this.txtTomate);
            this.groupBox2.Controls.Add(this.cbTomate);
            this.groupBox2.Controls.Add(this.txtCebola);
            this.groupBox2.Controls.Add(this.cbCebola);
            this.groupBox2.Controls.Add(this.txtAzeitona);
            this.groupBox2.Controls.Add(this.cbAzeitona);
            this.groupBox2.Controls.Add(this.txtCagumelo);
            this.groupBox2.Controls.Add(this.cbCogumelo);
            this.groupBox2.Controls.Add(this.txtQueijoExtra);
            this.groupBox2.Controls.Add(this.cbQueijoExtra);
            this.groupBox2.Location = new System.Drawing.Point(727, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 276);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingredientes";
            // 
            // txtCamarao
            // 
            this.txtCamarao.Location = new System.Drawing.Point(103, 245);
            this.txtCamarao.Name = "txtCamarao";
            this.txtCamarao.Size = new System.Drawing.Size(61, 20);
            this.txtCamarao.TabIndex = 44;
            this.txtCamarao.Text = "3,00";
            this.txtCamarao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbCamarao
            // 
            this.cbCamarao.AutoSize = true;
            this.cbCamarao.Location = new System.Drawing.Point(14, 245);
            this.cbCamarao.Name = "cbCamarao";
            this.cbCamarao.Size = new System.Drawing.Size(68, 17);
            this.cbCamarao.TabIndex = 8;
            this.cbCamarao.Text = "Camarão";
            this.cbCamarao.UseVisualStyleBackColor = true;
            this.cbCamarao.CheckedChanged += new System.EventHandler(this.cbCamarao_CheckedChanged);
            // 
            // txtPresunto
            // 
            this.txtPresunto.Location = new System.Drawing.Point(103, 219);
            this.txtPresunto.Name = "txtPresunto";
            this.txtPresunto.Size = new System.Drawing.Size(61, 20);
            this.txtPresunto.TabIndex = 42;
            this.txtPresunto.Text = "2,00";
            this.txtPresunto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbPresunto
            // 
            this.cbPresunto.AutoSize = true;
            this.cbPresunto.Location = new System.Drawing.Point(14, 217);
            this.cbPresunto.Name = "cbPresunto";
            this.cbPresunto.Size = new System.Drawing.Size(68, 17);
            this.cbPresunto.TabIndex = 7;
            this.cbPresunto.Text = "Presunto";
            this.cbPresunto.UseVisualStyleBackColor = true;
            this.cbPresunto.CheckedChanged += new System.EventHandler(this.cbPresunto_CheckedChanged);
            // 
            // txtOvo
            // 
            this.txtOvo.Location = new System.Drawing.Point(103, 190);
            this.txtOvo.Name = "txtOvo";
            this.txtOvo.Size = new System.Drawing.Size(61, 20);
            this.txtOvo.TabIndex = 40;
            this.txtOvo.Text = "2,00";
            this.txtOvo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbOvo
            // 
            this.cbOvo.AutoSize = true;
            this.cbOvo.Location = new System.Drawing.Point(14, 189);
            this.cbOvo.Name = "cbOvo";
            this.cbOvo.Size = new System.Drawing.Size(46, 17);
            this.cbOvo.TabIndex = 6;
            this.cbOvo.Text = "Ovo";
            this.cbOvo.UseVisualStyleBackColor = true;
            this.cbOvo.CheckedChanged += new System.EventHandler(this.cbOvo_CheckedChanged);
            // 
            // txtCalabreza
            // 
            this.txtCalabreza.Location = new System.Drawing.Point(103, 159);
            this.txtCalabreza.Name = "txtCalabreza";
            this.txtCalabreza.Size = new System.Drawing.Size(61, 20);
            this.txtCalabreza.TabIndex = 38;
            this.txtCalabreza.Text = "2,00";
            this.txtCalabreza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbCalabreza
            // 
            this.cbCalabreza.AutoSize = true;
            this.cbCalabreza.Location = new System.Drawing.Point(14, 161);
            this.cbCalabreza.Name = "cbCalabreza";
            this.cbCalabreza.Size = new System.Drawing.Size(73, 17);
            this.cbCalabreza.TabIndex = 5;
            this.cbCalabreza.Text = "Calabreza";
            this.cbCalabreza.UseVisualStyleBackColor = true;
            this.cbCalabreza.CheckedChanged += new System.EventHandler(this.cbCalabreza_CheckedChanged);
            // 
            // txtTomate
            // 
            this.txtTomate.Location = new System.Drawing.Point(103, 131);
            this.txtTomate.Name = "txtTomate";
            this.txtTomate.Size = new System.Drawing.Size(61, 20);
            this.txtTomate.TabIndex = 34;
            this.txtTomate.Text = "1,00";
            this.txtTomate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbTomate
            // 
            this.cbTomate.AutoSize = true;
            this.cbTomate.Location = new System.Drawing.Point(14, 131);
            this.cbTomate.Name = "cbTomate";
            this.cbTomate.Size = new System.Drawing.Size(62, 17);
            this.cbTomate.TabIndex = 4;
            this.cbTomate.Text = "Tomate";
            this.cbTomate.UseVisualStyleBackColor = true;
            this.cbTomate.CheckedChanged += new System.EventHandler(this.cbTomate_CheckedChanged);
            // 
            // txtCebola
            // 
            this.txtCebola.Location = new System.Drawing.Point(103, 105);
            this.txtCebola.Name = "txtCebola";
            this.txtCebola.Size = new System.Drawing.Size(61, 20);
            this.txtCebola.TabIndex = 32;
            this.txtCebola.Text = "0,50";
            this.txtCebola.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbCebola
            // 
            this.cbCebola.AutoSize = true;
            this.cbCebola.Location = new System.Drawing.Point(14, 103);
            this.cbCebola.Name = "cbCebola";
            this.cbCebola.Size = new System.Drawing.Size(59, 17);
            this.cbCebola.TabIndex = 3;
            this.cbCebola.Text = "Cebola";
            this.cbCebola.UseVisualStyleBackColor = true;
            this.cbCebola.CheckedChanged += new System.EventHandler(this.cbCebola_CheckedChanged);
            // 
            // txtAzeitona
            // 
            this.txtAzeitona.Location = new System.Drawing.Point(103, 76);
            this.txtAzeitona.Name = "txtAzeitona";
            this.txtAzeitona.Size = new System.Drawing.Size(61, 20);
            this.txtAzeitona.TabIndex = 30;
            this.txtAzeitona.Text = "1,50";
            this.txtAzeitona.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbAzeitona
            // 
            this.cbAzeitona.AutoSize = true;
            this.cbAzeitona.Location = new System.Drawing.Point(14, 75);
            this.cbAzeitona.Name = "cbAzeitona";
            this.cbAzeitona.Size = new System.Drawing.Size(67, 17);
            this.cbAzeitona.TabIndex = 2;
            this.cbAzeitona.Text = "Azeitona";
            this.cbAzeitona.UseVisualStyleBackColor = true;
            this.cbAzeitona.CheckedChanged += new System.EventHandler(this.cbAzeitona_CheckedChanged);
            // 
            // txtCagumelo
            // 
            this.txtCagumelo.Location = new System.Drawing.Point(103, 45);
            this.txtCagumelo.Name = "txtCagumelo";
            this.txtCagumelo.Size = new System.Drawing.Size(61, 20);
            this.txtCagumelo.TabIndex = 28;
            this.txtCagumelo.Text = "3,00";
            this.txtCagumelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbCogumelo
            // 
            this.cbCogumelo.AutoSize = true;
            this.cbCogumelo.Location = new System.Drawing.Point(14, 47);
            this.cbCogumelo.Name = "cbCogumelo";
            this.cbCogumelo.Size = new System.Drawing.Size(73, 17);
            this.cbCogumelo.TabIndex = 1;
            this.cbCogumelo.Text = "Cogumelo";
            this.cbCogumelo.UseVisualStyleBackColor = true;
            this.cbCogumelo.CheckedChanged += new System.EventHandler(this.cbCogumelo_CheckedChanged);
            // 
            // txtQueijoExtra
            // 
            this.txtQueijoExtra.Location = new System.Drawing.Point(103, 16);
            this.txtQueijoExtra.Name = "txtQueijoExtra";
            this.txtQueijoExtra.Size = new System.Drawing.Size(61, 20);
            this.txtQueijoExtra.TabIndex = 26;
            this.txtQueijoExtra.Text = "2,00";
            this.txtQueijoExtra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbQueijoExtra
            // 
            this.cbQueijoExtra.AutoSize = true;
            this.cbQueijoExtra.Location = new System.Drawing.Point(14, 19);
            this.cbQueijoExtra.Name = "cbQueijoExtra";
            this.cbQueijoExtra.Size = new System.Drawing.Size(83, 17);
            this.cbQueijoExtra.TabIndex = 0;
            this.cbQueijoExtra.Text = "Queijo Extra";
            this.cbQueijoExtra.UseVisualStyleBackColor = true;
            this.cbQueijoExtra.CheckedChanged += new System.EventHandler(this.cbQueijoExtra_CheckedChanged);
            // 
            // gBoxTamanho
            // 
            this.gBoxTamanho.Controls.Add(this.txtGrande);
            this.gBoxTamanho.Controls.Add(this.txtMedia);
            this.gBoxTamanho.Controls.Add(this.txtPequena);
            this.gBoxTamanho.Controls.Add(this.rbGrande);
            this.gBoxTamanho.Controls.Add(this.rbMedia);
            this.gBoxTamanho.Controls.Add(this.rbPequena);
            this.gBoxTamanho.Location = new System.Drawing.Point(727, 80);
            this.gBoxTamanho.Name = "gBoxTamanho";
            this.gBoxTamanho.Size = new System.Drawing.Size(179, 100);
            this.gBoxTamanho.TabIndex = 2;
            this.gBoxTamanho.TabStop = false;
            this.gBoxTamanho.Text = "Tamanho";
            // 
            // txtGrande
            // 
            this.txtGrande.Location = new System.Drawing.Point(101, 68);
            this.txtGrande.Name = "txtGrande";
            this.txtGrande.Size = new System.Drawing.Size(61, 20);
            this.txtGrande.TabIndex = 23;
            this.txtGrande.Text = "30,00";
            this.txtGrande.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(101, 42);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(61, 20);
            this.txtMedia.TabIndex = 22;
            this.txtMedia.Text = "25,00";
            this.txtMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPequena
            // 
            this.txtPequena.Location = new System.Drawing.Point(101, 16);
            this.txtPequena.Name = "txtPequena";
            this.txtPequena.Size = new System.Drawing.Size(61, 20);
            this.txtPequena.TabIndex = 21;
            this.txtPequena.Text = "20,00";
            this.txtPequena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rbGrande
            // 
            this.rbGrande.AutoSize = true;
            this.rbGrande.Location = new System.Drawing.Point(14, 70);
            this.rbGrande.Name = "rbGrande";
            this.rbGrande.Size = new System.Drawing.Size(60, 17);
            this.rbGrande.TabIndex = 2;
            this.rbGrande.TabStop = true;
            this.rbGrande.Text = "Grande";
            this.rbGrande.UseVisualStyleBackColor = true;
            this.rbGrande.CheckedChanged += new System.EventHandler(this.rbGrande_CheckedChanged);
            // 
            // rbMedia
            // 
            this.rbMedia.AutoSize = true;
            this.rbMedia.Location = new System.Drawing.Point(14, 44);
            this.rbMedia.Name = "rbMedia";
            this.rbMedia.Size = new System.Drawing.Size(54, 17);
            this.rbMedia.TabIndex = 1;
            this.rbMedia.TabStop = true;
            this.rbMedia.Text = "Média";
            this.rbMedia.UseVisualStyleBackColor = true;
            this.rbMedia.CheckedChanged += new System.EventHandler(this.rbMedia_CheckedChanged);
            // 
            // rbPequena
            // 
            this.rbPequena.AutoSize = true;
            this.rbPequena.Location = new System.Drawing.Point(14, 18);
            this.rbPequena.Name = "rbPequena";
            this.rbPequena.Size = new System.Drawing.Size(68, 17);
            this.rbPequena.TabIndex = 0;
            this.rbPequena.TabStop = true;
            this.rbPequena.Text = "Pequena";
            this.rbPequena.UseVisualStyleBackColor = true;
            this.rbPequena.CheckedChanged += new System.EventHandler(this.rbPequena_CheckedChanged);
            // 
            // btGerarPedido
            // 
            this.btGerarPedido.Location = new System.Drawing.Point(821, 579);
            this.btGerarPedido.Name = "btGerarPedido";
            this.btGerarPedido.Size = new System.Drawing.Size(90, 28);
            this.btGerarPedido.TabIndex = 2;
            this.btGerarPedido.Text = "Confirmar";
            this.btGerarPedido.UseVisualStyleBackColor = true;
            this.btGerarPedido.Click += new System.EventHandler(this.btGerarPedido_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Descrição da Pizza";
            // 
            // btMontarPizza
            // 
            this.btMontarPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMontarPizza.Image = global::SystemPizzaria.Properties.Resources.Montar1;
            this.btMontarPizza.Location = new System.Drawing.Point(661, 87);
            this.btMontarPizza.Name = "btMontarPizza";
            this.btMontarPizza.Size = new System.Drawing.Size(51, 524);
            this.btMontarPizza.TabIndex = 0;
            this.btMontarPizza.UseVisualStyleBackColor = true;
            this.btMontarPizza.Click += new System.EventHandler(this.btMontarPizza_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(12, 400);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(643, 211);
            this.txtDescricao.TabIndex = 11;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 622);
            this.Controls.Add(this.panel4);
            this.KeyPreview = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza - Pedidos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrincipal_KeyDown);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gBoxTamanho.ResumeLayout(false);
            this.gBoxTamanho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btCancelarPedido;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxDesconto;
        private System.Windows.Forms.TextBox txtEncargo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtxtCEP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btProcurarCliente;
        private System.Windows.Forms.MaskedTextBox mtxtFone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBorda;
        private System.Windows.Forms.TextBox txtEntregar;
        private System.Windows.Forms.CheckBox cbBorda;
        private System.Windows.Forms.CheckBox cbEntregar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCamarao;
        private System.Windows.Forms.CheckBox cbCamarao;
        private System.Windows.Forms.TextBox txtPresunto;
        private System.Windows.Forms.CheckBox cbPresunto;
        private System.Windows.Forms.TextBox txtOvo;
        private System.Windows.Forms.CheckBox cbOvo;
        private System.Windows.Forms.TextBox txtCalabreza;
        private System.Windows.Forms.CheckBox cbCalabreza;
        private System.Windows.Forms.TextBox txtTomate;
        private System.Windows.Forms.CheckBox cbTomate;
        private System.Windows.Forms.TextBox txtCebola;
        private System.Windows.Forms.CheckBox cbCebola;
        private System.Windows.Forms.TextBox txtAzeitona;
        private System.Windows.Forms.CheckBox cbAzeitona;
        private System.Windows.Forms.TextBox txtCagumelo;
        private System.Windows.Forms.CheckBox cbCogumelo;
        private System.Windows.Forms.TextBox txtQueijoExtra;
        private System.Windows.Forms.CheckBox cbQueijoExtra;
        private System.Windows.Forms.GroupBox gBoxTamanho;
        private System.Windows.Forms.TextBox txtGrande;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtPequena;
        private System.Windows.Forms.RadioButton rbGrande;
        private System.Windows.Forms.RadioButton rbMedia;
        private System.Windows.Forms.RadioButton rbPequena;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btMontarPizza;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btGerarPedido;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

