using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MolchanovIV.Sprint2.Task3.V22.Lib
{
    public class DataService : ISprint2Task3V22
    {
        public double Calculate(double x)
        {
            double res = 0.0;
            
            if (x > 1)
            {
                res = x + (Math.Pow((x + 3) / (x - 1), x));

                return Math.Round(res, 3);

            } else if (x == 0)
            {
                res = (Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12);

                return Math.Round(res, 3);
            } else if ((x < 2) && (x > -26))
            {
                res = Math.Pow((3 + (2 / (Math.Pow(x, 2)))), x);

                return Math.Round(res, 3);
            } else if (x < -26)
            {
                res = x + 10 * x - (1 / x);

                return Math.Round(res, 3);
            }

            return Math.Round(res, 3); 
        }
    }
}
