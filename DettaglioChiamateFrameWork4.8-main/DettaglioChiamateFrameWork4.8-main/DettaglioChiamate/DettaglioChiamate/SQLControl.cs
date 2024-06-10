using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DettagliChiamate
{
    internal class SQLControl
    {
        private SqlConnection DBCon = new SqlConnection("");
        private SqlCommand DBCmd;

        // DB DATA
        public SqlDataAdapter DBDA;
        public DataTable DBDT;

        // QUERY PARAMETERS
        public List<SqlParameter> Params = new List<SqlParameter>();

        // QUERY STATISTICS
        public int RecordCount;
        public string Exception;

        public SQLControl()
        {
        }

        // ALLOW CONNECTION STRING OVERRIDE
        public SQLControl(string ConnectionString)
        {
            DBCon = new SqlConnection(ConnectionString);
        }

        // EXECUTE QUERY SUB
        public void ExecQuery(string Query, bool ReturnIdentity = false)
        {
            // RESET QUERY STATS
            RecordCount = 0;
            Exception = "";

            try
            {
                DBCon.Open();

                // CREATE DB COMMAND
                DBCmd = new SqlCommand(Query, DBCon);

                // LOAD PARAMS INTO DB COMMAND
                Params.ForEach(p => DBCmd.Parameters.Add(p));

                // CLEAR PARAM LIST
                Params.Clear();

                // EXECUTE COMMAND & FILL DATASET
                DBDT = new DataTable();
                DBDA = new SqlDataAdapter(DBCmd);
                RecordCount = DBDA.Fill(DBDT);

                if (ReturnIdentity == true)
                {
                    string ReturnQuery = "SELECT @@IDENTITY As LastID;";
                    // @@IDENTITY - SESSION
                    // SCOPE_IDENTITY() - SESSION & SCOPE
                    // IDENT_CURRENT(tablename) - LAST IDENT IN TABLE, ANY SCOPE, ANY SESSION
                    DBCmd = new SqlCommand(ReturnQuery, DBCon);
                    DBDT = new DataTable();
                    DBDA = new SqlDataAdapter(DBCmd);
                    RecordCount = DBDA.Fill(DBDT);
                }
            }
            catch (System.Exception ex)
            {
                // CAPTURE ERROR
                //Exception = "ExecQuery Errore: " + Constants.vbNewLine + ex.Message;
                Exception = "ExecQuery Errore: " + "\r\n" + ex.Message;
            }
            finally
            {
                // CLOSE CONNECTION
                if (DBCon.State == ConnectionState.Open)
                    DBCon.Close();
            }
        }

        // ADD PARAMS
        public void AddParam(string Name, object Value)
        {
            SqlParameter NewParam = new SqlParameter(Name, Value);
            Params.Add(NewParam);
        }

        // ERROR CHECKING
        public bool HasException(bool Report = false)
        {
            if (string.IsNullOrEmpty(Exception))
                return false;
            if (Report == true)
            {


                MessageBox.Show(Exception, "Exception:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true;
        }




        public void ExecStoredProcedure(string ProcedureName)
        {
            // imposto parametri ad un valore iniziale
            RecordCount = 0;
            Exception = "";

            try
            {
                DBCon.Open();

                // chiamo la procedura
                DBCmd = new SqlCommand(ProcedureName, DBCon);
                DBCmd.CommandType = CommandType.StoredProcedure;

                // una Linq che mi serve a caricare i parametri se richiesti nel codice
                Params.ForEach(p => DBCmd.Parameters.Add(p));

                // pulisco i paramentri
                Params.Clear();

                //riempio il dataTable
                DBDT = new DataTable();
                DBDA = new SqlDataAdapter(DBCmd);
                RecordCount = DBDA.Fill(DBDT);
            }
            catch (System.Exception ex)
            {
                // gestione degli errori
                Exception = "StoredProcedure Errore: " + "\r\n" + ex.Message;
            }
            finally
            {
                // gestisco la chiusura 
                if (DBCon.State == ConnectionState.Open)
                    DBCon.Close();
            }
        }


    }
}
