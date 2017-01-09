using Microsoft.VisualStudio.TestTools.UnitTesting;
using UniTestsDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniTestsDemo.Tests
{
    [TestClass()]
    public class BankTests
    {
        [TestMethod]
        public void CreditTest()
        {
            //arrange
            Bank target = new Bank("Mr. Frank", 11.99);
            double amount = 1.1;

            //act  
            target.Credit(amount);

            //assert
            Assert.AreEqual(target.Balance, 13.09);
        }

        //[TestMethod]
        //public void DebitTest()
        //{
        //    Bank target = new Bank("Mr. Frank", 11.99);
        //    target.Debit(1.00);
        //    Assert.AreEqual(target.Balance, 10.99);  
        //}

        //[ClassInitialize]
        //public static void ClassInit(TestContext context)
        //{
        //    TimeSpan v = TimeSpan.FromSeconds(100);
        //    System.Threading.Thread.Sleep(v);
        //    System.Diagnostics.Trace.WriteLine("I was being run at First out of Five");
        //}

        //[TestInitialize]
        //public void TestInit()
        //{
        //    System.Diagnostics.Trace.WriteLine("I was being run at Second out of Five");
        //}

        //[TestMethod]
        //public void test1()
        //{
        //    System.Diagnostics.Trace.WriteLine("I'am Test 1,i was being run at Third out of Five");
        //}

        ////[TestMethod]
        ////public void test2()
        ////{
        ////    System.Diagnostics.Trace.WriteLine("I am Test 2, i was being run at Third out of Five");
        ////}

        //[TestCleanup]
        //public  void testCleanUp()
        //{
        //    System.Diagnostics.Trace.WriteLine("I was being run at Fouth out of Five");
        //}

        //[ClassCleanup]
        //public static void classCleanUp()
        //{
        //    System.Diagnostics.Trace.WriteLine("I was being run at Fifth out of Five");
        //}
    }
}