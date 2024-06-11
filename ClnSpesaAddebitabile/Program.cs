using System.Data;
using System.Data.SqlClient;

internal class Program
{
    private static void Main(string[] args)
    {
        DataTable dtVoiptmpFattPerChiamata = new DataTable();
        DataTable dtTipoChiamata = new DataTable();
        DataTable dtOfferta = new DataTable();
        //string cnn = "SERVER=VMWARE\\MSSQLSERVER2019;Initial Catalog=KongNew;Integrated Security=True;Encrypt=False;";
        string cnn = "Data Source=LAPTOP-8OH69FI3\\SQLEXPRESS01;Initial Catalog=Kongnew;Integrated Security=True;Encrypt=False;";
        String _sql = @"
                         SELECT  *
                         FROM       
                         VoiptmpListaChiamate
                        ";


        using (SqlConnection conn = new SqlConnection(cnn))
        {
            conn.Open();
            SqlDataAdapter adapterFatt = new SqlDataAdapter(_sql, conn);
            adapterFatt.Fill(dtVoiptmpFattPerChiamata);
            _sql = @"
                     SELECT  *
                     FROM       
                     voiptipochiamate
                        ";
            SqlDataAdapter adapterTipoChiamata= new SqlDataAdapter(_sql, conn);
            adapterTipoChiamata.Fill(dtTipoChiamata);
            _sql = @"
                     SELECT  *
                     FROM       
                     voipofferte
                   ";

            SqlDataAdapter adapterOfferta = new SqlDataAdapter(_sql, conn);
            adapterOfferta.Fill(dtOfferta);


        }

        foreach (DataRow drFatt in dtVoiptmpFattPerChiamata.Rows)
        {

            foreach (DataRow drOfferta in dtOfferta.Rows)
            {

                string Rifofferta = "0";
                string Ntipo = drFatt["ntipo"].ToString();
                if (Convert.ToBoolean(drOfferta["allinclusive"]))
                {

                    using (SqlConnection conn = new SqlConnection(cnn))
                    {
                        _sql = @"UPDATE voiptmpfatturazione 
                         Set  spesaaddebitabile=0 ";
                        conn.Open();
                        SqlCommand cmm = new SqlCommand(_sql, conn);
                        cmm.CommandType = CommandType.Text;
                        cmm.ExecuteNonQuery();
                        continue;

                    }

                }
                else
                {
                    foreach (DataRow dataRow in dtTipoChiamata.Rows)
                    {
                        if (dataRow["id"].ToString().Equals(Ntipo))
                        {
                            if (dataRow["Rifofferta"].Equals("0"))
                                Console.WriteLine("....");
                                continue;



                        }


                    }

                }

            }

        }

    }
}
