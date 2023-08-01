using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using HospitalModel.Models;

namespace HospitalModel
{
    public class Class1 { }
    public class ModelDbContext : DbContext
        
    {
        public DbSet<Admin> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Zipcode> Zipcodes { get; set; }
        public DbSet<Department> Departments { get; set; }

       // public ModelDbContext(DbContextOptions<ModelDbContext> options) : base(options)
        
        }

      
    }
