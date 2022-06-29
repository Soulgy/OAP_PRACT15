using NUnit.Framework;
using ClassLibrary1;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(Class1.Test("1", "Россия", "Екатеринбург", "Первомайская", "45", "6"));
        }
        [Test]
        public void Test2()
        {
            Assert.IsTrue(Class1.Test("werwe", "Россия", "Екатеринбург", "Первомайская", "45", "6"));
        }
        [Test]
        public void Test3()
        {
            Assert.IsTrue(Class1.Test("1", "Россия123", "Екатеринбург", "Первомайская", "45", "6"));
        }
        [Test]
        public void Test4()
        {
            Assert.IsTrue(Class1.Test("1", "Россия", "Екатеринбург333", "Первомайская", "45", "6"));
        }
        [Test]
        public void Test5()
        {
            Assert.IsTrue(Class1.Test("1", "Россия", "Екатеринбург", "Первомайская444", "45", "6"));
        }
        [Test]
        public void Test6()
        {
            Assert.IsTrue(Class1.Test("1", "Россия", "Екатеринбург", "Первомайская", "45rr", "6"));
        }
        [Test]
        public void Test7()
        {
            Assert.IsTrue(Class1.Test("1", "Россия", "Екатеринбург", "Первомайская", "45", "6rr"));
        }
    }
}