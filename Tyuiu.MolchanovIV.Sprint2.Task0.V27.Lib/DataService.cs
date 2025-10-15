using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MolchanovIV.Sprint2.Task0.V27.Lib
{
    public class DataService : ISprint2Task0V27
    {
        public bool[] GetCompareOperations(int x, int y)
        {

            bool[] result = new bool[6];

            result[0] = x == y + 1030;
            result[1] = x != y + 1030; 
            result[2] = x - 1300 < y;
            result[3] = x - 1300 > y;
            result[4] = x <= y;
            result[5] = x >= y;
       
            return result;
        }
    }
}
