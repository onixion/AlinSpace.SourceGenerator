﻿namespace AlinSpace.CodeWriter.Attribute
{
    internal class Internal : IAttribute
    {
        public string Name { get; set; }

        public Info Build()
        {
            return new Info
            {
                Name = Name,
            };
        }
    }
}
