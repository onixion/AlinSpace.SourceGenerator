using System;

namespace AlinSpace.CodeWriter.Method
{
    internal class Method : IMethod
    {
        public string Name { get; set; }

        public AccessModifier AccessModifier { get; set; }

        public Body.Info BodyInfo { get; set; }

        public IMethod Body(Action<IBody> action)
        {
            var proxy = new Body.Body();
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
