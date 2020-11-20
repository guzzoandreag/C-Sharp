//Defini��o de T�tulo
dgvNome.Columns[0].HeaderText = "C�digo";

//Ocultar uma coluna
dgvNome.Columns[0].Visible = false;

//Largura da coluna
dgvNome.Columns[0].Width = 50;

//Alinhamento do texto na celula
dgvNome.Columns["ColunaNome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

//Formatar t�tulo do DataGridView
dgvNome.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);

//Alterar a cor da linha de grade
dgvNome.GridColor = Color.BlueViolet;

//Especificar a fonte
dgvNome.DefaultCellStyle.Font = new Font("Arial", 14);

//Especificar as cores de fundo e da fonte
dgvNome.DefaultCellStyle.ForeColor = Color.Blue;
dgvNome.DefaultCellStyle.BackColor = Color.Beige;

//Especificar as cores de fundo e da fonte das c�lulas selecionadas
dgvNome.DefaultCellStyle.SelectionForeColor = Color.Yellow;
dgvNome.DefaultCellStyle.SelectionBackColor = Color.Black;
 
//#####FORMATA��O NUM�RICA#####
//Data
dgvNome.Columns[0].DefaultCellStyle.Format = "d";
//Tempo
dgvNome.Columns[0].DefaultCellStyle.Format = "t";
//Moeda
dgvNome.Columns[0].DefaultCellStyle.Format = "C2";
//N�mero com casas decimais
dgvNome.Columns[0].DefaultCellStyle.Format = "N2";            