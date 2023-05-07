using Demo.DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Http;

namespace Demo.PL.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name is Required Field.")]
        [MaxLength(50, ErrorMessage = "Max Length of Name is 50 Charcters.")]
        [MinLength(5, ErrorMessage = "Min Length of Name is 5 Charcters.")]
        [Display(Name = "Name")]
        public string EmpName { get; set; }

        [Range(22, 59)]
        [Display(Name = "Age")]
        public int? EmpAge { get; set; }

        [RegularExpression(@"^[0-9]{1,3}-[a-zA-Z]{5,10}-[a-zA-Z]{5,10}-[a-zA-Z]{5,10}$",
                            ErrorMessage = "The Address must to like \"123-Street-City-Country\"")]
        [Display(Name = "Address")]
        public string EmpAddress { get; set; }

        [Display(Name = "Salary")]
        public decimal EmpSalary { get; set; }

        [Display(Name = "Active")]
        public bool EmpIsActive { get; set; }

        [EmailAddress]
        [Display(Name = "Email")]
        public string EmpEmail { get; set; }

        [Phone]
        [Display(Name = "Phone NO#")]
        public string EmpPhone { get; set; }

        public string ImageName { get; set; }

        public IFormFile Image { get; set; }

        [Display(Name = "Hire Date")]
        public DateTime EmpHireDate { get; set; }

        [Display(Name = "Creation Date")]
        public DateTime CreationDate { get; set; }

        //Add new Foreign Key for Department
        [ForeignKey("Department")]
        public int? FKDepartment { get; set; }

        //Navigation Property [One]
        public Department Department { get; set; }
    }
}
