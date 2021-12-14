using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max;
using MaxSum;

namespace Max
{
    public class Calculation
    {
        public int calc(string path)
        {
            Reading resume = new Reading();
            Final exit = new Final();
            string[] str = resume.Read(path);
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalDigits = '.',
            };
            double max = double.MinValue;
            double a = 0;
            double compare = 0;
            int line = 1;
            int maxLine = 0;
            List<string> defect = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                string[] ok = str[i].Split(',');
                for (int j = 0; j < ok.Length; j++)
                {
                    bool result = double.TryParse(ok[j], NumberStyles.Number, numberFormatInfo, out a);
                    if (result == true)
                    {
                        compare += a;
                    }
                    else
                    {
                        compare = 0;
                        defect.Add(Convert.ToString(line));
                        break;
                    }
                }
                if (compare > max)
                {
                    max = compare;
                    maxLine = line;
                }
                compare = 0;
                line += 1;
            }
            exit.Output(max, maxLine, defect);
            Console.Write("\n");
            return maxLine;
        }
    }
}
