using Lb6.Models;
using System;
using System.Data.Entity;

namespace Lb6.EF
{
    public class CompanyEntity : DbContext
    {
        public CompanyEntity() : base("DbConnectionString") { }

        public DbSet<Worker> Workers { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}