﻿using AutoMapper;
using Demo.BLL.Interfaces;
using Demo.DAL.Models;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Demo.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;

        public DepartmentController(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }

        //===================================== Index Method  ======================================

        [HttpGet]
        public IActionResult Index()
        {
            var departments = _departmentRepository.GetAll();
            //Send the query set of all data Model "Department".

            //Use Auto Mapper
            var mappedDept = _mapper.Map<IEnumerable<Department>, IEnumerable<DepartmentViewModel>>(departments);

            return View(mappedDept);
        }
        //===================================== Create Methods ======================================
        //You should add two annotation ([HttpGet] & [HttpPost]) for create.
        [HttpGet]//You didn't need to add it (becuase this is the defualt annotation)
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Department department)
        {
            if (ModelState.IsValid) //For Check the validation on the service side.
            {
                _departmentRepository.Add(department);
                return RedirectToAction(nameof(Index));
            }
            else
                return View(department);

        }

        //===================================== Detail Method ======================================
        [HttpGet]
        public IActionResult Detail(int? id, string viewName = "Detail")
        {
            //If the user not passing id prameter
            if (id is null)
                return BadRequest();

            //Create an object from department.
            var department = _departmentRepository.GetById(id.Value);

            //If the query of department is empty or (Id wrong)
            if (department is null)
                return NotFound();

            //If the data of department found 
            return View(viewName, department);
        }

        //===================================== Edit Methods ======================================
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            ///This is the same body of Detail.
            ///if (id is null)
            ///    return BadRequest();
            ///var department = _departmentRepository.GetById(id.Value);
            ///if(department is null)
            ///    return NotFound();
            ///return View(department);
            ///

            //Passing the value to Detail Method.
            return Detail(id, "Edit");

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([FromRoute] int id, Department department)
        {
            if (id != department.Id)
                return BadRequest();

            if (ModelState.IsValid)
            {
                try
                {
                    _departmentRepository.Update(department);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    /// The steps handeling Exception Errors.
                    ///1. Log Exception.
                    ///2. Friendly Message.
                    ///

                    ModelState.AddModelError(string.Empty, ex.Message);//The AddModelError take two prameters (Key and Value)
                }
            }
            return View(department);
        }

        //===================================== Delete Methods ======================================
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return Detail(id, "Delete");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([FromRoute] int id, Department department)
        {
            if (id != department.Id)
                return BadRequest();

            if (ModelState.IsValid)
            {
                try
                {
                    _departmentRepository.Delete(department);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }

            }
            return View(department);
        }
    }
}