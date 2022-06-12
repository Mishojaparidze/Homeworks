using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17_ORM.Domain
{
    public class PersonAddress
    {       
            public int Id { get; set; }
            public int PersonId { get; set; }
            public string Country { get; set; }
            public string City { get; set; }
            public int HomeNumber { get; set; }
    }
}
