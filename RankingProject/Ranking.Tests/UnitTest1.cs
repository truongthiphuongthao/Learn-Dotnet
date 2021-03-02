using NUnit.Framework;
using System;


namespace Ranking.Tests
{
    public class Tests
    {
        [Test]
        // 1- excellent
        public void Should_Return_Excellent_With_Score_9()
        {
          Assert.AreEqual("excellent", Ranking.Rank(9));
        }

        [Test]
        // 2 - good
        public void Should_Return_Excellent_With_Score_7()
        {
          Assert.AreEqual("good", Ranking.Rank(7));
        }

        [Test]
        // 3 - avarage
        public void Should_Return_Excellent_With_Score_6()
        {
          Assert.AreEqual("average", Ranking.Rank(6));
        }

        [Test]
        // 4 - poor
        public void Should_Return_Excellent_With_Score_4()
        {
          Assert.AreEqual("poor", Ranking.Rank(4));
        }

        [Test]
        // 5 - bad
        public void Should_Return_Excellent_With_Score_1()
        {
          Assert.AreEqual("bad", Ranking.Rank(1));
        }

    }
}
