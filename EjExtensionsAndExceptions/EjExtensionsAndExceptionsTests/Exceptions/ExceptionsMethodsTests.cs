using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjExtensionsAndExceptions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjExtensionsAndExceptions.Exceptions.Tests
{
    [TestClass()]
    public class ExceptionsMethodsTests
    {
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByNumbersExTest()
        {
            int n1 = 5;
            int n2 = 0;
            double r = 0;

            ExceptionsMethods.DivideNumbersEx(n1, n2, r);

        }
    }
}