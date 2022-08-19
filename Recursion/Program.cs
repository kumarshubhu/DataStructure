using System;
using System.Collections.Generic;
using System.Linq;
//Console.WriteLine("shubham");


namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Basic b = new Basic();
            //b.RecursionFunctionPrintN();
            b.RecursionFunctionPrintName(6);
            b.RecursionFunctionPrintNumberLinearly(10);
            b.RecursionFunctionPrintNumberBackward(10);
            b.RecursionFunctionPrintNumberWithBacktrack(5);
            b.RecursionFunctionPrintNumberBackwardWithBackTrack(2,6);
            int[] arr = {  2, 4, 6  };
            int[] arrnew = { 1 ,1, 2 };
            //b.RecurionFunctionForReversingArray(0, arr.Length, arr);
            // string value = "Repapr";
            // bool rel = b.RecursuinFunctionForCheckingPlaindromeString(0, value);
            // bool rel1 = b.RecursionFunctionForCheckingPalindromStringEfficientWay(0, value);
            //b.RecursionFunctionForPrinitingAllSubsequences(0, arr, new List<int>());
            //b.RecursionFunctionForPrintingOneSubsequence(0, arr, new List<int>(), 3, 0);
            //int totalSubsequence = b.RecursionFunctionForReturningSubsequenceCount(0, arr, new List<int>(), 3, 0, 0);
            List<List<int>> realList = new List<List<int>>();
            List<int> list = new List<int>();
            //  b.PrintAllCombinationSumUsingRecursion(0, 4, realList, new List<int>(), arr);
            // b.PrintAllCombinationSumUsingRecursionStriverWay(0, 4, realList, new List<int>(), arr);
            //b.PrintAllUniqueCombinationSum(0, 4, realList, new List<int>(), arrnew);
            //b.FindSubSetSumUsingRecursion(0, 0, list, arr);
            //list.Sort();
               b.PrintAllNonduplicateSubSequence(0, new List<int>(), new int[] { 1,1,2 });
            List<int> sumlist = new List<int>();
            b.FindUniqueSubsequenceSubsetSumUsingRecursion(0, sumlist, 0, arrnew);
            bool[] frequency = new bool[arr.Length];
            List<List<int>> anslist = new List<List<int>>();
            b.FindAllPermutationOfArrayOrString(anslist, list, arr, frequency);
            b.FindAllPermutationOfArrayOrStringUsingSwapping(anslist, list, arr, 0);

            NQueensProblem nQueen = new NQueensProblem(4);
            var result = nQueen.Solutions;

            List<List<string>> reallist = new List<List<string>>();
            List<List<string>> ansList = new List<List<string>>();
            for (int i = 0; i < 4; i++)
            {
                List<string> row = Enumerable.Repeat(".", 4).ToList();
                reallist.Add(row);
            }

            //b.NQueensUsingRecursion(0, ansList, reallist, 4);
            int ncount = 4;
            b.NQueensUsingRecursionEfficentWay(ansList, reallist, new int[ncount], new int[2*ncount], new int[2*ncount], 0 , ncount);
            int res = b.findpermutationofstring("ABC");
            Console.Write(res);
            string result1 = b.removeduplicatecharsfromstring("abccbd", false);
            Console.WriteLine(result1);

        }   
    }
}   
