using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Algos
{
    class Letter
    {
        public List<Char> firstLine { get; set; }
        public List<Char> secondLine { get; set; }

        public List<Char> thirdLine { get; set; }
    }

    public class MessageDecoder
    {
        List<Letter> letters = new List<Letter>();


        public bool IsZero(int position)
        {
            Letter letter = letters[position];
            bool condition1 = false, condition2 = false, condition3 = false;


            if (letter.firstLine[0].Equals(" ") &&
                letter.firstLine[1].Equals("_") &&
                letter.firstLine[2].Equals(" "))
                condition1 = true;

            if (letter.secondLine[0].Equals("|") &&
            letter.secondLine[1].Equals(" ") &&
            letter.secondLine[2].Equals("|"))
                condition2 = true;

            if (letter.thirdLine[0].Equals(" ") &&
                letter.thirdLine[1].Equals("_") &&
                letter.thirdLine[2].Equals(" "))
                condition1 = true;

            return (condition1 && condition2 && condition3);
        }
    }
}
