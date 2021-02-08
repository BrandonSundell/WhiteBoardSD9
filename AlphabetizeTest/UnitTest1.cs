using Microsoft.VisualStudio.TestTools.UnitTesting;
using Alphabetize;
namespace AlphabetizeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodMSSA()
        {
            Assert.AreEqual("amss", Sorts.StringSort("mssa"));
        }
        [TestMethod]
        public void TestMethodCat()
        {
            Assert.AreEqual("act", Sorts.StringSort("cat"));
        }
        [TestMethod]
        public void TestMethodDog()
        {
            Assert.AreEqual("dgo", Sorts.StringSort("dog"));
        }
        [TestMethod]
        public void TestMethodAndrew()
        {
            Assert.AreEqual("ADENRW", Sorts.StringSort("ANDREW"));
        }
        [TestMethod]
        public void TestMethodZero()
        {
            Assert.AreEqual("eorZ", Sorts.StringSort("Zero"));
        }
    }
    
   
}
