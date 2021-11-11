using Xunit;

namespace AlinSpace.CodeWriter.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var build = Code
                .New()
                .Using(p => p.Name = "AlinSpace.Database")
                .Using(p => p.Name = "AlinSpace.Database.Ef")
                .Namespace("AlinSpace.Database.Generated", p =>
                {
                    p.ClassPublic("MyClass", p =>
                    {
                        p.Property(p =>
                        {
                            p.Type = "int";
                            p.Name = "Test";

                            p.Getter(p =>
                            {
                                p.Body(p =>
                                {
                                    p.Line("return 2;");
                                });
                            });
                        });

                        p.MethodPublic("MyMethod", p =>
                        {
                            p.Arguments(p =>
                            {
                                p.Argument("int myArgument = 20");
                                p.Argument("int myArgument2 = 20");
                            });

                            p.Body(p =>
                            {
                                p.Line("myArgument = 40;");
                                p.Line("myArgument = 40;");
                                p.Line("myArgument = 40;");
                                p.Line("myArgument = 40;");
                            });
                        });
                    });
                })
                .Build();

            var sourceCode = new Writer(build).GenerateSourceCode();


        }
    }
}
