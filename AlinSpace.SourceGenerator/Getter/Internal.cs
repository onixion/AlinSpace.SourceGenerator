using System;

namespace AlinSpace.SourceGenerator.Getter
{
    internal class Internal : IGetter
    {
        public Body.Info BodyInfo { get; set; }

        public IGetter Body(Action<IBody> action)
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
                Body = BodyInfo,
            };
        }
    }
}
