using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Maui.Essentials;
using MsgApp_Client.Models;

namespace MsgApp_Client.Services
{
    public class DataContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        public DataContext()
        {
            SQLitePCL.Batteries_V2.Init();

            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "contacts.db3");

            optionsBuilder
                .UseSqlite($"Filename={dbPath}");
        }
    }
}