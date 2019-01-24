using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnome_Sort
{
    class Program
    {
        static void Main(string[] args)
        {

            Sort();

        }
        static void Sort()
        {
            //Intializing
            int length; int[] arr; int op;
            char a;
            Console.WriteLine("---------->GNOME SORT<----------");
            Console.Write("Enter Length: ");
            length = Convert.ToInt32 (Console.ReadLine());
             arr = new int[length];
            Console.WriteLine("Enter Elements:");
            for (int i = 0; i < length; i++)
            {
                Console.Write(i + 1 + " element -> ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            Console.Write("ORDER: \n1. Ascending\n2. Descending \nEnter choice: ");
            op = int.Parse(Console.ReadLine());
            GnomeSort s = new GnomeSort();
            switch (op)
            {
                case 1:
                    {

                        arr = s.Ascending(arr);
                        break;
                    }

                case 2:
                    {
                        arr = s.Decending(arr);
                        break;
                    }
                
            }
            //Printing sorted array
            Console.WriteLine("Sorted Array:");
            foreach (int element in arr)
            {
                Console.WriteLine(element);
            }
           
            Console.Write("Press Y to sort again and any key to exit.");
            a=Convert.ToChar( Console.ReadLine());
            if (a=='y'||a=='Y')
            {
                Console.Clear();
                Sort();
            }
           
        }
    }
    class GnomeSort
    {
        public int[] Ascending(int[] arr)
        {
            int pos = 0;

            while (pos < arr.Length)
            {
                //Comparing
                if (pos == 0 || arr[pos - 1] <= arr[pos])
                {
                    pos++;
                }
                else
                {
                    //Swapping
                    int temp = arr[pos];
                    arr[pos] = arr[pos - 1];
                    arr[pos - 1] = temp;
                    pos--;
                }
            }
            //returning sorted array
            return arr;
        }
        public int[] Decending(int[] arr)
        {
            int pos = 0;
            while (pos < arr.Length)
            {
                //Comparing
                if (pos == 0 || arr[pos - 1] >= arr[pos])
                {
                    pos++;
                }
                else
                {
                    //Swapping
                    int temp = arr[pos];
                    arr[pos] = arr[pos - 1];
                    arr[pos - 1] = temp;
                    pos--;
                }
            }
            //returning sorted array
            return arr;
        }
    }
}
