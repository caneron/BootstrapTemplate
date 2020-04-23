using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootstrapTemplate.Models
{
    interface IClient
    {
        public string rcl_Code  { get; set; }
        public string rcl_Description { get; set; }
        public bool rcl_Active { get; set; }
        public string rcl_Created_By { get; set; }
        public DateTime rcl_Created_Date { get; set; }
        public string rcl_Last_Modified_By { get; set; }
        public DateTime rcl_Last_Modified_Date { get; set; }

    }
}
