namespace AlinSpace.SourceGenerator
{
    public static partial class ClassExtensions
    {
        public static IClass Member(
            this IClass @class, 
            string text)
        {
            @class.Member(p =>
            {
                p.Text = text;
            });

            return @class;
        }
    }
}
