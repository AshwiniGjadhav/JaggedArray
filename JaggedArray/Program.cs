using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[][] jaddearray=new int[3][];

            jaddearray[0] = new int[] {2,4,5,6};
            jaddearray[1] = new int[] {2,4,5};
            jaddearray[2] = new int[] {2,4};

            for(int i = 0; i < jaddearray.Length; i++)
            {
                for(int j = 0; j < jaddearray[i].Length; j++)
                {
                    Console.Write(jaddearray[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
