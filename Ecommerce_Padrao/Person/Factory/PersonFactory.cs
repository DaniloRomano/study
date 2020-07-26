using Enum.Person;
using Person.Class;
using Person.Interface;
using System.Collections.Generic;

namespace Person.Factory
{
    public class PersonFactory
    {
        public IPerson GetPerson(EnumPersonType type)
        {
            IPerson person = null;
            switch (type)
            {
                case EnumPersonType.custumer:
                    person = new PersonCustomer();
                    break;
                default:
                    break;
            }
            return person;
        }
        
    }
}
