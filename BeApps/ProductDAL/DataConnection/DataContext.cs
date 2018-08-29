using ProductDAL.Entity.Product;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using ProductDAL.DataConnection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace ProductDAL.DataConnection
{
   public class DataContext : IdentityDbContext<Users> {  
        public DataContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<Product> Product { get; set; }  
     } 
}
