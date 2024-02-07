using CSharpTutorial.Algos;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTutorial.Algos
{
    class AnagramSolverTest
    {
        DistributionSolver anagramSolver;

        [SetUp]
        public void Setup()
        {
            anagramSolver = new DistributionSolver();
        }

        [Test]
        public void Angram_differentWords_false()
        {
            string firstWord = "a b c";
            string secondWord = "a b d";

            Assert.IsFalse(anagramSolver.IsAnagram(firstWord, secondWord));
        }

    }
}
