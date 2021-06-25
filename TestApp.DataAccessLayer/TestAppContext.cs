using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using TestApp.DataAccessLayer.Entities;

namespace TestApp.DataAccessLayer
{
    public class TestAppContext : DbContext
    {
        public DbSet<ContactInfo> ContactInfo { get; set; }
        public DbSet<Password> Password { get; set; }
        public DbSet<Areas> Areas { get; set; }
        public DbSet<Address> Address { get; set; }

        public TestAppContext(DbContextOptions options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.EnableSensitiveDataLogging();

        //    optionsBuilder.LogTo(_ =>
        //    {
        //        Console.WriteLine(_);
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine($"{Environment.NewLine}{new string('*', 80)}{Environment.NewLine}");
        //        Console.ResetColor();
        //    }, new[] { RelationalEventId.CommandExecuted });
        //}
    }
}
