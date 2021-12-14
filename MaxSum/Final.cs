using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSum
{
    class Final
    {
        public void Output(double max, int maxLine, List<string> defect)
        {
            Console.WriteLine(max);
            Console.WriteLine("Строка с максимальной суммой элементов - " + maxLine);
            Console.Write("Бракованные строки: ");
            for (int j = 0; j < defect.Count; j++)
            {
                if (j != defect.Count - 1)
                {
                    Console.Write(defect[j] + ", ");
                }
                else
                {
                    Console.Write(defect[j]);
                }
            }
        }
    }
}
