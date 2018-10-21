using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace PropertyCopying
{
    [Binding]
    public class CreateUserSteps
    {

        [Given(@"a valid user is set up")]
        public void GivenAValidUserIsSetUp()
        {
            User user = new User();
            Person personMatch = new Person();
            user.Username = "Danielle-D";
            user.UserFirstName = "Danielle";
            user.UserLastName = "D";

            PropertyMatcher<User, Person>.GenerateMatchedObject(user, personMatch);

            Console.WriteLine(user);
            Console.WriteLine(personMatch);
        }
    }
}