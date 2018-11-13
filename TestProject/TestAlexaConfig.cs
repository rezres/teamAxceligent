using AlexaProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class TestAlexaConfig
    {
        [TestMethod]
        public void TestInitialConstructor()
        {
            var alexa = new Alexa();
            Assert.IsTrue(alexa.Talk().Equals("hello, i am Alexa"), $"Greeting Message is wrong, expected output is hello, i am Alexa, actual output is {alexa.Talk()}");
        }

        [TestMethod]
        public void TestConfigurationInvoke()
        {
            var alexa = new Alexa();
            alexa.Configure(x =>
            {
                x.GreetingMessage = "Hello {OwnerName}, I'm at your service";
                x.OwnerName = "Bob Marley";
            });
            Assert.IsTrue(alexa.Talk().Equals("Hello Bob Marley, I'm at your service"),
                $"Greeting Message is wrong, expected output is Hello Bob Marley, I'm at your service, actual output is {alexa.Talk()}");
        }
    }
}
