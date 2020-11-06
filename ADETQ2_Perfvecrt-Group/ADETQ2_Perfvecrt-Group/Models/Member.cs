using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ADETQ2_Perfvecrt_Group.Models
{
    public class  Member
    {
      
        public int ID { get; set; }
        public string StudNum { get; set; }
        public string FullName { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }

       
    }
}
