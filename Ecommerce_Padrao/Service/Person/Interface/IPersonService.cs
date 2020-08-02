using System;
using System.Collections.Generic;

namespace Service.Person
{
    public interface IPersonService
    {
        Models.Person.Person Get(Models.Person.Person person);

        IEnumerable<Models.Person.Person> Search(Models.Person.Person person);
    }
}
