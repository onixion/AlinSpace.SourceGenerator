using System.Collections.Generic;

namespace AlinSpace.SourceGenerator.Class
{
    public class Info
    {
        public string Name { get; set; }

        public AccessModifier AccessModifier { get; set; }

        public IList<Member.Info> Members { get; set; }

        public IList<Property.Info> Properties { get; set; }

        public IList<Constructor.Info> Constructors { get; set; }

        public IList<Method.Info> Methods { get; set; }
    }
}
