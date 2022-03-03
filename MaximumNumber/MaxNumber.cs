using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumber
{
    public class MaxNumber<T> where T : IComparable
    {
        public T FindMax(T firstStr, T secondStr, T thirdStr)
        {
            if (firstStr.CompareTo(secondStr) > 0 && firstStr.CompareTo(thirdStr) > 0)
            {
                return firstStr;
            }
            if (secondStr.CompareTo(firstStr) > 0 && secondStr.CompareTo(thirdStr) > 0)
            {
                return secondStr;
            }
            return thirdStr;
        }
    }
}
