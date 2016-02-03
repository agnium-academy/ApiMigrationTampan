using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StudentsAPI.Models;

namespace StudentsAPI.Controllers
{
    public class StudentsController : ApiController
    {
        static readonly IStudentsRepository repository = new StudentsRepository();

        public IEnumerable<Students> GetAllStudents()
        {
            return repository.GetAll();
        }


        public Students GetStudent(int id)
        {
            Students stut = repository.Get(id);
            if (stut == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return stut;
        }

        public IEnumerable<Students> GetStudentsByNama(string name)
        {
            return repository.GetAll().Where(
                p => string.Equals(p.Name, name, StringComparison.OrdinalIgnoreCase));
        }


        //public Students PostStudents(Students stut)
        //{
        //    stut = repository.Add(stut);
        //    return stut;
        //}




        public HttpResponseMessage PostStudents(Students stut)
        {
            stut = repository.Add(stut);
            var response = Request.CreateResponse<Students>(HttpStatusCode.Created, stut);

            string uri = Url.Link("DefaultApi", new { id = stut.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        public void PutStudents(int id, Students students)
        {
            students.Id = id;
            if (!repository.Update(students))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        public void DeleteStudents(int id)
        {
            Students item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repository.Remove(id);
        }



    }
}
