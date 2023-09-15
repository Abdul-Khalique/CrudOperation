using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext()
           : base("EmployeeDB")
        { }
        public DbSet<Employee> Employees { get; set; }
    }
}