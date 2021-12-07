using Microsoft.VisualStudio.TestTools.UnitTesting;
using vectores;

namespace TestVec
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Vector asd = new Vector(1, 2);
            Assert.IsNotNull(asd);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Vector asd = new Vector(1, 2);
            Assert.IsNotNull(asd.Magnitude());
        }
        [TestMethod]
        public void TestMethod3()
        {
            Vector asd = new Vector(1, 2);
            Vector dsa = new Vector(3, 4);
            Assert.IsNotNull(asd.DotProduct(dsa));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Vector asd = new Vector(1, 2);
            Vector dsa = new Vector(3, 4);
            Assert.IsNotNull(asd.AngleBetween(dsa));
        }
        [TestMethod]
        public void TestMethod5()
        {
            Vector asd = new Vector(1, 2);
            Vector dsa = new Vector(3, 4);
            Assert.IsNotNull(asd.AngleBetween(dsa));
        }
    }
}
