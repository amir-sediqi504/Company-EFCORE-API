﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs
{
    public record CompanyDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int CompanyId { get; set; }
    }
}
