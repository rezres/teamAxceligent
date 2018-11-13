using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class TestUserClass
    {
        [TestMethod]
        public void TestUserCount()
        {
            var FirstUser = new User.User();
            FirstUser.Add("John");
            Assert.IsTrue(FirstUser.GetUsersCount() == 1,$"User count after adding one user should be 1, but it is returning {FirstUser.GetUsersCount()} instead");
            var SecondUser = new User.User();

            SecondUser.Add("Danial");
            Assert.IsTrue(SecondUser.GetUsersCount() == 2, $"User count after adding two user should be 2, but it is returning {SecondUser.GetUsersCount()} instead");
        }
        [TestMethod]
        public void EnsureSingleList() {
            var FirstUser = new User.User();
            FirstUser.Add("John");
            var SecondUser = new User.User();
            SecondUser.Add("Danial");
            Assert.IsTrue(SecondUser.GetUserList() == FirstUser.GetUserList(), $"List Didn't Match, ensure single instance of the list is created only !");


        }
    }
   
}
