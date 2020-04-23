using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BootstrapTemplate.Models
{
    public class Client:IClient
    {
        // can change
        [DisplayName("Code")]
        public string rcl_Code { get; set; }
        [DisplayName("Description")]
        public string rcl_Description { get; set; }
        [DisplayName("Active")]
        public bool rcl_Active { get; set; }
        [DisplayName("Created by")]
        public string rcl_Created_By { get; set; }
        [DisplayName("Create Date")]
        public DateTime rcl_Created_Date { get; set; }
        [DisplayName("Last Modified by")]
        public string rcl_Last_Modified_By { get; set; }
        [DisplayName("Date Last Modified")]
        public DateTime rcl_Last_Modified_Date { get; set; }
    }
}
