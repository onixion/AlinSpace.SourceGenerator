namespace AlinSpace.SourceGenerator
{
    public static partial class SourceExtensions
    {
        public static ISource Using(
            this ISource code,
            string name)
        {
            code.Using(p =>
            {
                p.Name = name;
            });

            return code;
        }
    }
}
