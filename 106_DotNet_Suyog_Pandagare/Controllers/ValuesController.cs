using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {
        ORMDBManager entity=new ORMDBManager();
        // GET api/values
        public IEnumerable<StudentEntity> Get()
        {
            List<StudentEntity> pl = entity.studentsEntities.ToList();
            return pl;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]StudentEntity student)
        {
            entity.studentsEntities.Add(student);
            entity.SaveChanges();
        }

        // PUT api/values/5
        public void Put(int id,[FromBody] StudentEntity value)
        {
            
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            

        }
    }
}
