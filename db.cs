using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace code_first
{
    public class db:DbContext
    {
       public db():base("rt")
        {
            
        }public DbSet<human> humans { get; set; }
    }
}
