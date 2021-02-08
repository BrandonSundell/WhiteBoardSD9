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
    }
}
