using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace Sistema_CrudAlunos
{
    class sisDBADM
    {
        private const string _strCon = @"Data Source=DESKTOP-SN37M4Q;Initial Catalog = CURD_ALUNOS; Integrated Security = True";
        private string vsql = "";
        SqlConnection objCon = null;
        #region "Metodos de conexão com o banco"
        public bool conectar()
        {
            objCon = new SqlConnection(_strCon);
            try
            {
                objCon.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool desconectar()
        {
            if (objCon.State != ConnectionState.Closed)
            {
                objCon.Close();
                return true;
            }
            else
            {
                objCon.Dispose();
                return false;
            }
        }
        #endregion
        #region "Métodos de Execução do SQL"
        public bool Insert(ArrayList p_Insert)
        {
            vsql="INSERT INTO CURD_ALUNOS ([NOME],[IDADE],[ENDERECO],[TELEFONE],[EMAIL],[CIDADE],[UF],[NOME_PAI],[Nome_MAE])"+
                    "VALUES(@NOME,@IDADE,@ENDERECO,@TELEFONE,@EMAIL,@CIDADE,@UF,@NOME_PAI,@Nome_MAE)";
            SqlCommand objcmd = null;
            if (this.conectar())
            {
                try
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.Add(new SqlParameter("@NOME", p_Insert[0]));
                    objcmd.Parameters.Add(new SqlParameter("@IDADE", p_Insert[1]));
                    objcmd.Parameters.Add(new SqlParameter("@ENDERECO", p_Insert[2]));
                    objcmd.Parameters.Add(new SqlParameter("@TELEFONE", p_Insert[3]));
                    objcmd.Parameters.Add(new SqlParameter("@EMAIL", p_Insert[4]));
                    objcmd.Parameters.Add(new SqlParameter("@CIDADE", p_Insert[5]));
                    objcmd.Parameters.Add(new SqlParameter("@UF", p_Insert[6]));
                    objcmd.Parameters.Add(new SqlParameter("@NOME_PAI", p_Insert[7]));
                    objcmd.Parameters.Add(new SqlParameter("@Nome_MAE", p_Insert[8]));

                    objcmd.ExecuteNonQuery();
                    return true;
                }
                catch(SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return false;
            }
        }
        public bool Update(ArrayList p_arrUpdate)
        {
            vsql = "UPDATE CURD_ALUNOS SET NOME = @NOME , IDADE = @IDADE , ENDERECO = @ENDERECO , TELEFONE = @TELEFONE  , EMAIL = @EMAIL , CIDADE = @CIDADE , UF = @UF , NOME_PAI = @NOME_PAI , Nome_MAE = @Nome_MAE WHERE ID_ALUNO = @ID_ALUNO";
             
            SqlCommand objcmd = null;
            if (this.conectar())
            {
                try
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.Add(new SqlParameter("@ID_ALUNO", p_arrUpdate[0]));
                    objcmd.Parameters.Add(new SqlParameter("@NOME", p_arrUpdate[1]));
                    objcmd.Parameters.Add(new SqlParameter("@IDADE", p_arrUpdate[2]));
                    objcmd.Parameters.Add(new SqlParameter("@ENDERECO", p_arrUpdate[3]));
                    objcmd.Parameters.Add(new SqlParameter("@TELEFONE", p_arrUpdate[4]));
                    objcmd.Parameters.Add(new SqlParameter("@EMAIL", p_arrUpdate[5]));
                    objcmd.Parameters.Add(new SqlParameter("@CIDADE", p_arrUpdate[6]));
                    objcmd.Parameters.Add(new SqlParameter("@UF", p_arrUpdate[7]));
                    objcmd.Parameters.Add(new SqlParameter("@NOME_PAI", p_arrUpdate[8]));
                    objcmd.Parameters.Add(new SqlParameter("@Nome_MAE", p_arrUpdate[9]));
                    

                    objcmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return false;
            }

        }
        public bool Delete(int id_aluno)
        {
            vsql = "DELETE FROM CURD_ALUNOS WHERE ID_ALUNO = @ID_ALUNO";

            SqlCommand objcmd = null;
            if (this.conectar())
            {
                try
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.AddWithValue("@ID_ALUNO", id_aluno);
                    objcmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return false;
            }
        }
        #endregion
        #region "Métodos que ListarGRid e Faz Pesquisa"
        public DataTable ListaGrid()
        {
            vsql = "SELECT [ID_ALUNO] as CÓDIGO, [NOME] as Nome,[IDADE] as Idade,[ENDERECO] as Endereço,[TELEFONE] as Telefone,[EMAIL] as Email FROM CURD_ALUNOS";

            SqlCommand objcmd = null;
            if (this.conectar())
            {
                try
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    SqlDataAdapter adp = new SqlDataAdapter(objcmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    return dt;
                }
                catch (SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return null;
            }
            return null;
        }
        public DataTable Pesquisar(string sql,string param)
        {
            this.vsql = sql;

            SqlCommand objcmd = null;
            if (this.conectar())
            {
                try
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.Add(new SqlParameter("@VALOR", param));
                    SqlDataAdapter adp = new SqlDataAdapter(objcmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    return dt;
                }
                catch (SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return null;
            }
            return null;
        }
        #endregion
    }
}
