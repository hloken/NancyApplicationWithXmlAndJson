using System;
using Nancy.Testing;

namespace Tests.Drivers
{
    public class TestModuleDriver
    {
        public static BrowserResponse GetAsJsonWithResponse(Browser browser)
        {
            return browser.Get("api/test",
                with =>
                {
                    with.Accept("application/json");
                    with.Body("My body is great!");
                    with.Cookie("sessionState", Guid.NewGuid().ToString());
                });
        }

        public static BrowserResponse GetAsXmlWithResponse(Browser browser)
        {
            return browser.Get("api/test",
                with => with.Accept("application/xml"));
        }
    }
}