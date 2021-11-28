namespace CRUDwithAjax.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CRUDwithAjax.Models.DbdataModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CRUDwithAjax.Models.DbdataModel context)
        {
            List<Models.Employees> employees = new List<Models.Employees>
            {
                new Models.Employees { Name="Tamim", Address="Dhaka", Contact="01765385359", Email="tamim@gmail.com"},
                new Models.Employees { Name="Golap", Address="Banani", Contact="01765385323", Email="golap@gmail.com"},
                new Models.Employees { Name="Sourov", Address="Mirpur", Contact="01765358315", Email="sourov@gmail.com"},
                new Models.Employees { Name="Hasib", Address="Chittagong", Contact="01765325239", Email="hasib@gmail.com"}
            };
            context.Employees.AddRange(employees);
            context.SaveChanges();
        }
    }
}
