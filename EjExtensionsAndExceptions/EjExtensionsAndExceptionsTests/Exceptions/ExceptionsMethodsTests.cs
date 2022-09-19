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
        public void DivideByZeroExTest()
        {
            int n1 = 5;
           ExceptionsMethods.DivideByZeroEx(n1);
        }

        [TestMethod()]
        public void DivideNumbersExTest()
        {
            int n1 = 25;
            int n2 = 5;
            ExceptionsMethods.DivideNumbersEx(n1,n2);
        }
    }
}