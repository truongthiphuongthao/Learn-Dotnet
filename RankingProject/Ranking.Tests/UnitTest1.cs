using NUnit.Framework;
using System;


namespace Ranking.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        //
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        //
        [Test]
        public void Should_Return_Excellent_With_Score_9()
        {
          Assert.AreEqual("excellent", Ranking.Rank(9f));
        }

      


    }
}
