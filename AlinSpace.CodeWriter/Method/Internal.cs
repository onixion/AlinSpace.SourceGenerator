using System;

namespace AlinSpace.CodeWriter.Method
{
    internal class Internal : IMethod
    {
        public string Name { get; set; }

        public AccessModifier AccessModifier { get; set; }

        public string ReturnType { get; set; } = Constants.Void;

        public Attributes.Info AttributesInfo { get; set; }

        public Arguments.Info ArgumentsInfo { get; set; }

        public Body.Info BodyInfo { get; set; }

        public IMethod Attributes(Action<IAttributes> action)
        {
            var proxy = new Attributes.Internal();
            action(proxy);
            AttributesInfo = proxy.Build();

            return this;
        }

        public IMethod Arguments(Action<IArguments> action)
        {
            var proxy = new Arguments.Internal();
            action(proxy);
            ArgumentsInfo = proxy.Build();

            return this;
        }

        public IMethod Body(Action<IBody> action)
        {
            var proxy = new Body.Internal();
            action(proxy);
            BodyInfo = proxy.Build();

            return this;
        }

        public Info Build()
        {
            return new Info
            {
                Name = Name,
                AccessModifier = AccessModifier,
                Body = BodyInfo,
            };
        }
    }
}
