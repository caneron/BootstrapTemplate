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
            for (int i = 0; i < 4; i++)
            {
                Client tempclient = new Client() { Name = i.ToString(), Active = false, CreatedBy = "Cameron Smith", CreatedDate = DateTime.Now };
                clients.Add(tempclient);
            }
            return View(clients);
        }
    }
}