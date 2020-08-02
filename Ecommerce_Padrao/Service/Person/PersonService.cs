using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Person;

namespace Service.Person
{
    public class PersonService : IPersonService
    {
        private List<Models.Person.Person> people = new List<Models.Person.Person>
        {
            new Models.Person.Person
            {
                UserId=new Guid("2a4ada61-30f4-4211-a36e-ecb3171fb349"),
                Id=1,
                Name="Danilo"
            },
            new Models.Person.Person
            {
                UserId=new Guid("2a4ada61-30f4-4211-a36e-ecb3171fb369"),
                Id=2,
                Name="Danilo 2"
            },
            new Models.Person.Person
            {
                UserId=new Guid("2a4ada61-30f4-4211-a36e-ecb3171fb849"),
                Id=3,
                Name="Danilo 3"
            }
        };

        public Models.Person.Person Get(Models.Person.Person person)
        {
            var retorno = people.SingleOrDefault(x => x.UserId == person.UserId);

            if (retorno.Id == 0)
                throw new Exception("Pessoa não encontrada");

            return retorno;
        }

        public IEnumerable<Models.Person.Person> Search(Models.Person.Person person)
        {
            return people;
        }
    }
}
