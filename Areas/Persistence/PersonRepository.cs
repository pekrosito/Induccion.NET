using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InduccionNET.Models;

namespace InduccionNET.Areas.Persistence
{
    public class PersonRepository : IPersonRepository
    {
        public person GetPerson()
        {
            induccionEntities entity = new induccionEntities();
            person person = new person();
            gender gender = new gender();

            using (entity)
            {
                person = entity.people.SqlQuery("SELECT P.id, P.name, surname, age, identification, sex FROM person P ").FirstOrDefault();
                person.gender = entity.genders.Where(X => X.id == person.id).FirstOrDefault();
            }

            return person;
        }
    }
}