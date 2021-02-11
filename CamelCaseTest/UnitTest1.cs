using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CamelCaseTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("theCatInTheHat", (CamelCaseAndPascalCase.CamelCase.ConvertToCamel("The Cat In The Hat")));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("theDogRuns", (CamelCaseAndPascalCase.CamelCase.ConvertToCamel("The Dog Runs")));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("bustTheRobber", (CamelCaseAndPascalCase.CamelCase.ConvertToCamel("Bust The robber")));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual("dropTheInHere", (CamelCaseAndPascalCase.CamelCase.ConvertToCamel("Drop The ! IN here")));
        }
    }
}
