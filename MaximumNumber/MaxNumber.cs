using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumber
{
    public class MaxNumber
    {
        public int IntMax(int firstNum, int secondNum, int thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
            {
                return firstNum;
            }
            if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) > 0)
            {
                return secondNum;
            }
            return thirdNum;
        }
        public float FloatMax(float firstNum, float secondNum, float thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
            {
                return firstNum;
            }
            if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) > 0)
            {
                return secondNum;
            }
            return thirdNum;
        }
        public string StringMax(string firstStr, string secondStr, string thirdStr)
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
