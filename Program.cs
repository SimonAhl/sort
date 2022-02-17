using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace dort
{
    class Program
    {

        public static int[] mergeSort(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];  

            if (array.Length <= 1)
                return array;              

            int midPoint = array.Length / 2;  

            left = new int[midPoint];
  
            if (array.Length % 2 == 0)
                right = new int[midPoint];  

            else
                right = new int[midPoint + 1];  

            for (int i = 0; i < midPoint; i++)
                left[i] = array[i];  
  
            int x = 0;

            
            for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }  

            left = mergeSort(left);
 
            right = mergeSort(right);

            result = merge(left, right);  
            return result;
        }
  

        public static int[] merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];

            int indexLeft = 0, indexRight = 0, indexResult = 0;  

            while (indexLeft < left.Length || indexRight < right.Length)
            {

                if (indexLeft < left.Length && indexRight < right.Length)  
                {  

                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }

                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }

                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }

                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }  
            }
            return result;
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
/* selectionsort
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
/* mergesort
            int[] intArr = intList.ToArray();
            intArr = mergeSort(intArr);
            intList = intArr.ToList();
*/
            watch.Stop();
    
            foreach(int i in intList){
                Console.WriteLine(i);
            }

            Console.WriteLine(watch.ElapsedMilliseconds + " ms");
        }
    }
}
