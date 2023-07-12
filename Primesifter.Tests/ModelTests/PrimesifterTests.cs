using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimesifterPractice.Models;
using System.Collections.Generic;
using System;

namespace PrimesifterPractice.Tests 
{
    [TestClass]
    public class PrimesifterTests
    {
        [TestMethod]
        public void Primesifter_GeneratesListToNthValue_List() {
            // generate list
            Primesifter testSifter = new Primesifter();
            testSifter.PopulateSifterList(10);
            
            // expected output list
            List<int> expectedList = new List<int>();
            expectedList.Add(2);
            expectedList.Add(3);
            expectedList.Add(4);
            expectedList.Add(5);
            expectedList.Add(6);
            expectedList.Add(7);
            expectedList.Add(8);
            expectedList.Add(9);
            expectedList.Add(10);

            // test
            CollectionAssert.AreEqual(testSifter.GetSifterList(), expectedList);
        }
    }
}
