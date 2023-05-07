using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int? Age { get; set; }

        public string Address { get; set; }

        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        public bool IsActive { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string ImageName { get; set; }

        public DateTime HireDate { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;

        //Add new Foreign Key for Department
        [ForeignKey("Department")]
        public int? FKDepartment { get; set; }

        //Navigation Property [One]
        public Department Department { get; set; }

    }
}
