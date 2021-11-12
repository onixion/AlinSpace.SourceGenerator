using System;

namespace AlinSpace.SourceGenerator
{
    public static partial class SourceExtensions
    {
        public static ISource Namespace(
            this ISource code, 
            string name, 
            Action<INamespace> action)
        {
            code.Namespace(p =>
            {
                p.Name = name;
                action(p);
            });

            return code;
        }
    }
}
