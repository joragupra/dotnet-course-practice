using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Entities
{
    public class Person
    {
        private string identifier;

        public string Identifier
        {
            get { return identifier; }
            set { identifier = value; }
        }
        private IdentifierTypeEnum identifierType;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
