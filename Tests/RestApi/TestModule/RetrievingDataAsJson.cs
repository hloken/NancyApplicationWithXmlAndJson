using FluentAssertions;
using Nancy;
using Nancy.Testing;
using Tests.Bdd;
using Tests.Drivers;

namespace Tests.RestApi.TestModule
{
    public class RetrievingDataAsJson : RestApiBddTestBase
    {
        private BrowserResponse _browserResponse;

        protected override void Given()
        {
        }

        protected override void When()
        {
            _browserResponse = TestModuleDriver.GetAsJsonWithResponse(Browser);
        }

        [Then]
        public void ShouldReturnOk()
        {
            _browserResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}