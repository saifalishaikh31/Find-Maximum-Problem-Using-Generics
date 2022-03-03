using MaximumNumber;
using NUnit.Framework;

namespace MaximumNumberTest
{
    public class Tests
    {
        MaxNumber<int> maxInt = new MaxNumber<int>();
        MaxNumber<float> maxFloat = new MaxNumber<float>();
        MaxNumber<string> maxStr = new MaxNumber<string>();
        [Test]
        public void GivenThreeIntNumFirstPosition_WhenChecked_ThenShouldReturnMax()
        {
            int maximumInt = maxInt.FindMax(3, 2, 1);
            Assert.AreEqual(3, maximumInt);
        }

        [Test]
        public void GivenThreeIntNumSecondPosition_WhenChecked_ThenShouldReturnMax()
        {
            int maximumInt = maxInt.FindMax(2, 3, 1);
            Assert.AreEqual(3, maximumInt);
        }

        [Test]
        public void GivenThreeIntNumThirdPosition_WhenChecked_ThenShouldReturnMax()
        {
            int maximumInt = maxInt.FindMax(2, 1, 3);
            Assert.AreEqual(3, maximumInt);
        }

        [Test]
        public void GivenThreeFloatNumFirstPosition_WhenChecked_ThenShouldReturnMax()
        {
            float maximumFloat = maxFloat.FindMax(5.0f, 1.3f, 2.2f);
            Assert.AreEqual(5.0, maximumFloat);
        }

        [Test]
        public void GivenThreeFloatNumSecondPosition_WhenChecked_ThenShouldReturnMax()
        {
            float maximumFloat = maxFloat.FindMax(1.3f, 5.0f, 2.2f);
            Assert.AreEqual(5.0, maximumFloat);
        }

        [Test]
        public void GivenThreeFloatNumThirdPosition_WhenChecked_ThenShouldReturnMax()
        {
            float maximumFloat = maxFloat.FindMax(2.2f, 1.3f, 5.0f);
            Assert.AreEqual(5.0, maximumFloat);
        }
        [Test]
        public void GivenThreeStringFirstPosition_WhenChecked_ThenShouldReturnMax()
        {
            string maximumStr = maxStr.FindMax("Peach", "Apple", "Banana");
            Assert.AreEqual("Peach", maximumStr);
        }

        [Test]
        public void GivenThreeStringSecondPosition_WhenChecked_ThenShouldReturnMax()
        {
            string maximumStr = maxStr.FindMax("Apple", "Peach", "Banana");
            Assert.AreEqual("Peach", maximumStr);
        }

        [Test]
        public void GivenThreeStringThirdPosition_WhenChecked_ThenShouldReturnMax()
        {
            string maximumStr = maxStr.FindMax("Apple", "Banana", "Peach");
            Assert.AreEqual("Peach", maximumStr);
        }
    }
}