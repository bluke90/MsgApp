using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MsgApp_Server.Models;

namespace MsgApp_Server.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Message> Messages{ get; set; }
        public DbSet<Client> Clients { get; set; }

        public DataContext()
        {
            SQLitePCL.Batteries_V2.Init();

            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(Environment.CurrentDirectory, "Data.db3");

            optionsBuilder
                .UseSqlite($"Filename={dbPath}");
        }
    }
}

