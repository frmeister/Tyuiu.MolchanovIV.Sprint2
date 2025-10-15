using Tyuiu.MolchanovIV.Sprint2.Task0.V27.Lib;

namespace Tyuiu.MolchanovIV.Sprint2.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            bool[] res = new bool[6] { true, false, true, false, false, true };

            CollectionAssert.AreEqual(res, ds.GetCompareOperations(1305,275));

        }
    }
}
