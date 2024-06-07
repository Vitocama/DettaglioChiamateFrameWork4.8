using System.Data;
using System.Data.SqlClient;

internal class Program
{
    private static void Main(string[] args)
    {
        DataTable dt = new DataTable();

        string cnn = "SERVER=VMWARE\\MSSQLSERVER2019;Initial Catalog=KongNew;Integrated Security=True;Encrypt=False;";

        String _sql = @"
SELECT        
voiptmpfatturazione.contratto, 
voiptmpfatturazione.offerta, 
voiptmpfatturazione.tipo, 
voiptmpfatturazione.descrizione, 
voiptmpfatturazione.secondi, 
voiptmpfatturazione.secondiaddebitabili, 
voiptmpfatturazione.nchiamate, 
voiptmpfatturazione.nchiamateAddebitabili, 
voiptmpfatturazione.scatto, 
voipOfferte.AllInclusive,
case when tipo='FI' then minfisso*60 else minmobile*60 end AS minutiofferta

 FROM                     
	voipofferte JOIN voiptmpfatturazione
        on offerta=idofferta
        
	
                        ";


        using (SqlConnection conn = new SqlConnection(cnn))
        { 
            conn.Open();
        SqlDataAdapter adapter = new SqlDataAdapter(_sql,conn);
            adapter.Fill(dt);        

        }
        foreach (DataRow dr in dt.Rows)
        {
            if (Convert.ToBoolean(dr["allinclusive"]))
            {
                _sql = @"UPDATE voiptmpfatturazioneclone 
                         Set  spesaaddebitabile=0 ";
                using (SqlConnection conn = new SqlConnection(cnn))
                {
                    conn.Open();
                    SqlCommand cmm = new SqlCommand(_sql, conn);
                    cmm.CommandType = CommandType.Text;
                    cmm.ExecuteNonQuery();
                    continue;

                }

                if (dr["Tipo"].ToString().Equals("FI"))
                {
                    dr["minutiofferta"]
                
                }

                else { }






            }
        
        }
    
    
    
    }
}