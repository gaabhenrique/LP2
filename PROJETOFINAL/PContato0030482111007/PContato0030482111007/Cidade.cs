using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PCidade
{
    class Cidade
    {

        private int idcidade;
        private string nomecidade;
        private string ufcidade;

        public int Idcidade
        {
            get
            {
                return idcidade;
            }
            set
            {
                idcidade = value;
            }
        }


        public string Nomecidade
        {
            get
            {
                return nomecidade;
            }
            set
            {
                nomecidade = value;
            }
        }



        public string Ufcidade
        {
            get
            {
                return ufcidade;
            }
            set
            {
                ufcidade = value;
            }
        }

        public DataTable Listar()
        {
            SqlDataAdapter daCidade;

            DataTable dtCidade = new DataTable();

            try
            {
                daCidade = new SqlDataAdapter("SELECT * FROM CIDADE", frmPrincipal.conexao);
                daCidade.Fill(dtCidade);
                daCidade.FillSchema(dtCidade, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtCidade;
        }



        public int Salvar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                int nReg;

                mycommand = new SqlCommand("INSERT INTO CIDADE VALUES (@nome_cidade,@uf_cidade)", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@nome_cidade", SqlDbType.VarChar)); ;
                mycommand.Parameters.Add(new SqlParameter("@uf_cidade", SqlDbType.VarChar));

                mycommand.Parameters["@nome_cidade"].Value = nomecidade;
                mycommand.Parameters["@uf_cidade"].Value = ufcidade;

                nReg = mycommand.ExecuteNonQuery();

                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }
    }
}


