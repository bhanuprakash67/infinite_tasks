﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignmnet_1.Models;
using Assignmnet_1.Repository;
using System.Threading.Tasks;


namespace Assignmnet_1.Controllers
{
    public class ContactsController : Controller
    {
        // GET: Contacts
        IContactRepository repository;
        public ContactsController()
        {
            repository = new ContactRepository();
        }
        public async Task<ActionResult> Index()
        {
            var contacts = await repository.GetAllAsync();
            return View(contacts);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult>Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                await repository.CreateAsync(contact);
                return RedirectToAction("Index");
            }
            return View(contact);
        }

        [HttpPost]
        public async Task<ActionResult>Delete(long id)
        {
            await repository.DeleteAsync(id);
            return RedirectToAction("Index");
        }
        
    }
}