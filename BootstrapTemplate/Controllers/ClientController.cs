using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BootstrapTemplate.Models;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapTemplate.Controllers
{
    public class ClientController : Controller
    {
        //add a new client to the system
        public IActionResult Create()
        {
            return View();
        }
        //list all clients
        public IActionResult Index()
        {
            //demo data
            List<Client> clients = new List<Client>();

            Client client = new Client()
            {
                rcl_Code = "RCL0000001",
                rcl_Description = "ABSA",
                rcl_Active = false,
                rcl_Created_By = "Riaanvdm",
                rcl_Created_Date = new DateTime(2020, 04, 16, 12, 51, 12),
                rcl_Last_Modified_By= "Riaanvdm",
                rcl_Last_Modified_Date = new DateTime(2020, 04, 16, 12, 51, 12)
            };
            clients.Add(client);

            client = new Client()
            {
                rcl_Code = "RCL0000002",
                rcl_Description = "African Bank",
                rcl_Active = false,
                rcl_Created_By = "Riaanvdm",
                rcl_Created_Date = new DateTime(2020, 04, 16, 12, 51, 25),
                rcl_Last_Modified_By = "Riaanvdm",
                rcl_Last_Modified_Date = new DateTime(2020, 04, 16, 12, 51, 25)
            };
            clients.Add(client);

            client = new Client()
            {
                rcl_Code = "RCL0000003",
                rcl_Description = "Albaraka Bank",
                rcl_Active = true,
                rcl_Created_By = "Riaanvdm",
                rcl_Created_Date = new DateTime(2020, 04, 16, 12, 51, 42),
                rcl_Last_Modified_By = "Riaanvdm",
                rcl_Last_Modified_Date = new DateTime(2020, 04, 16, 12, 51, 42)
            };
            clients.Add(client);

            client = new Client()
            {
                rcl_Code = "RCL0000004",
                rcl_Description = "Banco Sol",
                rcl_Active = false,
                rcl_Created_By = "Riaanvdm",
                rcl_Created_Date = new DateTime(2020, 04, 16, 12, 51, 53),
                rcl_Last_Modified_By = "Riaanvdm",
                rcl_Last_Modified_Date = new DateTime(2020, 04, 16, 12, 51, 53)
            };
            clients.Add(client);

            client = new Client()
            {
                rcl_Code = "RCL0000005",
                rcl_Description = "BNP Paribas",
                rcl_Active = false,
                rcl_Created_By = "Riaanvdm",
                rcl_Created_Date = new DateTime(2020, 04, 16, 12, 52,08),
                rcl_Last_Modified_By = "Riaanvdm",
                rcl_Last_Modified_Date = new DateTime(2020, 04, 16, 12, 52, 08)
            };
            clients.Add(client);

            client = new Client()
            {
                rcl_Code = "RCL0000006",
                rcl_Description = "Ithala Bank",
                rcl_Active = false,
                rcl_Created_By = "Riaanvdm",
                rcl_Created_Date = new DateTime(2020, 04, 16, 12, 52, 21),
                rcl_Last_Modified_By = "Riaanvdm",
                rcl_Last_Modified_Date = new DateTime(2020, 04, 16, 12, 5, 21)
            };
            clients.Add(client);

            client = new Client()
            {
                rcl_Code = "RCL0000007",
                rcl_Description = "GroBank",
                rcl_Active = false,
                rcl_Created_By = "Riaanvdm",
                rcl_Created_Date = new DateTime(2020, 04, 16, 12, 52,35),
                rcl_Last_Modified_By = "Riaanvdm",
                rcl_Last_Modified_Date = new DateTime(2020, 04, 16, 12, 52, 35)
            };
            clients.Add(client);

            client = new Client()
            {
                rcl_Code = "RCL0000008",
                rcl_Description = "Sasfin Bank",
                rcl_Active = false,
                rcl_Created_By = "Riaanvdm",
                rcl_Created_Date = new DateTime(2020, 04, 16, 12, 52, 49),
                rcl_Last_Modified_By = "Riaanvdm",
                rcl_Last_Modified_Date = new DateTime(2020, 04, 16, 12, 52, 49)
            };
            clients.Add(client);

            client = new Client()
            {
                rcl_Code = "RCL0000009",
                rcl_Description = "State Bank of india",
                rcl_Active = false,
                rcl_Created_By = "Riaanvdm",
                rcl_Created_Date = new DateTime(2020, 04, 16, 12, 53, 07),
                rcl_Last_Modified_By = "Riaanvdm",
                rcl_Last_Modified_Date = new DateTime(2020, 04, 16, 12, 53, 07)
            };
            clients.Add(client);

            client = new Client()
            {
                rcl_Code = "RCL00000010",
                rcl_Description = "Ubank Bank",
                rcl_Active = false,
                rcl_Created_By = "Riaanvdm",
                rcl_Created_Date = new DateTime(2020, 04, 16, 12, 53, 17),
                rcl_Last_Modified_By = "Riaanvdm",
                rcl_Last_Modified_Date = new DateTime(2020, 04, 16, 12, 53, 17)
            };
            clients.Add(client);

            client = new Client()
            {
                rcl_Code = "RCL00000011",
                rcl_Description = "VBS Mutal Bank",
                rcl_Active = false,
                rcl_Created_By = "Riaanvdm",
                rcl_Created_Date = new DateTime(2020, 04, 16, 12, 53,36),
                rcl_Last_Modified_By = "Riaanvdm",
                rcl_Last_Modified_Date = new DateTime(2020, 04, 16, 12, 53,36)
            };
            clients.Add(client);

            client = new Client()
            {
                rcl_Code = "RCL00000012",
                rcl_Description = "Wonga",
                rcl_Active = false,
                rcl_Created_By = "Riaanvdm",
                rcl_Created_Date = new DateTime(2020, 04, 16, 12, 53, 45),
                rcl_Last_Modified_By = "Riaanvdm",
                rcl_Last_Modified_Date = new DateTime(2020, 04, 16, 12, 53, 45)
            };
            clients.Add(client);

            client = new Client()
            {
                rcl_Code = "RCL00000013",
                rcl_Description = "Bitvest Bank",
                rcl_Active = false,
                rcl_Created_By = "Riaanvdm",
                rcl_Created_Date = new DateTime(2020, 04, 16, 12, 54,01),
                rcl_Last_Modified_By = "Riaanvdm",
                rcl_Last_Modified_Date = new DateTime(2020, 04, 16, 12, 54,01)
            };
            clients.Add(client);
            return View(clients);
        }
    }
}