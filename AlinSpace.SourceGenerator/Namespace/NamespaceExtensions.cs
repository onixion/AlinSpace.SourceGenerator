using System;

namespace AlinSpace.SourceGenerator
{
    public static class NamespaceExtensions
    {
        public static INamespace Class(
            this INamespace @namespace,
            string name,
            Action<IClass> action)
        {
            @namespace.Class(p =>
            {
                p.Name = name;
                action(p);
            });

            return @namespace;
        }

        public static INamespace ClassPublic(
            this INamespace @namespace,
            string name,
            Action<IClass> action)
        {
            @namespace.Class(p =>
            {
                p.Name = name;
                p.AccessModifier = AccessModifier.Public;
                action(p);
            });

            return @namespace;
        }
    }
}
