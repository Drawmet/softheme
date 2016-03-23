using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Softheme1
{
    class Program
    {
        static void Main(string[] args)
        {
            int leng = 0;
            int maxleng = 0;
            string message = "";
            string path = @"d:\documents\Work\softheme\Softheme1\Softheme1\Input.txt";
            string pathw = @"d:\documents\Work\softheme\Softheme1\Softheme1\Output.txt";
            string readText = File.ReadAllText(path);
            foreach(char k in readText)
            {
                if (k == '1')
                {
                    leng++;
                }
                else if (k=='0')
                {
                    if (maxleng < leng)
                        maxleng = leng;
                    leng = 0;
                }
            }
            for (int k = 0; k <= maxleng; k++)
            {
                message = message + "1";
            }
            File.WriteAllText(pathw, message);
        }
    }
}
