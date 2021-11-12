using System;

namespace AlinSpace.SourceGenerator.Setter
{
    internal class Internal : ISetter
    {
        public Body.Info BodyInfo { get; set; }

        public ISetter Body(Action<IBody> action)
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
