namespace AlinSpace.CodeWriter
{
    public class CodeFormat
    {
        public bool Compact { get; }

        public CodeFormat(bool compact = true)
        {
            Compact = compact;
        }

        public static CodeFormat WithCompact()
        {
            return new CodeFormat();
        }
    }
}
