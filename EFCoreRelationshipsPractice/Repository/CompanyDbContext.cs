﻿using EFCoreRelationshipsPractice.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCoreRelationshipsPractice.Repository
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options)
            : base(options)
        {
        }

        public DbSet<CompanyEntity> CompanyEntities { get; set; }
        public DbSet<ProfileEntity> ProfileEntities { get; set; }
        public DbSet<EmployeeEntity> EmployeeEntities { get; set; }

    }
}