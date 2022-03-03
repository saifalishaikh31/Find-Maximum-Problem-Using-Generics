using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumber
{
    public class MaxNumber<T> where T : IComparable
    {
        public T firstStr, secondStr, thirdStr, fourthStr;

        public MaxNumber(T firstStr, T secondStr, T thirdStr, [Optional] T fourthStr)
        {
            this.firstStr = firstStr;
            this.secondStr = secondStr;
            this.thirdStr = thirdStr;
            this.fourthStr = fourthStr;
        }

        public T FindMax()
        {
            if (firstStr.CompareTo(secondStr) > 0 && firstStr.CompareTo(thirdStr) > 0 && firstStr.CompareTo(fourthStr) > 0)
            {
                return firstStr;
            }
            if (secondStr.CompareTo(firstStr) > 0 && secondStr.CompareTo(thirdStr) > 0 && secondStr.CompareTo(fourthStr) > 0)
            {
                return secondStr;
            }
            if (thirdStr.CompareTo(firstStr) > 0 && thirdStr.CompareTo(secondStr) > 0 && thirdStr.CompareTo(fourthStr) > 0)
            {
                return thirdStr;
            }
            return fourthStr;
        }
        public void Print(T var)
        {

            Console.WriteLine(var);
        }

    }
}
