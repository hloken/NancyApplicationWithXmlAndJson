using Nancy.Testing;
using NancyApplicationWithXmlAndJson.Bootstrap;
using NUnit.Framework;
using Tests.Bdd;

namespace Tests.RestApi
{
    public abstract class RestApiBddTestBase : BddTestBase
    {
        private readonly Browser _browser;

        protected RestApiBddTestBase()
        {
            _browser = new Browser(new Bootstrapper());
        }

        public Browser Browser
        {
            get { return _browser; }
        }

        [SetUp]
        public override void SetUp()
        {
            Given();
            When();
        }
    }
}