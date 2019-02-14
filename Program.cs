using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public static void arr(int n, string[] s)
        {
            int[] a = new int[n];
            //new array with the size n
            int[] a2 = new int[n * 2];
            //new array with the size which was doubled of previous array
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(s[i]);
                //array a equal to the array s and immediately convert it to the int as it was string 
                a2[j] = a[i];
               
                a2[j + 1] = a[i];
                j = j + 2;
                // increment the value j by 2, as we giv the value of i to two place to j 
            }
            foreach (var m in a2)
                //iterate the array and display the value
            {
                Console.Write(m + " ");
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            // read the size of the array 
            string ss = Console.ReadLine();
            // read the string var 
            string[] s = ss.Split(' ');
            //split the ss var and put it to the array 
            arr(n, s);
            //give the array and sive of the array to function arr
        }
    }
}

/*0 1 --> 0
2 3 --> 1
4 5 --> 2*/