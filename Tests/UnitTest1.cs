using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba2;

namespace Tests
   
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var n1 = new RomanNumber(50);
            var n2 = new RomanNumber(21);
            var res = n1 - n2;
            Assert.IsTrue(
               (n1 - n2).CompareTo(new RomanNumber(50 - 21)) == 0
           );
        }
        
        [TestMethod]
        public void TestMethod2()
        {
            var n1 = new RomanNumber(70);
            var n2 = new RomanNumber(12);
            var expected = new RomanNumber(70 + 12);
            var res = n1 + n2;
            Assert.IsTrue(res.CompareTo(expected) == 0);
        }
        
        [TestMethod]
        public void TestMethod3()
        {
            var n1 = new RomanNumber(5);
            var n2 = new RomanNumber(7);
            Assert.IsTrue(
                (n1 * n2).CompareTo(new RomanNumber(5 * 7)) == 0
            );
        }

        [TestMethod]
        public void TestMethod4()
        {
            var n1 = new RomanNumber(90);
            var n2 = new RomanNumber(90);
            Assert.IsTrue(n1.CompareTo(n2) == 0);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var n1 = new RomanNumber(99);
            var n2 = new RomanNumber(98);
            Assert.IsTrue(n1.CompareTo(n2) == 1);
        }
        [TestMethod]
        public void TestMethod6()
        {
            var n1 = new RomanNumber(22);
            var n2 = new RomanNumber(10);
            Assert.IsTrue(
                (n1 * n2).CompareTo(new RomanNumber(22 * 10)) == 0
            );
        }
        [TestMethod]
        public void TestMethod7()
        {
            var n1 = new RomanNumber(20);
            var n2 = new RomanNumber(15);
            Assert.IsTrue(
                (n1 * n2).CompareTo(new RomanNumber(20 * 15)) == 0
            );
        }
        [TestMethod]
        public void TestMethod8()
        {
            var n1 = new RomanNumber(9);
            var n2 = new RomanNumber(10);
            Assert.IsTrue(n1.CompareTo(n2) == -1);
        }
        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void TestMethod9()
        {
            var n1 = new RomanNumber(12);
            RomanNumber? n2 = null;
            var res = n1 + n2;
        }
        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void TestMethod10()
        {
            var n1 = new RomanNumber(9);
            var n2 = new RomanNumber(13);
            var res = n1 - n2;
        }
        [TestMethod]
        public void TestMethod11()
        {
            var n1 = new RomanNumber(110);
            var n2 = new RomanNumber(12);
            var expected = new RomanNumber(110 + 12);
            var res = n1 + n2;
            Assert.IsTrue(res.CompareTo(expected) == 0);
        }
        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void TestMethod12()
        {
            var n1 = new RomanNumber(232);
            var n2 = new RomanNumber(100);
            var res = n1 / n2;
        }

        [TestMethod]
        public void TestDiv2()
        {
            var n1 = new RomanNumber(10);
            var n2 = new RomanNumber(1);
            Assert.IsTrue((n1 / n2).CompareTo(new RomanNumber(10 / 1)) == 0);
        }
        [TestMethod]
        public void TestMethod14()
        {
            var number = new RomanNumber(5);
            Assert.AreEqual("V", number.ToString());
        }

        [TestMethod]
        public void TestMethod15()
        {
            var number = new RomanNumber(5);
            RomanNumber number2 = (RomanNumber)number.Clone();
            Assert.IsTrue(number.CompareTo(number2) == 0);
        }

    }

}
    
    

