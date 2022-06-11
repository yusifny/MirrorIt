using System;
using static System.Console;
namespace MirrorIt
{
    class Program
    {
        static void Main(string[] args)
        {
            string item = ReadLine();
            WriteLine(MirrorIt(item));
        }
        
        static string MirrorIt(string item)
        {
            string candidate = "";
            string mirroredOne = "";
            for (int i = item.Length - 1; i >= 0; i--)
            {
                candidate += item[i];
                mirroredOne = candidate;
            }
            return mirroredOne;
        }
    }
}
