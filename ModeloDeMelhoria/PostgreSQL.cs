using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using System.Data;

namespace ModeloDeMelhoria
{
    class PostgreSQL
    {
        private String ConnectionString = "Host=localhost;port=5432;User ID=postgres;Password=1234;Database=ModeloMelhoria";

        private NpgsqlConnection conncetion;

        DataSet dados = new DataSet();

        public String ExecutarComandoSQL(String pcSQLCommand) {

            String retorno = "";

            abrirConexao();

            try
            {
                NpgsqlCommand sqlcommand = new NpgsqlCommand(pcSQLCommand, conncetion);

                sqlcommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                retorno = ex.Message;
                return retorno;
            }

            finally {
                fecharConexao();
            }

            return retorno;
        }

        public String getConnectionString() {
            return this.ConnectionString;
        }

        public String abrirConexao()
        {
            String retorno = "";
            try
            {
                this.conncetion = new NpgsqlConnection(this.ConnectionString);
                this.conncetion.Open();
            }
            catch (Exception ex)
            {
                retorno = ex.Message;
                return retorno;
            }

            return retorno;
        }

        public String fecharConexao()
        {
            String retorno = "";
            try
            {
                this.conncetion = new NpgsqlConnection(this.ConnectionString);
                this.conncetion.Close();
            }
            catch (Exception ex)
            {
                retorno = ex.Message;
                return retorno;
            }
            return retorno;
        }

    }
    }

