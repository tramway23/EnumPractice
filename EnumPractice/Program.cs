using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Myfile file1= new Myfile("onepiece.txt", 
                "C:\\users\\Zakaria", 
                Rights.READABLE,null);

            //is file1 readable?

            Console.WriteLine( (int) file1.FileRights);


        }
    }
}
