using System;
using System.Collections.Generic;

namespace PrimesifterPractice.Models {
    public class Primesifter {

        // list of ints we'll be sifting through
        private List<int> sifterList = new List<int>();

        public List<int> GetSifterList() { return sifterList; }

        // sift primes using Sieve of Eratosthenes method
        public List<int> SiftPrimesToN(int userMaxValue) {
            // generate list of ints from 2 to user provided int value
            PopulateSifterList(userMaxValue);

            int prime = 2;
            while (prime < userMaxValue) {
                for (int i = 0; i < sifterList.Count; i++)
                {
                    if (sifterList[i] % prime == 0)
                    {
                        sifterList.Remove(sifterList[i]);
                        i++;
                    }
                }
                prime++;
            }

            return sifterList;
        }

        public void PopulateSifterList(int nVal) {
            for (int i = 2; i <= nVal; i++) {
                sifterList.Add(i);
            }
        }
    }


}
