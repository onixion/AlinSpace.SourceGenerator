using System;

namespace AlinSpace.CodeWriter
{
    public static partial class CodeExtensions
    {
        public static ICode Namespace(
            this ICode code, 
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
