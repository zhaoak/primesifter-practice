using System;
using System.Collections.Generic;

namespace PrimesifterPractice.Models {
    public class Primesifter {
        
        // list of ints we'll be sifting through
        private List<int> sifterList = new List<int>();

        public List<int> GetSifterList() { return sifterList; }

        // sift primes using Sieve of Eratosthenes method
        public List<int> SiftPrimesToN(int userMaxValue) {
            PopulateSifterList(userMaxValue);
            
            return sifterList;
        }

        public void PopulateSifterList(int nVal) {
            for (int i = 2; i <= nVal; i++) {
                sifterList.Add(i);
            }
        }
    }


}
