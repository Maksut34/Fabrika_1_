using Fabrika_1_2.orm.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika_1_2.orm.context
{
    class context:DbContext
    {
        public context()
        {
            Database.Connection.ConnectionString = "Server=LAPTOP-PAPDGKQ8\\SQLEXPRESS02;Database=Fabrika;uid=sa;pwd=1;";
        }

        public DbSet<internet_sales> Internet_Sales { get; set; }
        public DbSet<shoe_manufacturıng> Shoe_Manufacturıngs { get; set; }
        public DbSet<shoe_in_and_out> Shoe_In_And_Outs { get; set; }
        public DbSet<materıals_avaılable> Materıals_Avaılable { get; set; }
    }
    
}
