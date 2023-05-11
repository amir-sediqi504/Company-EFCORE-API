using Company.Data.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Entities
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        [MaxLength(50), Required]
        public string? FirstName { get; set; }
        [MaxLength(50), Required]
        public string? LastName { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        [Required]
        public decimal Salary { get; set; }
        public bool? UnionMember { get; set; }
        public virtual Department? Department { get; set; }
        public virtual ICollection<Title>? Titles { get; set; }
    }
}
