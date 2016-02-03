using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsAPI.Models
{
    public class StudentsRepository : IStudentsRepository
    {
        private List<Students> students = new List<Students>();
        private int _nextId = 1;

        public StudentsRepository()
        {
            Add(new Students { Alamat = "Bogor", Name = "Dhani", Umur = 18 });
            Add(new Students { Alamat = "Jakarta", Name = "Kiki", Umur = 21 });
            Add(new Students { Alamat = "Bekasi", Name = "Husain", Umur = 22 });
            Add(new Students { Alamat = "Jonggol", Name = "Seta", Umur = 82 });
        }

        public IEnumerable<Students> GetAll()
        {
            return students;
        }

        public Students Get(int id)
        {
            return students.Find(p => p.Id ==  id);
        }

        public Students Add(Students stut)
        {
            if (stut == null)
            {
                throw new ArgumentNullException("stut");
            }
            stut.Id = _nextId++;
            students.Add(stut);
            return stut;
        }

        public void Remove(int id)
        {
           students.RemoveAll(p => p.Id == id);
        }

        public bool Update(Students stut)
        {
            if (stut == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = students.FindIndex(p => p.Id == stut.Id);
            if (index == -1)
            {
                return false;
            }
            students.RemoveAt(index);
            students.Add(stut);
            return true;
        }
    }
}