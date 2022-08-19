using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    public class Basic
    {
        int countN;
        int countName;
        int countNumberLinear;
        public void RecursionFunctionPrintN()
        {
            if (countN > 3)
                return;
            Console.WriteLine(countN);
            countN++;
            RecursionFunctionPrintN();
        }

        public void RecursionFunctionPrintName(int timestoprint)
        {
            if (countName == timestoprint)
                return;
            Console.WriteLine("My name is kumar shubham");
            countName++;
            RecursionFunctionPrintName(timestoprint);
        }

        public void RecursionFunctionPrintNumberLinearly(int printtill)
        {
            if (countNumberLinear >= printtill)
            {
                return;
            }
            Console.WriteLine(countNumberLinear + 1);
            countNumberLinear++;
            RecursionFunctionPrintNumberLinearly(printtill);
        }

        public void RecursionFunctionPrintNumberBackward(int printfrom)
        {
            if (printfrom == 0)
            {
                return;
            }
            Console.WriteLine(printfrom);
            printfrom--;
            RecursionFunctionPrintNumberBackward(printfrom);
        }

        public void RecursionFunctionPrintNumberWithBacktrack(int printtill)
        {
            if (printtill < 1)
            {
                return;
            }
            RecursionFunctionPrintNumberWithBacktrack(printtill - 1);
            Console.WriteLine(printtill);
        }

        public void RecursionFunctionPrintNumberBackwardWithBackTrack(int currentCounter, int printtill)
        {
            if (currentCounter > printtill)
            {
                return;
            }
            RecursionFunctionPrintNumberBackwardWithBackTrack(++currentCounter, printtill);
            Console.WriteLine(currentCounter);
        }

        public void RecurionFunctionForReversingArray(int leftpointer, int rightpointer, int[] arr)
        {
            if (Math.Abs(leftpointer - rightpointer) <= 1)
            {
                return;
            }
            RecurionFunctionForReversingArray(leftpointer + 1, rightpointer - 1, arr);
            int temp = arr[--rightpointer];
            arr[rightpointer] = arr[leftpointer];
            arr[leftpointer] = temp;
        }

        public bool RecursuinFunctionForCheckingPlaindromeString(int leftPointer, string Value)
        {
            bool isPalindromeOrNot = true;
            if (Math.Abs(leftPointer - (Value.Length - leftPointer)) <= 1)
            {
                return false;
            }
            RecursuinFunctionForCheckingPlaindromeString(leftPointer + 1, Value);
            if (Value.ToLower()[leftPointer] == Value.ToLower()[Value.Length - leftPointer - 1] && isPalindromeOrNot != false)
            {
                isPalindromeOrNot = true;
            }
            else
            {
                isPalindromeOrNot = false;
            }
            return isPalindromeOrNot;
        }

        public bool RecursionFunctionForCheckingPalindromStringEfficientWay(int lefpointer, string value)
        {
            if (lefpointer >= value.Length / 2)
            {
                return true;
            }
            if (value.ToLower()[lefpointer] != value.ToLower()[value.Length - lefpointer - 1])
            {
                return false;
            }
            return RecursionFunctionForCheckingPalindromStringEfficientWay(lefpointer + 1, value);
        }

        public void RecursionFunctionForPrinitingAllSubsequences(int pointer, int[] arr, List<int> list)
        {
            if (pointer > arr.Length - 1)
            {
                if (list.Count == 0)
                {
                    Console.WriteLine("{}");
                }
                //var sum = 0;
                list.ForEach(item => Console.Write(item + " "));
                //list.ForEach(item => sum += item);
                //if(sum == 3)
                //{
                //    list.ForEach(item => Console.Write(item + " "));
                //}
                Console.WriteLine("    ");
                // Console.WriteLine(list.ToString());
                return;
            }
            list.Add(arr[pointer]);
            RecursionFunctionForPrinitingAllSubsequences(pointer + 1, arr, list);
            list.Remove(arr[pointer]);
            RecursionFunctionForPrinitingAllSubsequences(pointer + 1, arr, list);
        }

        public Boolean RecursionFunctionForPrintingOneSubsequence(int index, int[] arr, List<int> list, int intendedSum, int totalSum)
        {
            if (index > arr.Length - 1)
            {
                if (intendedSum == totalSum)
                {
                    list.ForEach(item => Console.Write(item + " "));
                    return true;
                }
                else
                    return false;
            }

            totalSum += arr[index];
            list.Add(arr[index]);
            if (RecursionFunctionForPrintingOneSubsequence(index + 1, arr, list, intendedSum, totalSum) == true)
            {
                return true;
            }
            totalSum -= arr[index];
            list.Remove(arr[index]);
            if (RecursionFunctionForPrintingOneSubsequence(index + 1, arr, list, intendedSum, totalSum) == true)
            {
                return true;
            }
            return false;
        }

        public int RecursionFunctionForReturningSubsequenceCount(int index, int[] arr, List<int> list, int intendedSum, int totalSum, int Count)
        {
            if (index > arr.Length - 1)
            {
                if (intendedSum == totalSum)
                {
                    //list.ForEach(item => Console.Write(item + " "));
                    return 1;
                }
                else
                    return 0;
            }

            totalSum += arr[index];
            list.Add(arr[index]);
            int additionCalls = RecursionFunctionForReturningSubsequenceCount(index + 1, arr, list, intendedSum, totalSum, Count);

            totalSum -= arr[index];
            list.Remove(arr[index]);
            int subtractionCalls = RecursionFunctionForReturningSubsequenceCount(index + 1, arr, list, intendedSum, totalSum, Count);
            return additionCalls + subtractionCalls;
        }

        public void PrintAllCombinationSumUsingRecursion(int index, int target, List<List<int>> realList, List<int> list, int[] arr)
        {
            if (target == 0)
            {
                realList.Add(list);
                list.ForEach(item => Console.Write(item + " "));
                Console.WriteLine("  ");
                return;
            }
            if (index > arr.Length - 1)
            {
                return;
            }
            if (target < 0)
            {
                return;
            }
            //if (index == arr.Length)
            //{
            //    if (target == 0)
            //    {
            //        list.ForEach(item => Console.Write(item + " "));
            //        Console.WriteLine("  ");
            //    }
            //    return;
            //}
            list.Add(arr[index]);
            target -= arr[index];
            PrintAllCombinationSumUsingRecursion(index, target, realList, list, arr);
            list.Remove(arr[index]);
            target += arr[index];
            PrintAllCombinationSumUsingRecursion(index + 1, target, realList, list, arr);
        }

        public void PrintAllCombinationSumUsingRecursionStriverWay(int index, int target, List<List<int>> realList, List<int> list, int[] arr)
        {
            if (target == 0)
            {
                realList.Add(list);
                list.ForEach(item => Console.Write(item + " "));
                Console.WriteLine("  ");
                return;
            }
            if (index > arr.Length - 1)
            {
                return;
            }
            if (target < 0)
            {
                return;
            }
            //if (index == arr.Length)
            //{
            //    if (target == 0)
            //    {
            //        list.ForEach(item => Console.Write(item + " "));
            //        Console.WriteLine("  ");
            //    }
            //    return;
            //}
            list.Add(arr[index]);
            PrintAllCombinationSumUsingRecursionStriverWay(index, target - arr[index], realList, list, arr);
            list.Remove(arr[index]);
            PrintAllCombinationSumUsingRecursionStriverWay(index + 1, target, realList, list, arr);
        }

        public void PrintAllUniqueCombinationSum(int index, int target, List<List<int>> realList, List<int> list, int[] arr)
        {
            if (target == 0)
            {
                list.ForEach(item => Console.Write(item + " "));
                Console.WriteLine("   ");
                return;
            }

            for (int i = index; i < arr.Length; i++)
            {
                if (i > index && arr[i] == arr[i - 1]) continue;
                if (target < arr[i]) break;
                list.Add(arr[i]);
                target -= arr[i];
                PrintAllUniqueCombinationSum(i + 1, target, realList, list, arr);
                list.Remove(arr[i]);
                target += arr[i];
            }
        }

        public void FindSubSetSumUsingRecursion(int index, int sum, List<int> list, int[] arr)
        {
            if (index == arr.Length)
            {
                list.Add(sum);
                return;
            }
            FindSubSetSumUsingRecursion(index + 1, sum + arr[index], list, arr);
            FindSubSetSumUsingRecursion(index + 1, sum, list, arr);
        }

        public void PrintAllNonduplicateSubSequence(int index, List<int> list, int[] arr)
        {
            //if(index == arr.Length)
            //{
            list.ForEach(item => Console.Write(item + " "));
            Console.WriteLine("    ");
            //    return; 
            //}
            for (int i = index; i < arr.Length; i++)
            {
                if (i > index && arr[i] == arr[i - 1]) continue;
                list.Add(arr[i]);
                PrintAllNonduplicateSubSequence(i + 1, list, arr);
                list.Remove(arr[i]);
            }
        }

        public void FindUniqueSubsequenceSubsetSumUsingRecursion(int index, List<int> sumlist, int sum, int[] arr)
        {
            //if(index == arr.Length)
            //{
            sumlist.Add(sum);
            //    return;
            //}
            for (int i = index; i < arr.Length; i++)
            {
                if (i > index && arr[i] == arr[i - 1]) continue;
                //list.Add(arr[i]);
                FindUniqueSubsequenceSubsetSumUsingRecursion(i + 1, sumlist, sum + arr[i], arr);
                // list.Remove(arr[i]);
                //FindUniqueSubsequenceSubsetSumUsingRecursion(i + 1, list, sum, arr);
            }
        }

        public void FindAllPermutationOfArrayOrString(List<List<int>> anslist, List<int> list, int[] arr, bool[] frequency)
        {
            if (list.Count == arr.Length)
            {
                anslist.Add(list);
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (!frequency[i])
                {
                    frequency[i] = true;
                    list.Add(arr[i]);
                    FindAllPermutationOfArrayOrString(anslist, list, arr, frequency);
                    list.Remove(arr[i]);
                    frequency[i] = false;
                }
            }

        }

        public void FindAllPermutationOfArrayOrStringUsingSwapping(List<List<int>> anslist, List<int> list, int[] arr, int pointer)
        {
            if (pointer == arr.Length)
            {
                foreach(int i in arr)
                {
                    list.Add(i);
                }
                anslist.Add(list);
                return;
            }
            for (int i = pointer; i < arr.Length; i++)
            {
                int temp = arr[i];
                for (int j = i; j < arr.Length; j++)
                {
                    arr[i] = arr[j];
                    arr[j] = temp;
                    FindAllPermutationOfArrayOrStringUsingSwapping(anslist, list, arr, i + 1);
                }
            }
        }

        public void NQueensUsingRecursion(int column, List<List<string>> ansList,List<List<string>> list, int n)
        {
            if(column == n)
            {
                List<string> newBoard = new List<string>();
                for (int k = 0; k < n; k++)
                {
                    string row = string.Empty;
                    for (int j = 0; j < n; j++)
                        row += list[k][j];
                    newBoard.Add(row);
                }
                ansList.Add(newBoard);
                return;
            }
            for(int row = 0; row < n; row++)
            {
                if(isSafeToPlaceQueen(row, column))
                {
                    list[row][column] = "Q";
                    NQueensUsingRecursion(column + 1,ansList, list, n);
                    list[row][column] = ".";
                }
            }
             bool isSafeToPlaceQueen(int row, int column)
            {
                int realRow = row;
                int realColumn = column;
                while(column >=0 && row >=0)
                {
                    if (list[row][column] == "Q")
                        return false;
                    row--;
                    column--;
                }
                row = realRow;
                column = realColumn;
                while(column >=0)
                {
                    if (list[row][column] == "Q")
                        return false;
                    column--;
                }
                column = realColumn;
                row = realRow;
                while(row < n && column >=0)
                {
                    if (list[row][column] == "Q")
                        return false;
                    row++;
                    column--;
                }
                return true;
            }
        }

        //rowhash checks if queen is placed anywhere straight left on the board
        //upperdiagonlhash checks if queen is placed anywhere on left upperdiagonal of the board
        //lowerdiagonalhash checks if queen is placed anywhere on left lowerdiagonal of the board
        public void NQueensUsingRecursionEfficentWay(List<List<string>> anslist, List<List<string>> reallist,int[] rowhash, int[] upperdiagonalhash, int[] lowerdiagonalhash, int column, int ncount)
        {
            if(column == ncount)
            {
                List<string> boardrow = new List<string>();
                for(int i = 0; i<ncount; i++)
                {
                    string row = string.Empty;
                    for(int j = 0; j<ncount;j++)
                    {
                        row += reallist[i][j]; 
                    }
                    boardrow.Add(row);
                }
                anslist.Add(boardrow);
            }

            for(int row = 0; row<ncount;row++)
            {
                if(rowhash[row] == 0 && lowerdiagonalhash[row+column] == 0 && upperdiagonalhash[ncount-1 + column-row] == 0)
                {
                    reallist[row][column] = "Q";
                    rowhash[row] = 1;
                    lowerdiagonalhash[row + column] = 1;
                    upperdiagonalhash[ncount - 1 + column - row] = 1;
                    NQueensUsingRecursionEfficentWay(anslist, reallist, rowhash, upperdiagonalhash, lowerdiagonalhash, column + 1, ncount);
                    reallist[row][column] = ".";
                    rowhash[row] = 0;
                    lowerdiagonalhash[row + column] = 0;
                    upperdiagonalhash[ncount - 1 + column - row] = 0;
                }
            }
        }

        static bool[] freq = new bool[100];
        static int count;
        static List<char> list = new List<char>();
        public int findpermutationofstring(string S)
        {
            if (list.Count == S.Length)
            {
                list.ForEach(item => Console.Write(item + " "));
                count++;
            }
            for (int i = 0; i < S.Length; i++)
            {
                if (!freq[i])
                {
                    freq[i] = true;
                    list.Add(S[i]);
                    findpermutationofstring(S);
                    list.Remove(S[i]);
                    freq[i] = false;
                }
            }
            return count;
        }

        public string removeduplicatecharsfromstring(string s, bool duplicateFlag)
        {
            Console.WriteLine(s);
            StringBuilder sbl = new StringBuilder(s);
            int count = 1;
            bool majorduplicateflag = false;
            for(int i = 0; i< sbl.Length; i++)
            {
                //if(count != 1)
                //{
                //    i--;
                //}
                for(int j = i+1; j<sbl.Length; j++)
                {
                    if(sbl[i] == sbl[j])
                    {
                        count++;
                        duplicateFlag = true;
                        majorduplicateflag = true;
                    }
                    else
                    {
                        break;
                    }
                }
                if(duplicateFlag)
                {
                    sbl.Remove(i, count);
                    duplicateFlag = false;
                    count = 1;
                }  
            }
            if (!majorduplicateflag || sbl.Equals(""))
            {
                return sbl.ToString();
            }
            return removeduplicatecharsfromstring(sbl.ToString(), false);
        }
    }
}

