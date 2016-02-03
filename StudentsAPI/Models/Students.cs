using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StudentsAPI.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alamat { get; set; }
        public int Umur { get; set; }
    }

    public class StudentsDBContext : DbContext
    {
        public DbSet<Students> Student { get; set; }
    }

}