using Tyuiu.MolchanovIV.Sprint2.Task3.V22.Lib;

namespace Tyuiu.MolchanovIV.Sprint2.Task3.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double res = ds.Calculate(-30);

            Assert.AreEqual(res, -330,033);

        }
    }
}
