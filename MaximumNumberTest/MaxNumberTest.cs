using MaximumNumber;
using NUnit.Framework;

namespace MaximumNumberTest
{
    public class Tests
    {
        MaxNumber<int> maxInt = new MaxNumber<int>(1, 2, 3, 4);
        MaxNumber<float> maxFloat = new MaxNumber<float>(4.0f, 4.0f, 6.0f);
        MaxNumber<string> maxStr = new MaxNumber<string>("Apple", "WaterMelon", "Peach", "Mango");
        [Test]
        public void GivenIntThenShouldReturnMax()
        {
            int maximumInt = maxInt.FindMax();
            Assert.AreEqual(4, maximumInt);
            maxInt.Print(maximumInt);
        }

       

        [Test]
        public void GivenFloatThenShouldReturnMax()
        {
            float maximumFloat = maxFloat.FindMax();
            Assert.AreEqual(6.0, maximumFloat);
            maxFloat.Print(maximumFloat);
        }

       
        [Test]
        public void GivenStringThenShouldReturnMax()
        {
            string maximumStr = maxStr.FindMax();
            Assert.AreEqual("WaterMelon", maximumStr);
            maxStr.Print(maximumStr);
        }

    }
}