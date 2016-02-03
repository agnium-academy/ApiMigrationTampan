using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsAPI.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alamat { get; set; }
        public int Umur { get; set; }
    }
}