using AutoMapper;
using Demo.BLL.Interfaces;
using Demo.DAL.Models;
using Demo.PL.Helpers;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.PL.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        //private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        //private readonly IDepartmentRepository _departmentRepository;

        public EmployeeController(/*IEmployeeRepository employeeRepository,*/ /*, IDepartmentRepository departmentRepository*/ IMapper mapper, IUnitOfWork unitOfWork)
        {
            //_employeeRepository = employeeRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;

            //For Use it to create an object for Drop down list FK Department ID 
            //_departmentRepository = departmentRepository;
        }

        //===================================== Index Method  ======================================
        
        ///You must be comment data annotation verb [HttpGet] because you will post a perameter to Index for Search
        ///[HttpGet]

        public async Task <IActionResult> Index(string SearchValue)
        {
            IEnumerable<Employee> employees;

            if (string.IsNullOrEmpty(SearchValue))
                employees =await _unitOfWork.EmployeeRepository.GetAll();
            else
                employees = _unitOfWork.EmployeeRepository.SearchEmployeesByName(SearchValue);

            //Use Auto Mapper
            var mappedEmp = _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(employees);

            //Send the query set of all data Model "Employees".
            return View(mappedEmp);
        }
        //===================================== Create Methods ======================================
        //You should add two annotation ([HttpGet] & [HttpPost]) for create.
        [HttpGet]//You didn't need to add it (becuase this is the defualt annotation)
        public IActionResult Create()
        {
            //Perpare Department object for use it at drop down list
            //ViewData["DepartmentsViewData"] = _departmentRepository.GetAll();

            //ViewBag.DepartmentsViewBag = _departmentRepository.GetAll();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeViewModel employeeVM)
        {
            if (ModelState.IsValid) //For Check the validation on the service side.
            {
                //Before make mapper add image file
                employeeVM.ImageName = DocumentSetting.UploadFile(employeeVM.Image, "Images");

                //Use Auto Mapper
                var mappedEmp = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);

                 await _unitOfWork.EmployeeRepository.Add(mappedEmp);
                
                //For Save the changes on DB
                await _unitOfWork.Complete();

                return RedirectToAction(nameof(Index));
            }

            else
                return View(employeeVM);

        }

        //===================================== Detail Method ======================================
        [HttpGet]
        public async Task<IActionResult> Detail(int? id, string viewName = "Detail")
        {
            //If the user not passing id prameter
            if (id is null)
                return BadRequest();

            //Create an object from employee.
            var employee = await _unitOfWork.EmployeeRepository.GetById(id.Value);

            //Use Auto Mapper as a reverse()
            var mappedEmp = _mapper.Map<Employee, EmployeeViewModel>(employee);

            //If the query of employee is empty or (Id wrong)
            if (employee is null)
                return NotFound();

            //If the data of employee found 
            return View(viewName, mappedEmp);
        }

        //===================================== Edit Methods ======================================
        [HttpGet]
        public Task<IActionResult> Edit(int? id)
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
        public async Task<IActionResult> Edit([FromRoute] int id, EmployeeViewModel employeeVM)
        {
            if (id != employeeVM.Id)
                return BadRequest();

            if (ModelState.IsValid)
            {
                try
                {
                    //Before make mapper add image file
                    employeeVM.ImageName = DocumentSetting.UploadFile(employeeVM.Image, "Images");

                    //Use Auto Mapper
                    var mappedEmp = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);

                    //Use Unit OF Work
                    _unitOfWork.EmployeeRepository.Update(mappedEmp);

                    //For Save the changes on DB
                    await _unitOfWork.Complete();

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
            return View(employeeVM);
        }

        //===================================== Delete Methods ======================================
        [HttpGet]
        public Task<IActionResult> Delete(int id)
        {
            return Detail(id, "Delete");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id, EmployeeViewModel employeeVM)
        {
            if (id != employeeVM.Id)
                return BadRequest();

            if (ModelState.IsValid)
            {
                try
                {
                    //Use Auto Mapper
                    var mappedEmp = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);

                    _unitOfWork.EmployeeRepository.Delete(mappedEmp);

                    //For Save the changes on DB
                    int countTransactions = await _unitOfWork.Complete();

                    if (countTransactions > 0)
                        DocumentSetting.DeleteFile(employeeVM.ImageName, "Images");

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }

            }
            return View(employeeVM);
        }
    }
}
