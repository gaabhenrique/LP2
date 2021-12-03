using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PCidade
{
    class Contato
    {
        public int IdContato { get; set; }
        public string NomeContato { get; set; }
        public string EndContato { get; set; }
        public int CidadeIdCidade { get; set; }
        public string CelContato { get; set; }
        public string EmailContato { get; set; }
        public DateTime DtCadastroContato { get; set; }

        public DataTable Listar()
        {
            SqlDataAdapter daContato;

            DataTable dtContato = new DataTable();

            try
            {
                daContato = new SqlDataAdapter("SELECT * FROM CONTATO", frmPrincipal.conexao);
                daContato.Fill(dtContato);
                daContato.FillSchema(dtContato, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtContato;
        }

        public int Salvar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("INSERT INTO CONTATO VALUES (@nomecontato,@endcontato,@cidadeidcidade," +
                "@celcontato,@emailcontato,@dtcadastrocontato)", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@nomecontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@endcontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@cidadeidcidade", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@celcontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@emailcontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@dtcadastrocontato", SqlDbType.Date));

                mycommand.Parameters["@nomecontato"].Value = NomeContato;
                mycommand.Parameters["@endcontato"].Value = EndContato;
                mycommand.Parameters["@cidadeidcidade"].Value = CidadeIdCidade;
                mycommand.Parameters["@celcontato"].Value = CelContato;
                mycommand.Parameters["@emailcontato"].Value = EmailContato;
                mycommand.Parameters["@dtcadastrocontato"].Value = DtCadastroContato;

                retorno = mycommand.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }

            return retorno;
        }

        public int Alterar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("UPDATE CONTATO SET NOME_CONTATO=@nomecontato,END_CONTATO=@endcontato," +
                " CIDADE_ID_CIDADE=@cidadeidcidade, CEL_CONTATO=@celcontato, EMAIL_CONTATO=@emailcontato," +
                " DTCADASTRO_CONTATO=@dtcadastrocontato WHERE ID_CONTATO = @idcontato", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@idcontato", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nomecontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@endcontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@cidadeidcidade", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@celcontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@emailcontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@dtcadastrocontato", SqlDbType.Date));

                mycommand.Parameters["@idcontato"].Value = IdContato;
                mycommand.Parameters["@nomecontato"].Value = NomeContato;
                mycommand.Parameters["@endcontato"].Value = EndContato;
                mycommand.Parameters["@cidadeidcidade"].Value = CidadeIdCidade;
                mycommand.Parameters["@celcontato"].Value = CelContato;
                mycommand.Parameters["@emailcontato"].Value = EmailContato;
                mycommand.Parameters["@dtcadastrocontato"].Value = DtCadastroContato;

                retorno = mycommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }
        public int Excluir()
        {
            int nReg = 0;

            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("DELETE FROM CONTATO WHERE ID_CONTATO=@idcontato", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@idcontato", SqlDbType.Int));
                mycommand.Parameters["@idcontato"].Value = IdContato;

                nReg = mycommand.ExecuteNonQuery();
            }

            catch (Exception)
            {
                throw;
            }

            return nReg;
        }
    }
}
