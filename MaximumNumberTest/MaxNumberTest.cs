using MaximumNumber;
using NUnit.Framework;

namespace MaximumNumberTest
{
    public class Tests
    {
        MaxNumber max = new MaxNumber();
        [Test]
        public void GivenThreeIntNumFirstPosition_WhenChecked_ThenShouldReturnMax()
        {
            int maximumInt = max.IntMax(3, 2, 1);
            Assert.AreEqual(3, maximumInt);
        }

        [Test]
        public void GivenThreeIntNumSecondPosition_WhenChecked_ThenShouldReturnMax()
        {
            int maximumInt = max.IntMax(2, 3, 1);
            Assert.AreEqual(3, maximumInt);
        }

        [Test]
        public void GivenThreeIntNumThirdPosition_WhenChecked_ThenShouldReturnMax()
        {
            int maximumInt = max.IntMax(2, 1, 3);
            Assert.AreEqual(3, maximumInt);
        }
    }
}