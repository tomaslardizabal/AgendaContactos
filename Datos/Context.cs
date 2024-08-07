using Microsoft.EntityFrameworkCore;
using Entidades;
using System;

namespace Datos
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options) { }

        // Configure Id como Primary Key
        public DbSet<Entidades.Contacto> contactos { get; set; }


        public static Context CreateContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseSqlServer(@"Data Source=TOMASLARDIZABAL\SQLEXPRESS;Initial Catalog=Agenda;Integrated Security=True; TrustServerCertificate=True;");            
            return new Context(optionsBuilder.Options);
        }


    }
}
