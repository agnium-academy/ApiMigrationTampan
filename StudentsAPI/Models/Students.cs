using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
<<<<<<< HEAD
using System.Data.Entity;
=======
>>>>>>> e46b4a0e1d8c5c5e503e1e330befe9dc10c716aa

namespace StudentsAPI.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alamat { get; set; }
        public int Umur { get; set; }
    }
<<<<<<< HEAD

    public class StudentsDBContext : DbContext
    {
        public DbSet<Students> Student { get; set; }
        //public List<Students> StudentList { get; set; }
    }

=======
>>>>>>> e46b4a0e1d8c5c5e503e1e330befe9dc10c716aa
}