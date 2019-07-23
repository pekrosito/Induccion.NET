using InduccionNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InduccionNET.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            induccionEntities entity = new induccionEntities();
            List<person> person = new List<person>();

            using (entity)
            {
                person = entity.people.ToList();
            }

            return View(person);
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            induccionEntities entity = new induccionEntities();
            person person = new person();

            using (entity)
            {
                person = entity.people.Where(entityPerson => entityPerson.id == id).FirstOrDefault();
            }
            
            return View(person);
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View(new person());
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(person collection)
        {
            try
            {
                using(induccionEntities entity = new induccionEntities())
                {
                    entity.people.Add(collection);
                    entity.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            induccionEntities entity = new induccionEntities();
            person person = new person();

            using (entity)
            {
                person = entity.people.Where(entityPerson => entityPerson.id == id).FirstOrDefault();
            }

            return View(person);
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, person collection)
        {
            try
            {
                using (induccionEntities entity = new induccionEntities())
                {
                    entity.Entry(collection).State = System.Data.Entity.EntityState.Modified;
                    entity.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            induccionEntities entity = new induccionEntities();
            person person = new person();

            using (entity)
            {
                person = entity.people.Where(entityPerson => entityPerson.id == id).FirstOrDefault();
            }

            return View(person);
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, person collection)
        {
            try
            {
                person users = new person();
                using (induccionEntities entity = new induccionEntities())
                {
                    users = entity.people.Where(entityPerson => entityPerson.id == id).FirstOrDefault();
                    entity.people.Remove(users);
                    entity.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
