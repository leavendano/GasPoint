using GasPoint.Core.HoseDelivery;
using GasPoint.Core.Interfaces;
using System.Data;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;


namespace GasPoint.Infrastructure.Services
{
    public class EnablerService : IEnablerService
    {
        private readonly IConfiguration _configuration;

        public EnablerService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public  HoseDeliveryResponseDTO? GetLastDeliveryByHostID(int hoseID)
        {


            // var connString = _config["ConnectionStrings:DefaultConnection"];
           // var connString = "Server=192.168.1.64;Database=EnablerDB;Trusted_Connection=True;User ID=sa; Password=newton01;TrustServerCertificate=true;";
            string connString = _configuration["ConnectionStrings:DefaultConnection"];
            try
            {
                

                using (SqlConnection cnn = new(connString))
                {
                    cnn.Open();

                    // Se establece el orden de interpretaci�n de las fechas a a�o mes dia
                    using (SqlCommand sqlCmd = new("set dateformat ymd", cnn))
                    {

                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.ExecuteNonQuery();
                        sqlCmd.CommandText = "SELECT TOP (1) [Delivery_ID],d.[Hose_ID],h.Grade_ID,g.Grade_Name,[Completed_TS],[Delivery_Volume]" + 
                            " ,[Delivery_Value] FROM [Hose_Delivery] d left join Hoses h on h.Hose_ID = d.Hose_ID" + 
                            $" left join Grades g on g.Grade_ID = h.Grade_ID Where d.Hose_ID={hoseID}  Order by Delivery_ID desc";

                        sqlCmd.CommandType = CommandType.Text;
                       

                        SqlDataReader reader = sqlCmd.ExecuteReader();
                        if (reader.Read())
                        {
                            var resultado = new HoseDeliveryResponseDTO
                            {
                                Delivery_ID = int.Parse(reader["Delivery_ID"].ToString()!),
                                Hose_ID = int.Parse(reader["Hose_ID"].ToString()!),
                                Grade_ID = int.Parse(reader["Grade_ID"].ToString()!),
                                GradeName = (string)reader["Grade_Name"],
                                Completed_TS = DateTime.Parse(reader["Completed_TS"].ToString()),
                                Delivery_Volume = Decimal.Parse(reader["Delivery_Volume"].ToString()),
                                Delivery_Value = Decimal.Parse(reader["Delivery_Value"].ToString())
                            };
                            return resultado;
                        }
                        else
                        {
                            return null;
                        }

                    }
                }

            }
            catch (Exception)
            {
                

            }
            return null;

        }
    }
}
