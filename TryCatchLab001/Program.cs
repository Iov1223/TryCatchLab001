using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchLab001
{
    class Program
    {
        static void Main(string[] args)
        {
            Authorization myAuthorization = new Authorization();
            string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            _path += "\\Dwarfs.txt";
            int count = myAuthorization.readNames(_path); 
            count -= 1;
            Console.WriteLine("В файле {0} {1} строк", _path, count);
            myAuthorization.FindeName(args[0]);

        }
    }
}
