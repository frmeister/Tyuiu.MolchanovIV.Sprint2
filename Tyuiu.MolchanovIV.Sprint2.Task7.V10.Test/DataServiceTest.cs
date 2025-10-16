using Tyuiu.MolchanovIV.Sprint2.Task7.V10.Lib;

namespace Tyuiu.MolchanovIV.Sprint2.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0.0, y = 0.0;

            bool res = ds.CheckDotInShadedArea(x, y);

            Assert.AreEqual(res, true);

        }
    }
}
