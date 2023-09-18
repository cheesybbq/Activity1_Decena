using Aug262023.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Aug262023.Controllers
{
    public class PersonController : ApiController
    {
        UACEntities db = new UACEntities();
        public Person Get(int id)
        {
            var person = db.Person.Find(id);
            return person;
        }   
        public List<Person> Get()
        {
            var list = db.Person.ToList();
            return list;
        }
        public void Post(Person person)
        {
            db.Person.Add(person);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var person = db.Person.Find(id);
            db.Person.Remove(person);
            db.SaveChanges();
        }

        public void Put(int id, Person person)
        {
            var persontoeditted = db.Person.Find(id);
            persontoeditted.Gender = person.Gender;
            persontoeditted.Address = person.Address;
            persontoeditted.LastName = person.LastName;
            persontoeditted.FirstName = person.FirstName;
            db.SaveChanges();
        }
    }
}