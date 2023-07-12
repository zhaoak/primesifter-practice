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

        [TestMethod]
        public void Primesifter_CorrectlySiftsPrimes_List() {
            // run sifter
            Primesifter testSifter = new Primesifter();

            // expected output list of primes
            List<int> correctPrimeList = new List<int>();
            correctPrimeList.Add(2);
            correctPrimeList.Add(3);
            correctPrimeList.Add(5);
            correctPrimeList.Add(7);
            correctPrimeList.Add(11);
            correctPrimeList.Add(13);
            correctPrimeList.Add(17);
            correctPrimeList.Add(19);
            correctPrimeList.Add(23);
            correctPrimeList.Add(29);
            correctPrimeList.Add(31);
            correctPrimeList.Add(37);
            correctPrimeList.Add(41);
            correctPrimeList.Add(43);
            correctPrimeList.Add(47);

            CollectionAssert.AreEqual(testSifter.SiftPrimesToN(50), correctPrimeList);
        }
    }
}
