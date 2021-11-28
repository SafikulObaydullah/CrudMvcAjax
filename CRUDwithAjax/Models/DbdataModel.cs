using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUDwithAjax.Models
{
    public class DbdataModel : DbContext
    {
        public DbSet<Employees> Employees { get; set; }
    }
}