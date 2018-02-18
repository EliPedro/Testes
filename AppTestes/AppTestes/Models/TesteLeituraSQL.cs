using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace AppTestes.Models
{
    public class TesteLeituraSQL
    {
        public void TesteSqlBulkCopy()
        {
            try
            {

                var dt = new DataTable();
                var origem = @"Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
                var destino = @"Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";

                using (var conexaoOrigem = new SqlConnection(origem))
                {
                    conexaoOrigem.Open();

                    var cmm = new SqlCommand("SELECT ID,IDC,TEXTO FROM VIVO_EMAIL", conexaoOrigem);
                    dt.Load(cmm.ExecuteReader());

                    using (var conexaoDestino = new SqlConnection(destino))
                    {
                        conexaoDestino.Open();
                        using (SqlBulkCopy copy = new SqlBulkCopy(conexaoDestino))
                        {
                            copy.ColumnMappings.Add("ID", "ID");
                            copy.ColumnMappings.Add("IDC", "IDC");
                            copy.ColumnMappings.Add("TEXTO", "TEXTO");
                            copy.DestinationTableName = "VIVO_EMAIL";
                            copy.WriteToServer(dt);
                        }
                        conexaoOrigem.Close();
                        conexaoOrigem.Dispose();
                        conexaoDestino.Close();
                        conexaoDestino.Dispose();
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
