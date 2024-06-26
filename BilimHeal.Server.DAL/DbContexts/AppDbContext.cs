﻿using BilimHeal.Server.DAL.Configuration;
using BilimHeal.Server.Domain.Entities;
using BilimHeal.Server.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace BilimHeal.Server.DAL.DbContexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<User> Users { get; set; }
    public DbSet<QuizResult> QuizResults { get; set; }
    public DbSet<QuizFormat> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Seed Model
        modelBuilder.ApplyConfiguration(new AdminConfiguration());
        #endregion
    }
}