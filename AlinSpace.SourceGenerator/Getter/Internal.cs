using System;

namespace AlinSpace.SourceGenerator.Getter
{
    internal class Internal : IGetter
    {
        private Body.Info body;

        public IGetter Body(Action<IBody> action)
        {
            var proxy = new Body.Internal();
            action(proxy);
            body = proxy.Build();

            return this;
        }

        public Info Build()
        {
            return new Info(body);
        }
    }
}
