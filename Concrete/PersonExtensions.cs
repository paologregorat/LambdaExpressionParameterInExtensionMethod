using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LambdaExpressionParameter.Concrete
{
    public static class PersonExtensions
    {
        //person extension GenerateRandomName
        public static void GenerateRandomName(this Person person, Func<Person> action)
        {
            var randomPerson = action();
            person.FirstName = randomPerson.FirstName;
            person.LastName = randomPerson.LastName;
        }
        //person extension Mutate
        public static void Mutate(this Person person, Func<string, string> action)
        {
            person.FirstName = action(person.FirstName);
            person.LastName = action(person.LastName);
        }
    }
}
