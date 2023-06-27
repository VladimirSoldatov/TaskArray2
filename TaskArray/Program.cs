using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskArray
{
    internal class Program
    {
        interface getX
        {
            void getX();
            
        }
        struct MyStruct:getX
        {
            public MyStruct(int _x, int _y)
            {
                x=_x; y = _y;
            }
            public int x;
            public int y;

            public void getX()
            {
                Console.WriteLine(x);
            }
        }
        static void Main(string[] args)
        {
            MyStruct s = new MyStruct();
            s.getX();

          /* int[]arr = new int[] {0,0,0,0,1,1,1,1,1,0}; 
            Random random = new Random();   
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0,2);
            }
          
            Array.ForEach(arr, s=>Console.Write($"{s}\t"));
            Console.WriteLine();
            int start = 0;
            int end = arr.Length - 1;
            int count = 0;
            while(start<=end)
            {
                if (arr[start]!=0)
                {
                    start++;
                }
                else
                    if (arr[end]!=0)
                {
                    arr[start] = arr[end];
                    arr[end] = -1;
                    start++;
                    end--;

                }
                else
                {
                    arr[end] = -1;
                    end--;
                }
                Array.ForEach(arr, s => Console.Write($"{s}\t"));
                Console.WriteLine();
                count++;
            }
            Console.WriteLine(count);
            */
        }
    }
}
