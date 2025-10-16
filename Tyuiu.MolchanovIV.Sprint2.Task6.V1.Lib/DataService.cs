using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MolchanovIV.Sprint2.Task6.V1.Lib
{
    public class DataService : ISprint2Task6V1
    {
        public int FindMonthDaysCount(int value)
        {
            int res = 0;

            switch (value)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: res = 31; break;
                case 2: res = 28; break;
                default: res = 30; break;
            }


            return res;
        }
    }
}
