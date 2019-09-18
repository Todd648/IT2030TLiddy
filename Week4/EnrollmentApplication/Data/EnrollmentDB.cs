using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EnrollmentApplication.Models;

    public class EnrollmentDB : DbContext
    {
        public EnrollmentDB (DbContextOptions<EnrollmentDB> options)
            : base(options)
        {
        }

        public DbSet<EnrollmentApplication.Models.Enrollment> Enrollment { get; set; }
    }
