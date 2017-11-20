using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Sistema_CrudAlunos
{
    public partial class frm_Crud : Form
    {
        public frm_Crud()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dataHora = DateTime.Now;
            lbDateTime.Text = "Data: " + dataHora.ToShortDateString() + " Hora: " + dataHora.ToLongTimeString() ;
        }

        private void frm_Crud_Load(object sender, EventArgs e)
        {
            timer1_Tick(e, e);
            //sisDBADM test = new sisDBADM();
            //if (test.conectar())
            //{
            //    MessageBox.Show("Conectou");
            //}
            //else
            //{
            //    MessageBox.Show("Não Conectou");
            //}
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void TestDB()
        {
            sisDBADM obj = new sisDBADM();
            ArrayList arr = new ArrayList();
            try
            {
                //    arr.Add(1);
                //    arr.Add("COXINHA");
                //    arr.Add("300");
                //    arr.Add("Vale do silicio");
                //    arr.Add("32546987");
                //    arr.Add("gume@cino.com");
                //    arr.Add("California");
                //    arr.Add("CA");
                //    arr.Add("DERp");
                //    arr.Add("DErpina");
                int codAluno = 2;
                if (obj.Delete(codAluno))
                {
                    MessageBox.Show("Deletado com Sucesso!!!","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro + " Erro OCORRIDO");
            }
        }

        private void bt_CadAluno_Click(object sender, EventArgs e)
        {
            sisDBADM obj = new sisDBADM();
            ArrayList arr = new ArrayList();
            try
            {
                arr.Add("COXINHA");
                arr.Add("300");
                arr.Add("Vale do silicio");
                arr.Add("32546987");
                arr.Add("gume@cino.com");
                arr.Add("California");
                arr.Add("CA");
                arr.Add("DERp");
                arr.Add("DErpina");

                if (obj.Insert(arr))
                {
                    MessageBox.Show("Cadastrado com Sucesso!!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro + " Erro OCORRIDO");
            }
        }

        private void bt_AtualizarAluno_Click(object sender, EventArgs e)
        {
            sisDBADM obj = new sisDBADM();
            ArrayList arr = new ArrayList();
            try
            {
                arr.Add(1);
                arr.Add("COXINHA");
                arr.Add("300");
                arr.Add("Vale do silicio");
                arr.Add("32546987");
                arr.Add("gume@cino.com");
                arr.Add("California");
                arr.Add("CA");
                arr.Add("DERp");
                arr.Add("DErpina");

                if (obj.Update(arr))
                {
                    MessageBox.Show("Atualizado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao Atualizar Aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro + " Erro OCORRIDO");
            }
        }

        private void bt_deleteAluno_Click(object sender, EventArgs e)
        {
            sisDBADM obj = new sisDBADM();
            try
            {
                int codAluno = int.Parse(tb_Excluir.Text);
                if (obj.Delete(codAluno))
                {
                    MessageBox.Show("Deletado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgExcluirAluno_Enter(e, e);
                }
                else
                {
                    MessageBox.Show("Erro ao Apagar Aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro + " Erro OCORRIDO");
            }
        }

        private void dgEditarAluno_Enter(object sender, EventArgs e)
        {
            sisDBADM obj = new sisDBADM();
            dgEditarAluno.DataSource = obj.ListaGrid();
        }

        private void bt_pesquisa_Click(object sender, EventArgs e)
        {
            sisDBADM obj = new sisDBADM();
            string sql;
            if (rb_Nome.Checked)
            {
                sql = "SELECT [NOME] as Nome,[IDADE] as Idade,[ENDERECO] as Endereço,[TELEFONE] as Telefone,[EMAIL] as Email FROM CURD_ALUNOS WHERE NOME LIKE @VALOR";
                dgPesquisarAluno.DataSource =  obj.Pesquisar(sql, "%"+tb_pesquisar.Text+"%");
            }else
            {
                sql = "SELECT [NOME] as Nome,[IDADE] as Idade,[ENDERECO] as Endereço,[TELEFONE] as Telefone,[EMAIL] as Email FROM CURD_ALUNOS WHERE ID_ALUNO LIKE @VALOR";
                dgPesquisarAluno.DataSource = obj.Pesquisar(sql, tb_pesquisar.Text);
            }
            //obj.Pesquisar()
            //dgEditarAluno.DataSource = obj.ListaGrid();
        }

        private void dgExcluirAluno_Enter(object sender, EventArgs e)
        {
            sisDBADM obj = new sisDBADM();
             dgExcluirAluno.DataSource = obj.ListaGrid();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
