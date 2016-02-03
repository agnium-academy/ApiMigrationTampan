using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAPI.Models
{
    interface IStudentsRepository
    {
        IEnumerable<Students> GetAll();
        Students Get(int Id);
        Students Add(Students stut);
        void Remove(int Id);
        bool Update(Students stut);
    }
}
