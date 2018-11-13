using GameConstructor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class TestConstruction
    {
        [TestMethod]
        public void TestBuildInitial()
        {
            var myHouse = new Building()
            .AddKitchen()
            .AddBedroom("master")
            .AddBedroom("guest")
            .AddBalcony();
            myHouse.Build();
            //kitchen, master room, guest room, balcony
            Assert.IsTrue(myHouse.Describe().Equals("kitchen, master room, guest room, balcony"), $"Unexpected output error, expected output was kitchen, master room, guest room, balcony, actual output was {myHouse.Describe()}");
        }

        [TestMethod]
        public void EnsureDescriptionUpdateOnBuildOnly()
        {
            var myHouse = new Building()
            .AddKitchen()
            .AddBedroom("master")
            .AddBedroom("guest")
            .AddBalcony();
            myHouse.Build();
            myHouse.AddKitchen().AddBedroom("another");
            //before build the house description still is as before
            //kitchen, master room, guest room, balcony
            Assert.IsTrue(myHouse.Describe().Equals("kitchen, master room, guest room, balcony"), $"description shouldn't change until build is executed !");
            myHouse.Build();
            //description should be updated now
            Assert.IsTrue(myHouse.Describe().Equals("kitchen, master room, guest room, balcony, kitchen, another room"), $"description didn't change after build execution !");

        }
    }
}
