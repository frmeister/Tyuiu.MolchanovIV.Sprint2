using Tyuiu.MolchanovIV.Sprint2.Task6.V1.Lib;

namespace Tyuiu.MolchanovIV.Sprint2.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int res = ds.FindMonthDaysCount(1);

            Assert.AreEqual(31, res);

        }
    }
}
