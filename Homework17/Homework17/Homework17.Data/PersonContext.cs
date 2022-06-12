using Homework17_ORM.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17.Data
{
    public class PersonContext:DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options) :
            base(options){}
       
        public DbSet<Person> Persons { get; set; }

        public DbSet<PersonAddress> PersonAddress { get; set; }

    }
}
