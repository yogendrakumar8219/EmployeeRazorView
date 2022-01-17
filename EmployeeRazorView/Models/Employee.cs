using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeRazorView.Models
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage ="Please provide a value for Employee Name field"),MaxLength(50,ErrorMessage ="Name cannot exceed 50 character")]
        public string EmployeeName { get; set; }
        public Genders? Gender { get; set; }
        [Column(TypeName ="date")]
        [BindProperty, DataType(DataType.Date)]
        public DateTime DOB { get; set; }
    }
}
