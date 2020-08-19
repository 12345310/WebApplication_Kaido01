using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication_Kaido01.Models
{
    public class WebApplication_Kaido01Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WebApplication_Kaido01Context() : base("name=WebApplication_Kaido01Context")
        {
        }

        public System.Data.Entity.DbSet<WebApplication_Kaido01.Models.Member> Members { get; set; }
    }
}
