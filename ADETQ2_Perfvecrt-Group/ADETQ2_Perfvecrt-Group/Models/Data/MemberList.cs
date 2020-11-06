using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADETQ2_Perfvecrt_Group.Models.Data
{
    public class MemberList : DbContext
    {
        
        public MemberList (DbContextOptions<MemberList> options) : base(options)
        {

        }
        public DbSet<Member> Member { get; set; }    
    }
}
