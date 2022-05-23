using Microsoft.EntityFrameworkCore;
using RePrjClinicAppoint.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RePrjClinicAppoint.Models
{
    public class DentalDbContext:DbContext
    {
        public DentalDbContext(DbContextOptions<DentalDbContext> opt):base(opt)
        {

        }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Details> Details { get; set; }

    
    }
}
