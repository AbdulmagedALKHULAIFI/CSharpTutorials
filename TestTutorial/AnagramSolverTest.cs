using CSharpTutorial.Algos;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTutorial
{
    class AnagramSolverTest
    {
        AnagramSolver anagramSolver;

        [SetUp]
        public void Setup()
        {
            anagramSolver = new AnagramSolver();
        }

        [Test]
        public void Angram_differentWords_false()
        {
            string firstWord = "a b c";
            string secondWord = "a b d";

            Assert.IsFalse(anagramSolver.IsAnagram(firstWord,secondWord));
        }

    }
}
