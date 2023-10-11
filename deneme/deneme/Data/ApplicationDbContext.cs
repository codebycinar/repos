﻿using deneme.Model;
using deneme.Pages.User;
using Microsoft.EntityFrameworkCore;

namespace deneme.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }
        public DbSet<Category> Category { get; set; } // table 
        public DbSet<User> Users { get; set; } 
    }
}