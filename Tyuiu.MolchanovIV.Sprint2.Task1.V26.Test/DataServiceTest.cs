using Tyuiu.MolchanovIV.Sprint2.Task1.V26.Lib;

namespace Tyuiu.MolchanovIV.Sprint2.Task1.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int a = 654, b = 671, c = 874, d = 137;

            bool[] res = new bool[6];
            bool[] wait = new bool[6] { true, true, true, false, true, false };
            res = ds.GetLogicOperations(a, b, c, d);

            CollectionAssert.AreEqual(res, wait);

        }
    }
}
