﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Entities;
namespace Company.Data.Contexts
{
    public class CompanyContext : DbContext
    {
        public DbSet<Entities.Company> Companies => Set<Entities.Company>();
        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Title> Titles => Set<Title>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<EmployeeTitle> EmployeeTitles => Set<EmployeeTitle>();


        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {
        }
        private void SeedData(ModelBuilder builder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EmployeeTitle>().HasKey(et => new { et.EmployeeId, et.TitleId });
        }
    }
}
