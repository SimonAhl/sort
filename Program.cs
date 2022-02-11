using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace dort
{
    class Program
    {
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
