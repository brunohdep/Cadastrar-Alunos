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
            this.dgAddAluno = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgEditarAluno = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Excluir = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgExcluirAluno)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.gpPesquisarAluno.SuspendLayout();
            this.gbTipoDePesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisarAluno)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(768, 80);
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
            this.toolStrip1.Size = new System.Drawing.Size(768, 39);
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
            this.statusStrip1.Size = new System.Drawing.Size(768, 22);
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
            this.panel2.Size = new System.Drawing.Size(768, 484);
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
            this.tabControl1.Size = new System.Drawing.Size(764, 480);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgAddAluno);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(756, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adicionar Aluno";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgAddAluno
            // 
            this.dgAddAluno.AllowUserToAddRows = false;
            this.dgAddAluno.AllowUserToDeleteRows = false;
            this.dgAddAluno.BackgroundColor = System.Drawing.Color.White;
            this.dgAddAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAddAluno.Location = new System.Drawing.Point(3, 161);
            this.dgAddAluno.Name = "dgAddAluno";
            this.dgAddAluno.ReadOnly = true;
            this.dgAddAluno.Size = new System.Drawing.Size(883, 287);
            this.dgAddAluno.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgEditarAluno);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(756, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar Aluno";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgEditarAluno
            // 
            this.dgEditarAluno.AllowUserToAddRows = false;
            this.dgEditarAluno.AllowUserToDeleteRows = false;
            this.dgEditarAluno.BackgroundColor = System.Drawing.Color.White;
            this.dgEditarAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEditarAluno.GridColor = System.Drawing.SystemColors.Control;
            this.dgEditarAluno.Location = new System.Drawing.Point(0, 164);
            this.dgEditarAluno.Name = "dgEditarAluno";
            this.dgEditarAluno.ReadOnly = true;
            this.dgEditarAluno.Size = new System.Drawing.Size(756, 287);
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
            this.tabPage3.Size = new System.Drawing.Size(756, 451);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Excluir Aluno";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.tabPage4.Size = new System.Drawing.Size(756, 451);
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
            // frm_Crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 564);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgAddAluno)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEditarAluno)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgExcluirAluno)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.gpPesquisarAluno.ResumeLayout(false);
            this.gpPesquisarAluno.PerformLayout();
            this.gbTipoDePesquisa.ResumeLayout(false);
            this.gbTipoDePesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisarAluno)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

