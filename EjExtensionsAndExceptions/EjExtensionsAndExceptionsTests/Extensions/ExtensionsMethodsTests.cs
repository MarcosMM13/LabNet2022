using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjExtensionsAndExceptions.Extensions;
using EjExtensionsAndExceptions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjExtensionsAndExceptions.Extensions.Tests
{
    [TestClass()]
    public class ExtensionsMethodsTests
    {
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideTest()
        {
            int n1 = 5;
            ExtensionsMethods.Divide(n1);
        }

        [TestMethod()]
        public void DivideTest1()
        {
           
            int n1 = 10;
            int n2 = 2;
            int r = n1 / n2;
            int res = ExtensionsMethods.Divide(n1, n2);

            Assert.AreEqual(r,res);
        }
    }
}