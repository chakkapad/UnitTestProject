using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibraryUnitTestProject
{
    public class AssigamentClass
    {
        public string greadCalculate(int score)
        {
            if (score >= 80)
                return "A";
            else if (score >= 80 && score <= 75)
                return "B+";
            else if (score >= 75 && score <= 70)
                return "B";
            else if (score >= 70 && score <= 65)
                return "C+";
            else if (score >= 65 && score <= 60)
                return "C";
            else if (score >= 60 && score <= 55)
                return "D+";
            else if (score >= 55 && score <= 50)
                return "D";
            else
                return "F";


        }
        public double getDistance(int x1, int y1, int x2, int y2)
        {
            double x = x2 - x1;
            double y = y2 - y1;
            double sum = Math.Pow(x, 2) + Math.Pow(y, 2);
            double result = Math.Sqrt(sum);
            return Math.Round(result, 2);

        }
        public int getFactorial(int n)
        {
            if (n < 2)
                return 1;
            return n * getFactorial(n - 1);
        }
        public bool checkPassword(string password)
        {
            if (password.Length >= 8)
                return true;
            else
                return false;
        }
    }
}
