using System;
using Microsoft.EntityFrameworkCore;

namespace School.Models
{
    public class SchoolContext :DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }
        public DbSet<Student> Student{get;set;}
    }
}