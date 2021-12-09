using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Algos
{
    public class AnagramSolver
    {

        public bool IsAnagram(string wordOne, string wordTwo)
        {

            if (wordOne.ToLower().Equals(wordTwo.ToLower()))
                return true;

            var letterList1 = wordOne.ToCharArray();
            var letterList2 = wordTwo.ToCharArray();

            Array.Sort(letterList1);
            Array.Sort(letterList2);

            return letterList1 == letterList2;

        }

    }
}
