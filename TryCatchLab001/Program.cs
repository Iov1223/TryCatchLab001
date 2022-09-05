using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TryCatchLab001
{
    class Authorization
    {
        private List<string> Names = new List<string>();
        private string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Dwarfs.txt";

        public List<string> readNames()
        {
            string _buffer = "";
            try
            {
                StreamReader myStreamReader = new StreamReader(_path);
                do
                {
                    _buffer = myStreamReader.ReadLine();
                    Names.Add(_buffer);
                } while (_buffer != null);
            }
            catch (Exception ex001)
            {
                Console.WriteLine(ex001.Message);
                return null;
            }
            return Names;
        }
        private void ShowList()
        {
            for (int i = 0; i < Names.Count; i++)
            {
                Console.WriteLine(Names[i]);
            }
        }

        public void FindeName(string name)
        {
            if (Names.Contains(name))
            {

                Console.WriteLine("Имя {0} ЕСТЬ в списке.", name);
            }
            else
            {
                Console.WriteLine("Имя {0} ОТСУТСТВУЕТ в списке.", name);
            }
            Console.WriteLine();
            ShowList();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Authorization myAuthorization = new Authorization();
            if (myAuthorization.readNames() == null)
            {
                return;
            }
            else
            {
                try
                {
                    myAuthorization.FindeName(args[0]);
                }
                catch
                {
                    Console.Write("Введите имя: ");
                    myAuthorization.FindeName(Console.ReadLine());
                }
            }
        }
    }
}
