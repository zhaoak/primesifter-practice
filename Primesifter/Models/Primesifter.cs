using System;
using System.Collections.Generic;

namespace Primesifter.Models {
    public class Primesifter {
        
        // list of ints we'll be sifting through
        private List<int> sifterList = new List<int>();

        public List<int> SiftPrimesToN(int userMaxValue) {

            
            return sifterList;
        }

        private void populateSifterList(int nVal) {
            for (int i = 2; i <= nVal; i++) {
                sifterList.Add(i);
            }
        }
    }


}
