using MacrixSample.Database.Entities.Persons;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Options;
using System;

namespace MacrixSample.Database
{
    public class MacrixDbContext: DbContext
    {

        public DbSet<Person> Persons { get; set; }
        protected readonly IConfiguration Configuration;

        public MacrixDbContext()
        {
          //  var builder = new ConfigurationBuilder()
          //.AddJsonFile("appsettings.json");


          //  Configuration = builder.Build(); ;
        }

        public MacrixDbContext(DbContextOptions<MacrixDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //TODO move to appsettings.json
            optionsBuilder.UseSqlServer("Server=(localdb)\\LocalDBApp1;Database=Macrix3");
            //optionsBuilder.UseSqlServer(Configuration.GetConnectionString("MacrixDbContext"));
        }


    }
}
