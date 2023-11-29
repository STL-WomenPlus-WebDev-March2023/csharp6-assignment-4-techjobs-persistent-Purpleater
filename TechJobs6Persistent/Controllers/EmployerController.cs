﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechJobs6Persistent.Data;
using TechJobs6Persistent.Models;
using TechJobs6Persistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobs6Persistent.Controllers
{
    public class EmployerController : Controller
    {
        private JobDbContext context;

        public EmployerController(JobDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            List<Employer> employers = context.Employers.ToList();

            return View(employers);
        }

        [HttpGet]
        public IActionResult Create()
        {
            AddEmployerViewModel newEmployerViewModel = new AddEmployerViewModel();

            return View(newEmployerViewModel);
        }

        [HttpPost]
        public IActionResult ProcessCreateEmployerForm(AddEmployerViewModel createdViewModel)
        {

            if (!ModelState.IsValid)
            {
                createdViewModel.Message = "Please provide all of the required information";
                createdViewModel.isError = true;
                return View("Create", createdViewModel);

            }
            else {

                Employer newEmployer = new Employer(createdViewModel.Name, createdViewModel.Location);
                context.Employers.Add(newEmployer);
                context.SaveChanges();

            } 
            return RedirectToAction("Create");
        }

        public IActionResult About(int id)
        {
            Employer? employer = context.Employers.Find(id);
            return View(employer);
        }



    }
}

