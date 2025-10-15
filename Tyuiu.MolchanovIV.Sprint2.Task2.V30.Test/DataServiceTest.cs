using Tyuiu.MolchanovIV.Sprint2.Task2.V30.Lib;

namespace Tyuiu.MolchanovIV.Sprint2.Task2.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            bool res;
            int x = 5, y = 5;

            res = ds.CheckDotInShadedArea(x, y);

            Assert.IsTrue(res);


        }
    }
}
