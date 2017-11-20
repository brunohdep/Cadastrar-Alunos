namespace Sistema_CrudAlunos
{
    partial class frm_Crud
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Crud));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bt_CadAluno = new System.Windows.Forms.ToolStripButton();
            this.bt_AtualizarAluno = new System.Windows.Forms.ToolStripButton();
            this.bt_deleteAluno = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.bt_Sair = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbCad_CIdade = new System.Windows.Forms.ComboBox();
            this.cbCad_UF = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.tbCad_Mae = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCad_Tel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCad_Idade = new System.Windows.Forms.TextBox();
            this.tbCad_Ida = new System.Windows.Forms.Label();
            this.tbCad_Pai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCad_Mail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCad_Endereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCad_Nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgAddAluno = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbEd_Cod = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbEd_Cidade = new System.Windows.Forms.ComboBox();
            this.cbEd_UF = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEd_Mae = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbEd_Tel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbEd_Idade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbEd_Pai = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbEd_Mail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbEd_Endereco = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbEd_Nome = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dgEditarAluno = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Excluir = new System.Windows.Forms.TextBox();
            this.dgExcluirAluno = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gpPesquisarAluno = new System.Windows.Forms.GroupBox();
            this.lbDigite = new System.Windows.Forms.Label();
            this.gbTipoDePesquisa = new System.Windows.Forms.GroupBox();
            this.rb_codigo = new System.Windows.Forms.RadioButton();
            this.rb_Nome = new System.Windows.Forms.RadioButton();
            this.tb_pesquisar = new System.Windows.Forms.TextBox();
            this.bt_pesquisa = new System.Windows.Forms.Button();
            this.dgPesquisarAluno = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddAluno)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEditarAluno)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExcluirAluno)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.gpPesquisarAluno.SuspendLayout();
            this.gbTipoDePesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisarAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 484);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 80);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_CadAluno,
            this.bt_AtualizarAluno,
            this.bt_deleteAluno,
            this.toolStripSeparator1,
            this.toolStripButton4,
            this.bt_Sair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 19);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(661, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bt_CadAluno
            // 
            this.bt_CadAluno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_CadAluno.Image = ((System.Drawing.Image)(resources.GetObject("bt_CadAluno.Image")));
            this.bt_CadAluno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_CadAluno.Name = "bt_CadAluno";
            this.bt_CadAluno.Size = new System.Drawing.Size(36, 36);
            this.bt_CadAluno.Text = "toolStripButton1";
            this.bt_CadAluno.Click += new System.EventHandler(this.bt_CadAluno_Click);
            // 
            // bt_AtualizarAluno
            // 
            this.bt_AtualizarAluno.BackColor = System.Drawing.Color.Transparent;
            this.bt_AtualizarAluno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_AtualizarAluno.Image = ((System.Drawing.Image)(resources.GetObject("bt_AtualizarAluno.Image")));
            this.bt_AtualizarAluno.ImageTransparentColor = System.Drawing.Color.White;
            this.bt_AtualizarAluno.Name = "bt_AtualizarAluno";
            this.bt_AtualizarAluno.Size = new System.Drawing.Size(36, 36);
            this.bt_AtualizarAluno.Text = "toolStripButton2";
            this.bt_AtualizarAluno.Click += new System.EventHandler(this.bt_AtualizarAluno_Click);
            // 
            // bt_deleteAluno
            // 
            this.bt_deleteAluno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_deleteAluno.Image = ((System.Drawing.Image)(resources.GetObject("bt_deleteAluno.Image")));
            this.bt_deleteAluno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_deleteAluno.Name = "bt_deleteAluno";
            this.bt_deleteAluno.Size = new System.Drawing.Size(36, 36);
            this.bt_deleteAluno.Text = "toolStripButton3";
            this.bt_deleteAluno.Click += new System.EventHandler(this.bt_deleteAluno_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // bt_Sair
            // 
            this.bt_Sair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bt_Sair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_Sair.Image = ((System.Drawing.Image)(resources.GetObject("bt_Sair.Image")));
            this.bt_Sair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(36, 36);
            this.bt_Sair.Text = "toolStripButton5";
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 58);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(661, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbDateTime
            // 
            this.lbDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(68, 17);
            this.lbDateTime.Text = "lbDataTime";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 484);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(657, 480);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbCad_CIdade);
            this.tabPage1.Controls.Add(this.cbCad_UF);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.textBox8);
            this.tabPage1.Controls.Add(this.tbCad_Mae);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.tbCad_Tel);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tbCad_Idade);
            this.tabPage1.Controls.Add(this.tbCad_Ida);
            this.tabPage1.Controls.Add(this.tbCad_Pai);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tbCad_Mail);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbCad_Endereco);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbCad_Nome);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dgAddAluno);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(649, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adicionar Aluno";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // cbCad_CIdade
            // 
            this.cbCad_CIdade.FormattingEnabled = true;
            this.cbCad_CIdade.Location = new System.Drawing.Point(315, 177);
            this.cbCad_CIdade.Name = "cbCad_CIdade";
            this.cbCad_CIdade.Size = new System.Drawing.Size(166, 24);
            this.cbCad_CIdade.TabIndex = 19;
            // 
            // cbCad_UF
            // 
            this.cbCad_UF.FormattingEnabled = true;
            this.cbCad_UF.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06"});
            this.cbCad_UF.Location = new System.Drawing.Point(258, 177);
            this.cbCad_UF.Name = "cbCad_UF";
            this.cbCad_UF.Size = new System.Drawing.Size(50, 24);
            this.cbCad_UF.TabIndex = 18;
            this.cbCad_UF.SelectedIndexChanged += new System.EventHandler(this.cbCad_UF_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(312, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Cidade";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(258, 241);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(226, 22);
            this.textBox8.TabIndex = 16;
            // 
            // tbCad_Mae
            // 
            this.tbCad_Mae.AutoSize = true;
            this.tbCad_Mae.Location = new System.Drawing.Point(255, 222);
            this.tbCad_Mae.Name = "tbCad_Mae";
            this.tbCad_Mae.Size = new System.Drawing.Size(78, 16);
            this.tbCad_Mae.TabIndex = 15;
            this.tbCad_Mae.Text = "Nome da Mae";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "UF";
            // 
            // tbCad_Tel
            // 
            this.tbCad_Tel.Location = new System.Drawing.Point(258, 119);
            this.tbCad_Tel.Name = "tbCad_Tel";
            this.tbCad_Tel.Size = new System.Drawing.Size(100, 22);
            this.tbCad_Tel.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Telefone";
            // 
            // tbCad_Idade
            // 
            this.tbCad_Idade.Location = new System.Drawing.Point(258, 63);
            this.tbCad_Idade.Name = "tbCad_Idade";
            this.tbCad_Idade.Size = new System.Drawing.Size(100, 22);
            this.tbCad_Idade.TabIndex = 10;
            // 
            // tbCad_Ida
            // 
            this.tbCad_Ida.AutoSize = true;
            this.tbCad_Ida.Location = new System.Drawing.Point(255, 44);
            this.tbCad_Ida.Name = "tbCad_Ida";
            this.tbCad_Ida.Size = new System.Drawing.Size(38, 16);
            this.tbCad_Ida.TabIndex = 9;
            this.tbCad_Ida.Text = "Idade";
            // 
            // tbCad_Pai
            // 
            this.tbCad_Pai.Location = new System.Drawing.Point(26, 241);
            this.tbCad_Pai.Name = "tbCad_Pai";
            this.tbCad_Pai.Size = new System.Drawing.Size(226, 22);
            this.tbCad_Pai.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nome do Pai";
            // 
            // tbCad_Mail
            // 
            this.tbCad_Mail.Location = new System.Drawing.Point(26, 177);
            this.tbCad_Mail.Name = "tbCad_Mail";
            this.tbCad_Mail.Size = new System.Drawing.Size(226, 22);
            this.tbCad_Mail.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // tbCad_Endereco
            // 
            this.tbCad_Endereco.Location = new System.Drawing.Point(26, 119);
            this.tbCad_Endereco.Name = "tbCad_Endereco";
            this.tbCad_Endereco.Size = new System.Drawing.Size(226, 22);
            this.tbCad_Endereco.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Endereço";
            // 
            // tbCad_Nome
            // 
            this.tbCad_Nome.Location = new System.Drawing.Point(26, 63);
            this.tbCad_Nome.Name = "tbCad_Nome";
            this.tbCad_Nome.Size = new System.Drawing.Size(226, 22);
            this.tbCad_Nome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // dgAddAluno
            // 
            this.dgAddAluno.AllowUserToAddRows = false;
            this.dgAddAluno.AllowUserToDeleteRows = false;
            this.dgAddAluno.BackgroundColor = System.Drawing.Color.White;
            this.dgAddAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAddAluno.Location = new System.Drawing.Point(3, 325);
            this.dgAddAluno.Name = "dgAddAluno";
            this.dgAddAluno.ReadOnly = true;
            this.dgAddAluno.Size = new System.Drawing.Size(579, 123);
            this.dgAddAluno.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbEd_Cod);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.cbEd_Cidade);
            this.tabPage2.Controls.Add(this.cbEd_UF);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tbEd_Mae);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.tbEd_Tel);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.tbEd_Idade);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.tbEd_Pai);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.tbEd_Mail);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.tbEd_Endereco);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.tbEd_Nome);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.dgEditarAluno);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(649, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar Aluno";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // tbEd_Cod
            // 
            this.tbEd_Cod.Location = new System.Drawing.Point(21, 38);
            this.tbEd_Cod.Name = "tbEd_Cod";
            this.tbEd_Cod.Size = new System.Drawing.Size(99, 22);
            this.tbEd_Cod.TabIndex = 39;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 16);
            this.label18.TabIndex = 38;
            this.label18.Text = "Código";
            // 
            // cbEd_Cidade
            // 
            this.cbEd_Cidade.FormattingEnabled = true;
            this.cbEd_Cidade.Location = new System.Drawing.Point(315, 142);
            this.cbEd_Cidade.Name = "cbEd_Cidade";
            this.cbEd_Cidade.Size = new System.Drawing.Size(166, 24);
            this.cbEd_Cidade.TabIndex = 37;
            // 
            // cbEd_UF
            // 
            this.cbEd_UF.FormattingEnabled = true;
            this.cbEd_UF.Location = new System.Drawing.Point(258, 142);
            this.cbEd_UF.Name = "cbEd_UF";
            this.cbEd_UF.Size = new System.Drawing.Size(50, 24);
            this.cbEd_UF.TabIndex = 36;
            this.cbEd_UF.SelectedIndexChanged += new System.EventHandler(this.cbEd_UF_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Cidade";
            // 
            // tbEd_Mae
            // 
            this.tbEd_Mae.Location = new System.Drawing.Point(21, 144);
            this.tbEd_Mae.Name = "tbEd_Mae";
            this.tbEd_Mae.Size = new System.Drawing.Size(226, 22);
            this.tbEd_Mae.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Nome da Mae";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(255, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "UF";
            // 
            // tbEd_Tel
            // 
            this.tbEd_Tel.Location = new System.Drawing.Point(257, 89);
            this.tbEd_Tel.Name = "tbEd_Tel";
            this.tbEd_Tel.Size = new System.Drawing.Size(100, 22);
            this.tbEd_Tel.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(254, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "Telefone";
            // 
            // tbEd_Idade
            // 
            this.tbEd_Idade.Location = new System.Drawing.Point(362, 38);
            this.tbEd_Idade.Name = "tbEd_Idade";
            this.tbEd_Idade.Size = new System.Drawing.Size(100, 22);
            this.tbEd_Idade.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(355, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "Idade";
            // 
            // tbEd_Pai
            // 
            this.tbEd_Pai.Location = new System.Drawing.Point(21, 194);
            this.tbEd_Pai.Name = "tbEd_Pai";
            this.tbEd_Pai.Size = new System.Drawing.Size(226, 22);
            this.tbEd_Pai.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "Nome do Pai";
            // 
            // tbEd_Mail
            // 
            this.tbEd_Mail.Location = new System.Drawing.Point(363, 89);
            this.tbEd_Mail.Name = "tbEd_Mail";
            this.tbEd_Mail.Size = new System.Drawing.Size(226, 22);
            this.tbEd_Mail.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(360, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 16);
            this.label15.TabIndex = 24;
            this.label15.Text = "Email";
            // 
            // tbEd_Endereco
            // 
            this.tbEd_Endereco.Location = new System.Drawing.Point(21, 89);
            this.tbEd_Endereco.Name = "tbEd_Endereco";
            this.tbEd_Endereco.Size = new System.Drawing.Size(226, 22);
            this.tbEd_Endereco.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 16);
            this.label16.TabIndex = 22;
            this.label16.Text = "Endereço";
            // 
            // tbEd_Nome
            // 
            this.tbEd_Nome.Location = new System.Drawing.Point(130, 38);
            this.tbEd_Nome.Name = "tbEd_Nome";
            this.tbEd_Nome.Size = new System.Drawing.Size(226, 22);
            this.tbEd_Nome.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(123, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 16);
            this.label17.TabIndex = 20;
            this.label17.Text = "Nome";
            // 
            // dgEditarAluno
            // 
            this.dgEditarAluno.AllowUserToAddRows = false;
            this.dgEditarAluno.AllowUserToDeleteRows = false;
            this.dgEditarAluno.BackgroundColor = System.Drawing.Color.White;
            this.dgEditarAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEditarAluno.GridColor = System.Drawing.SystemColors.Control;
            this.dgEditarAluno.Location = new System.Drawing.Point(0, 222);
            this.dgEditarAluno.Name = "dgEditarAluno";
            this.dgEditarAluno.ReadOnly = true;
            this.dgEditarAluno.Size = new System.Drawing.Size(646, 229);
            this.dgEditarAluno.TabIndex = 1;
            this.dgEditarAluno.Enter += new System.EventHandler(this.dgEditarAluno_Enter);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.dgExcluirAluno);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(649, 451);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Excluir Aluno";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_Excluir);
            this.groupBox1.Location = new System.Drawing.Point(6, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 99);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excluir Aluno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código do Aluno";
            // 
            // tb_Excluir
            // 
            this.tb_Excluir.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Excluir.Location = new System.Drawing.Point(6, 59);
            this.tb_Excluir.Name = "tb_Excluir";
            this.tb_Excluir.Size = new System.Drawing.Size(143, 25);
            this.tb_Excluir.TabIndex = 4;
            // 
            // dgExcluirAluno
            // 
            this.dgExcluirAluno.AllowUserToAddRows = false;
            this.dgExcluirAluno.AllowUserToDeleteRows = false;
            this.dgExcluirAluno.BackgroundColor = System.Drawing.Color.White;
            this.dgExcluirAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExcluirAluno.Location = new System.Drawing.Point(1, 161);
            this.dgExcluirAluno.Name = "dgExcluirAluno";
            this.dgExcluirAluno.ReadOnly = true;
            this.dgExcluirAluno.Size = new System.Drawing.Size(757, 287);
            this.dgExcluirAluno.TabIndex = 1;
            this.dgExcluirAluno.Enter += new System.EventHandler(this.dgExcluirAluno_Enter);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gpPesquisarAluno);
            this.tabPage4.Controls.Add(this.dgPesquisarAluno);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(649, 451);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Pesquisar Aluno";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gpPesquisarAluno
            // 
            this.gpPesquisarAluno.Controls.Add(this.lbDigite);
            this.gpPesquisarAluno.Controls.Add(this.gbTipoDePesquisa);
            this.gpPesquisarAluno.Controls.Add(this.tb_pesquisar);
            this.gpPesquisarAluno.Controls.Add(this.bt_pesquisa);
            this.gpPesquisarAluno.Location = new System.Drawing.Point(0, 3);
            this.gpPesquisarAluno.Name = "gpPesquisarAluno";
            this.gpPesquisarAluno.Size = new System.Drawing.Size(753, 100);
            this.gpPesquisarAluno.TabIndex = 6;
            this.gpPesquisarAluno.TabStop = false;
            this.gpPesquisarAluno.Text = "Pesquisar Aluno";
            // 
            // lbDigite
            // 
            this.lbDigite.AutoSize = true;
            this.lbDigite.Location = new System.Drawing.Point(6, 41);
            this.lbDigite.Name = "lbDigite";
            this.lbDigite.Size = new System.Drawing.Size(155, 16);
            this.lbDigite.TabIndex = 5;
            this.lbDigite.Text = "Digite o valor para pesquisa";
            // 
            // gbTipoDePesquisa
            // 
            this.gbTipoDePesquisa.Controls.Add(this.rb_codigo);
            this.gbTipoDePesquisa.Controls.Add(this.rb_Nome);
            this.gbTipoDePesquisa.Location = new System.Drawing.Point(624, 3);
            this.gbTipoDePesquisa.Name = "gbTipoDePesquisa";
            this.gbTipoDePesquisa.Size = new System.Drawing.Size(125, 100);
            this.gbTipoDePesquisa.TabIndex = 4;
            this.gbTipoDePesquisa.TabStop = false;
            this.gbTipoDePesquisa.Text = "Tipo de Pesquisa";
            // 
            // rb_codigo
            // 
            this.rb_codigo.AutoSize = true;
            this.rb_codigo.Location = new System.Drawing.Point(17, 64);
            this.rb_codigo.Name = "rb_codigo";
            this.rb_codigo.Size = new System.Drawing.Size(86, 20);
            this.rb_codigo.TabIndex = 5;
            this.rb_codigo.Text = "Por Código";
            this.rb_codigo.UseVisualStyleBackColor = true;
            // 
            // rb_Nome
            // 
            this.rb_Nome.AutoSize = true;
            this.rb_Nome.Checked = true;
            this.rb_Nome.Location = new System.Drawing.Point(17, 38);
            this.rb_Nome.Name = "rb_Nome";
            this.rb_Nome.Size = new System.Drawing.Size(77, 20);
            this.rb_Nome.TabIndex = 4;
            this.rb_Nome.TabStop = true;
            this.rb_Nome.Text = "Por Nome";
            this.rb_Nome.UseVisualStyleBackColor = true;
            // 
            // tb_pesquisar
            // 
            this.tb_pesquisar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pesquisar.Location = new System.Drawing.Point(9, 68);
            this.tb_pesquisar.Name = "tb_pesquisar";
            this.tb_pesquisar.Size = new System.Drawing.Size(405, 25);
            this.tb_pesquisar.TabIndex = 3;
            // 
            // bt_pesquisa
            // 
            this.bt_pesquisa.Location = new System.Drawing.Point(420, 67);
            this.bt_pesquisa.Name = "bt_pesquisa";
            this.bt_pesquisa.Size = new System.Drawing.Size(75, 26);
            this.bt_pesquisa.TabIndex = 2;
            this.bt_pesquisa.Text = "Pesquisar";
            this.bt_pesquisa.UseVisualStyleBackColor = true;
            this.bt_pesquisa.Click += new System.EventHandler(this.bt_pesquisa_Click);
            // 
            // dgPesquisarAluno
            // 
            this.dgPesquisarAluno.AllowUserToAddRows = false;
            this.dgPesquisarAluno.AllowUserToDeleteRows = false;
            this.dgPesquisarAluno.BackgroundColor = System.Drawing.Color.White;
            this.dgPesquisarAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPesquisarAluno.GridColor = System.Drawing.SystemColors.GrayText;
            this.dgPesquisarAluno.Location = new System.Drawing.Point(1, 164);
            this.dgPesquisarAluno.Name = "dgPesquisarAluno";
            this.dgPesquisarAluno.ReadOnly = true;
            this.dgPesquisarAluno.Size = new System.Drawing.Size(755, 287);
            this.dgPesquisarAluno.TabIndex = 1;
            // 
            // frm_Crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 564);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frm_Crud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Cadastro de Alunos";
            this.Load += new System.EventHandler(this.frm_Crud_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddAluno)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEditarAluno)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExcluirAluno)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.gpPesquisarAluno.ResumeLayout(false);
            this.gpPesquisarAluno.PerformLayout();
            this.gbTipoDePesquisa.ResumeLayout(false);
            this.gbTipoDePesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisarAluno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripStatusLabel lbDateTime;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ToolStripButton bt_CadAluno;
        private System.Windows.Forms.ToolStripButton bt_AtualizarAluno;
        private System.Windows.Forms.ToolStripButton bt_deleteAluno;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton bt_Sair;
        private System.Windows.Forms.DataGridView dgAddAluno;
        private System.Windows.Forms.DataGridView dgEditarAluno;
        private System.Windows.Forms.DataGridView dgExcluirAluno;
        private System.Windows.Forms.DataGridView dgPesquisarAluno;
        private System.Windows.Forms.RadioButton rb_codigo;
        private System.Windows.Forms.RadioButton rb_Nome;
        private System.Windows.Forms.TextBox tb_pesquisar;
        private System.Windows.Forms.Button bt_pesquisa;
        private System.Windows.Forms.GroupBox gpPesquisarAluno;
        private System.Windows.Forms.Label lbDigite;
        private System.Windows.Forms.GroupBox gbTipoDePesquisa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Excluir;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label tbCad_Mae;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCad_Tel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCad_Idade;
        private System.Windows.Forms.Label tbCad_Ida;
        private System.Windows.Forms.TextBox tbCad_Pai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCad_Mail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCad_Endereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCad_Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCad_UF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCad_CIdade;
        private System.Windows.Forms.TextBox tbEd_Cod;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbEd_Cidade;
        private System.Windows.Forms.ComboBox cbEd_UF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEd_Mae;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbEd_Tel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbEd_Idade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbEd_Pai;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbEd_Mail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbEd_Endereco;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbEd_Nome;
        private System.Windows.Forms.Label label17;
    }
}

