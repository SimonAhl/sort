using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace dort
{
    class Program
    {

        static List<int> MergeSort(List<int> intList){
            if(intList.Count <= 1)
                return intList;
            /*
            List<int> firstHalf = new List<int>();
            List<int> secondHalf = new List<int>();

            List<int> doneList = new List<int>();
            */

            int[] secondHalf;
            int[] doneList;

            int mid = intList.Count / 2;

            int[] firstHalf = new int[mid];
            if(firstHalf.Length % 2 == 0){
                secondHalf = new int[mid];
            }else{
                secondHalf = new int[mid + 1];
            }

            for(int i = 0; i < mid; i++){
                firstHalf[i] = intList[i];
            }

            for (int i = mid; i < intList.Count; i++){
                secondHalf[i - mid] = intList[i];
            }

        }
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();

            Random ran = new Random();

            Stopwatch watch = new Stopwatch();

            for(int i = 0; intList.Count < 1000; i++){
                intList.Add(ran.Next(1, 1001));
            }

            watch.Start();
/* bubbelsort
            for(int i = 0; i < intList.Count- 1; i++){
                for(int j = 0; j < intList.Count -1; j++){
                    if(intList[j] > intList[j+1]){
                        int a = intList[j];
                        intList[j] = intList[j + 1];
                        intList[j+1] = a;
                    }
                }
            }
*/
/*
            int first;
            for (int i = 0; i < intList.Count - 1; i++){

                first = i;

                for(int j = first; j < intList.Count; j++){
                    if (intList[j] < intList[first]){
                        int a = intList[j];
                        intList[j] = intList[first];
                        intList[first] = a;
                    }
                }
            }
*/
            watch.Stop();
    
            foreach(int i in intList){
                Console.WriteLine(i);
            }

            Console.WriteLine(watch.ElapsedMilliseconds + " ms");
        }
    }
}
