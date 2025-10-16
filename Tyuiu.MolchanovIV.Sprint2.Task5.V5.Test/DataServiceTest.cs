using Tyuiu.MolchanovIV.Sprint2.Task5.V5.Lib;

namespace Tyuiu.MolchanovIV.Sprint2.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            string res = ds.FindCardValue(11), wait = "Валет";

            Assert.AreEqual(res, wait);

        }
    }
}
