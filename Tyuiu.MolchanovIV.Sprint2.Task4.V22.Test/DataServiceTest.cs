using Tyuiu.MolchanovIV.Sprint2.Task4.V22.Lib;

namespace Tyuiu.MolchanovIV.Sprint2.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double res = ds.Calculate(10.0, 12);

            Assert.AreEqual(res, 243.8);

        }
    }
}
