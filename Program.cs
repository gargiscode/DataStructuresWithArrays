using System;

namespace DataStructuresWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //(1) Write an efficient program to find the sum of contiguous subarray
            //within a one-dimensional array of numbers which has the largest sum.
            findMaxSubArray();


            //(2) You are given a list of n-1 integers and these integers are in the
            //range of 1 to n. There are no duplicates in list. One of the integers
            //is missing in the list. Write an efficient code to find the missing
            //integer.
            findMissingIntInArray();


            //(3)Given an unsorted array of nonnegative integers, find a continous
            //subarray which adds to a given number.
            findNonNegSubArraySum();


            //(4) Given an unsorted array of integers, find a subarray which adds
            //to a given number. If there are more than one subarrays with sum as
            //the given number, print any of them.
            findNegativeSubArraySum();


            //(5) Write a program to sort an array of 0's,1's and 2's in ascending
            //order.
            sortArrayOf012();


            //(6) Equilibrium  index of an array is an index such that the sum of
            //elements at lower indexes is equal to the sum of elements at higher
            //indexes.
            int eqIndex = findEquilibriumIndex();
            Console.WriteLine("The equilibrium index is " + eqIndex);


            //(7)Write a program to print all the LEADERS in the array. An element
            //is leader if it is greater than all the elements to its right side.
            //And the rightmost element is always a leader. For example int the
            //array {16, 17, 4, 3, 5, 2}, leaders are 17, 5 and 2.
            printAllLeadersInArray();


            //(8)Given an array and a number k where k is smaller than size of array,
            //we need to find the k’th smallest element in the given array. It is
            //given that ll array elements are distinct.
            findKthSmallestNum();


            //(9)Given a 2D array, print it in spiral form. 
            print2DArrayInSpiral();


            //(10)Print the elements of an array in the decreasing frequency if 2
            //numbers have same frequency then print the one which came first.
            printDecreasingFreq();
        }

        static void findMaxSubArray()
        {

        }
        static int findEquilibriumIndex()
        {
            int i;
            int rightSum;
            int leftSum;
            int[] arr = { 3, 2, -1, 4, 1 };
            int[] sumArray = new int[arr.Length];

            // Form a cumulative sum array
            sumArray[0] = arr[0];
            for (i = 1; i < arr.Length; i++)
            {
                sumArray[i] = sumArray[i - 1] + arr[i];
            }

            // Next pass thru cumulative Array
            for (i = 1; i < arr.Length; i++)
            {
                leftSum = sumArray[i - 1];
                rightSum = sumArray[arr.Length - 1] - sumArray[i];
                if (leftSum == rightSum)
                {
                    return i;
                }
            }
            return -1;
        }

        static void findMissingIntInArray()
        {
            int i;
            int expectedSum =  0;
            int actualSum = 0;
            int missingNum = 0;
            int[] arr = { 1,6,2,4,5 };

            for (i = 0; i < arr.Length + 2; i++)
            {
                expectedSum = expectedSum + i;
                if (i < arr.Length)
                {
                    actualSum = actualSum + arr[i];
                }
            }

            for (i=1; i <= arr.Length + 1; i++)
            {
                //expectedSum
            }

            for (i=0; i < arr.Length; i++)
            {
                //actualSum = actualSum + arr[i];
            }

            missingNum = expectedSum - actualSum;
            Console.WriteLine("The missing integer is " + missingNum);
        }

        static void printAllLeadersInArray()
        {
            int i = 0;            
            int[] arr = { 16, 17, 4, 3, 5, 2 };
            
            int max = arr[arr.Length - 1];
            Console.WriteLine(max);

            for (i = arr.Length - 1; i>0; i--)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    Console.WriteLine(max);
                }
            }
        }

        static void findKthSmallestNum()
        {
            int i;
            int j;
            int temp;
            int k = 3; //read kth value from user
            int[] arr = { 16, 17, 4, 3, 5, 2 };
            int[] newArr = new int[k];

            int min = arr[0];
            int minIndex = 0;
            
            for (i = 0; i < k; i ++)
            {
                minIndex = i;
                min = arr[i];
                for (j = i; j < arr.Length; j++)
                {
                    if (min > arr[j])
                    {
                        // overwrite min
                        min = arr[j];
                        minIndex = j;
                    }
                }
                // at the end of this iteration swap min with first element
                temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }

            for (i=0; i < arr.Length; i++)
            Console.Write(" , "+arr[i]);
            
        }

        static void printDecreasingFreq()
        {
            
        }

        static void sortArrayOf012()
        {
            int[] arr = new int[] { 1, 2, 0, 0, 1, 2, 2 };
            int i = 0;
            int x = 0;
            int y = 0;
            int z = 0;

            for (i = 0; i < arr.Length; i++)
            {
                switch (arr[i])
                {
                    case 0:
                        x++;
                        break;
                    case 1:
                        y++;
                        break;
                    case 2:
                        z++;
                        break;
                }

            }

            for (i = 0; i < arr.Length; i++)
            {
                if (x > 0)
                {
                    arr[i] = 0;
                    x--;
                }
                else if (y > 0)
                {
                    arr[i] = 1;
                    y--;
                }
                else if (z > 0)
                {
                    arr[i] = 2;
                    z--;
                }
            }

        }

        static void print2DArrayInSpiral()
        {
            int [,] arr = new int[,] { {1, 2, 3, 4, 5, 6},
                         {7, 8 , 9 , 10, 11, 12 },
                         {13, 14, 15, 16, 17, 18 } };

            int i=0;
            int j=0;
            int numRows = arr.GetLength(0);
            int numCols = arr.GetLength(1);

            while (i < numRows)
            {
                for(j=0; j < numCols; j++)
                {
                    if (j == numCols - 1)
                    {
                        
                    }
                    else
                    {
                        Console.Write(arr[i, j]);
                    }
                }
                
            }
        

        }


        static void findNonNegSubArraySum()
        { 
        }

        static void findNegativeSubArraySum()
        { }
    }
}
