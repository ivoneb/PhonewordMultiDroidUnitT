using System;
using NUnit.Framework;
using PhonewordPCL;

namespace UnitTestApp2
{
    [TestFixture]
    public class TestsSample
    {
        [SetUp]
        public void Setup() { }

        [TearDown]
        public void Tear() { }

        [Test]
        public void Test_phonewordPassMethod()
        {
            Console.WriteLine("test1 phoneword translator");
            string output = PhonewordTranslator.ToNumber("ABCDEF");
            Assert.AreEqual("222333", output);
        }

        [Test]
        public void Test_phonewordFailMethod()
        {
            Console.WriteLine("test2 phoneword translator");
            string output = PhonewordTranslator.ToNumber("BCDEFG");
            Assert.AreEqual("223335", output);
        }

    }
}