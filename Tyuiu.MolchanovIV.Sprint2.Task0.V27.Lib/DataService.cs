using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MolchanovIV.Sprint2.Task0.V27.Lib
{
    public class DataService : ISprint2Task0V27
    {
        public bool[] GetCompareOperations(int x, int y)
        {

            bool[] result = new bool[6];

            if (x == y)
            {
                result[0] = true; result[1] = false;
            }
            else
            {
                result[0] = false; result[1] = true;
            }

            if (x < y)
            {
                result[2] = true; result[3] = false;
            }
            else
            {
                result[2] = false; result[3] = true;
            }

            if (x <= y)
            {
                result[4] = true; result[5] = false;
            }
            if (x >= y)
            {
                result[4] = false; result[5] = true;
            }
            return result;
        }
    }
}
