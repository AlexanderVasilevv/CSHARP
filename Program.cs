using System;
using System.Drawing;
using System.Linq;



namespace TU_Varna
{
    class Program
    {
        static void Main(string[] args)
        {
             int n = int.Parse(Console.ReadLine());
            int m = 3;
            var sum = 0;
           byte count = 0;
            int[,] arr = new int[n, m];
            string[] lines = new string[n];
            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }


            for (int i = 0; i < n; i++)
            {
                string[] num = lines[i].Split(' ');
                for (int j = 0; j < m; j++)
                {
                    int z = Convert.ToInt32(num[j]);
                    arr[i, j] = z;
                    
                }
            }
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] != n )
                    {
                        count++;
                    }
                        sum += arr[i, j];
                    
                }
            }
            if (sum > arr[0, 2])
            {
                Console.WriteLine(count);
                Console.WriteLine(sum);
                
            }
       
            
           
            
        }
    }
}

