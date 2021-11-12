using Xunit;

namespace AlinSpace.SourceGenerator.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var build = Source
                .New()
                .Using("AlinSpace.Database")
                .Using("AlinSpace.Database.Ef")
                .Namespace("AlinSpace.Database.Generated", p =>
                {
                    p.ClassPublic("MyClass", p =>
                    {
                        p.Member("public int test = 5");

                        p.ConstructorPublic(p =>
                        {
                            p.Argument("int test = 4");
                            p.Body(p =>
                            {
                                p.Line("Test");
                            });
                        });

                        p.PropertyPublic(p =>
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
                            p.Argument("int myArgument = 20");
                            p.Argument("int myArgument2 = 20");
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
