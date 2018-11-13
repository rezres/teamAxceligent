using JohnTheRobot;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{
    [TestClass]
    public class TestRobot
    {
        [TestMethod]
        public void TestSkillInvoke()
        {
            var john = new Humanoid(new Dancing());
            Assert.IsTrue(john.ShowSkill().Equals("Dancing"), $"John Robot skill should be Dancing but it is {john.ShowSkill()}");
        }
        [TestMethod]
        public void TestEmptyConstructor()
        {
            var bob = new Humanoid();
            Assert.IsTrue(bob.ShowSkill().Equals("no skill is defined"), $"bob should return no skill is defined but it is returning {bob.ShowSkill()} instead");
        }

    }

}
