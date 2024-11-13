//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Arraydemos
//{
//    internal class ArrayMethods
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = new int[10] { 1, 2, 7, 4, 3, 2, 13, 7, 8, 9 };
//            int[] arr2 = new int[5];

//            Array.Sort(arr);
            
//            for(int i = 0;i<arr.Length;i++)
//            {
//                Console.WriteLine(arr[i]);
//            }

//            Console.WriteLine("------Reverse method--------");

//            Array.Reverse(arr);
//            for (int i = 0; i < arr.Length; i++)
//            {
//                Console.WriteLine(arr[i]);
//            }

//            Console.WriteLine("-----clear method-------");
//            Array.Clear(arr,5,3);

//            for (int i = 0; i < arr.Length; i++)
//            {
//                Console.WriteLine(arr[i]);
//            }

//            Console.WriteLine("-------copy-------");

//            Array.Copy(arr, 3, arr2, 0, 4);
//            for (int i = 0; i < arr2.Length; i++)
//            {
//                Console.WriteLine(arr2[i]);
//            }
//        }
//    }
//}
