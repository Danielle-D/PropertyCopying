using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyCopying
{
    public class Person
    {
        [MatchParent("Username")]
        public string Name { get; set; }


        [MatchParent("UserFirstName")]
        public string PersonFirstName { get; set; }

        [MatchParent("UserLastName")]
        public string PersonLastName { get; set; }
    }
}
