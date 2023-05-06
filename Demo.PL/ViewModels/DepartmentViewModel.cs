using Demo.DAL.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Demo.PL.ViewModels
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This Field of DeptCode Is Required !!")]
        public string DeptCode { get; set; }

        [Required(ErrorMessage = "This Field of DeptName Is Required !!")]
        [MaxLength(50, ErrorMessage = "This Field Should be insert Max 50 Characters .")]
        public string DeptName { get; set; }

        public DateTime DateOfCreation { get; set; } = DateTime.Now;

        //Navigation Property [Many]
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
