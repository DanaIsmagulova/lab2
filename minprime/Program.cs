using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace files
{
    class Program
    {
        static bool is_Prime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
                if ((i == n) || (i > Math.Sqrt(n)))
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            string line;
            int minn;
       
            StreamReader lines = new StreamReader(@"C:\Users\Admin\Downloads\myc#texts\my.txt");
            using (StreamWriter output = new StreamWriter(@"output.txt"))
            {
                int curr_n = int.Parse(lines.ReadLine());
                minn = curr_n;
                
                string t_line;
                while ((t_line = lines.ReadLine()) != null)
                {
                    curr_n = int.Parse(t_line);
                   
                    if (is_Prime(curr_n) && minn > curr_n)
                    {
                        minn = curr_n;
                    }
                }
                output.WriteLine( minn);

                
            }
            Console.ReadKey();
        }
    }
}
