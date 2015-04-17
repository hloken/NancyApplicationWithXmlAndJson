using Nancy;
using NancyApplicationWithXmlAndJson.Contracts;

namespace NancyApplicationWithXmlAndJson.Modules
{
    public class TestModule : NancyModule
    {
        public TestModule()
            : base("api/test")
        {
            Get[""] = parameters =>
            {
                return Negotiate
                    .WithModel(new Person
                    {
                        Name = "CrazyClown",
                        Age = 59
                    })
                    .WithStatusCode(HttpStatusCode.OK);
            };
        }
    }
}
