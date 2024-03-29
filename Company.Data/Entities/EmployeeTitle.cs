﻿using Company.Data.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Entities
{
    public class EmployeeTitle : IReferenceEntity
    {
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public int TitleId { get; set; }
        public virtual Employee? Employee { get; set; }
        public virtual Title? Title { get; set; }
    }
}
