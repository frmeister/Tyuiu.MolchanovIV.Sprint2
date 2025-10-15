using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MolchanovIV.Sprint2.Task2.V30.Lib
{
    public class DataService : ISprint2Task2V30
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (((x == 1) || (x > 13)) || ((y < 3) || (y > 12))) return false;

            if ((x == 2) && (y == 3)) return false;

            if ((x == 2) && (y > 6)) return false;

            if ((x < 7) && (y == 12)) return false;

            if ((x > 10) && (y == 12)) return false;

            if ((x == 13) && ((y > 7) || (y < 6))) return false;

            if (((x > 5) && (x < 9)) && (y < 5)) return false;

            if ((x != 6) && ((y < 11) && (y > 7))) return false;

            return true;
        }
    }
}
