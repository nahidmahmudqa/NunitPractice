using NUnit.Framework;

namespace NunitPractice
{
    public class UnitTest3
    { 
        public class Tests
        {
            [Test]
            public void Test_AreEqual()
            {
                int m= 5;
                Assert.AreEqual(m, 5, "M value mismatched");
                Assert.That(m, Is.EqualTo(5), "M value mismatched");
            }

            [Test]
            public void Test_AreNotEqual()
            {
                int m = 6;
                Assert.AreNotEqual(m, 5, "M value mismatched");
                Assert.That(m, Is.Not.EqualTo(5), "M value mismatched");
            }
        }
    }
}
