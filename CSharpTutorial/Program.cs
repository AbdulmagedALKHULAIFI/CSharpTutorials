using CSharpTutorial.Algos;
using CSharpTutorial.Collections;
using CSharpTutorial.Examples;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpTutorial
{
   public class Program
    {

        //public static char[][] ConvertToJaggedArray(char[,] twoDimensionalArray)
        //{
        //    int rowsFirstIndex = twoDimensionalArray.GetLowerBound(0);
        //    int rowsLastIndex = twoDimensionalArray.GetUpperBound(0);
        //    int numberOfRows = rowsLastIndex - rowsFirstIndex + 1;

        //    int columnsFirstIndex = twoDimensionalArray.GetLowerBound(1);
        //    int columnsLastIndex = twoDimensionalArray.GetUpperBound(1);
        //    int numberOfColumns = columnsLastIndex - columnsFirstIndex + 1;

        //    char[][] jaggedArray = new char[numberOfRows][];
        //    for (int i = 0; i < numberOfRows; i++)
        //    {
        //        jaggedArray[i] = new char[numberOfColumns];

        //        for (int j = 0; j < numberOfColumns; j++)
        //        {
        //            jaggedArray[i][j] = twoDimensionalArray[i + rowsFirstIndex, j + columnsFirstIndex];
        //        }
        //    }
        //    return jaggedArray;
        //}

        static void Main(string[] args)
        {

            RetryExample retryer = new RetryExample();

            retryer.TestMethod();

            // ------------------------------------------
            //AlgosReslover resolver = new AlgosReslover();

            //var result = resolver.IsPalindrome("A man, a plan, a canal -- Panama");
            //Console.WriteLine("finished");



            //int[] result = resolver.TwoSum(new int [] { 3, 3 },6);

            //char[,] input = new char[,] { { '.', '8', '7', '6', '5', '4', '3', '2', '1' }, { '2', '.', '.', '.', '.', '.', '.', '.', '.' }, { '3', '.', '.', '.', '.', '.', '.', '.', '.' }, { '4', '.', '.', '.', '.', '.', '.', '.', '.' }, { '5', '.', '.', '.', '.', '.', '.', '.', '.' }, { '6', '.', '.', '.', '.', '.', '.', '.', '.' }, { '7', '.', '.', '.', '.', '.', '.', '.', '.' }, { '8', '.', '.', '.', '.', '.', '.', '.', '.' }, { '9', '.', '.', '.', '.', '.', '.', '.', '.' } };

            //char[][] jagged = ConvertToJaggedArray(input);

            //bool result = resolver.IsValidSudoku(jagged);


            // Polymorphisme Example
            //PolymorphismeExample pl = new PolymorphismeExample();
            //pl.ShowExample();

            // HashSet example 
            //HashSetExample hs = new HashSetExample();
            //hs.showExample();

            //Generic example 
            //Generic<int> g = new Generic<int>();
            //g.showExample();

            //Delegate example
            //Delegate d = new Delegate();
            //d.showExample();

            //Multithread example
            //MultiThread mt = new MultiThread();
            //mt.showExample();

            //Deadlock example
            //DeadLock dl = new DeadLock();
            //dl.showExample();

            //Collections example
            //ListExample list = new ListExample();
            //list.showExample();
        }
    }
}
