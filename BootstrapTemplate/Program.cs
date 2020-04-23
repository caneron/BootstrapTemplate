using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System.Data.Common;

namespace BootstrapTemplate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            try
            {
                SqlConnectionStringBuilder conbuilder = new SqlConnectionStringBuilder();
                conbuilder.DataSource = "dt-rchub-live-dev.database.windows.net,1433";
                conbuilder.UserID = "dtrh-admin";
                conbuilder.Password = "\"D#\"4u.9u(*u;476M);qX";
                conbuilder.InitialCatalog = "DT-RCHUB-LIVE-DEV";

                using (SqlConnection connection = new SqlConnection(conbuilder.ToString()))
                {
                    Console.WriteLine("Attempting to connect to sql database");
                    connection.Open();
                }
            }
            catch (SqlException e)
            {
                Console.Write(e.Message.ToString());
                throw;
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
//Server=tcp:dt-rchub-live-dev.database.windows.net,1433;Initial Catalog=DT-RCHUB-LIVE-DEV;Persist Security Info=False;User ID=dtrh-admin;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;