using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabTP4.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabTP4.Entities;

namespace LabTP4.Logic.Tests
{
    [TestClass()]
    public class CategoryLogicTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            List<Category> category = new List<Category>();
            CategoryLogic categoryLogic = new CategoryLogic();

            List<Category> expected = category.ToList();
            List<Category> actual = categoryLogic.GetAll();
            CollectionAssert.AreEquivalent(expected, actual);
           
        }
    }
}