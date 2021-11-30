using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infracstruture.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }

        public DbSet<Musics> Musics { get; set; }
        public DbSet<Singers> Singers { get; set; }
        public DbSet<Albums> Albums {get; set;}

        
    }
}
