using Demo.DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace Demo.PL.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name is Required Field.")]
        [MaxLength(50, ErrorMessage = "Max Length of Name is 50 Charcters.")]
        [MinLength(5, ErrorMessage = "Min Length of Name is 5 Charcters.")]
        public string EmpName { get; set; }

        [Range(22, 59)]
        public int? EmpAge { get; set; }

        [RegularExpression(@"^[0-9]{1,3}-[a-zA-Z]{5,10}-[a-zA-Z]{5,10}-[a-zA-Z]{5,10}$",
                            ErrorMessage = "The Address must to like \"123-Street-City-Country\"")]
        public string EmpAddress { get; set; }

        public decimal EmpSalary { get; set; }

        public bool EmpIsActive { get; set; }

        [EmailAddress]
        public string EmpEmail { get; set; }

        [Phone]
        public string EmpPhone { get; set; }

        public DateTime EmpHireDate { get; set; }

        public DateTime CreationDate { get; set; }

        //Add new Foreign Key for Department
        [ForeignKey("Department")]
        public int? FKDepartment { get; set; }

        //Navigation Property [One]
        public Department Department { get; set; }
    }
}
