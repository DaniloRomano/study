using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Person
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Guid UserId { get; set; }
    }
}
