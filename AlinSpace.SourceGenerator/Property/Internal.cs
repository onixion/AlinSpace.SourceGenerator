using System;

namespace AlinSpace.SourceGenerator.Property
{
    internal class Internal : IProperty
    {
        public AccessModifier AccessModifier { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public Getter.Info GetterInfo { get; set; }

        public Setter.Info SetterInfo { get; set; }

        public IProperty Getter(Action<IGetter> action)
        {
            var proxy = new Getter.Internal();
            action(proxy);
            GetterInfo = proxy.Build();

            return this;
        }

        public IProperty Setter(Action<ISetter> action)
        {
            var proxy = new Setter.Internal();
            action(proxy);
            SetterInfo = proxy.Build();

            return this;
        }

        public Info Build()
        {
            return new Info
            {
                AccessModifier = AccessModifier,
                Type = Type,
                Name = Name,
                Getter = GetterInfo,
                Setter = SetterInfo,
            };
        }
    }
}
