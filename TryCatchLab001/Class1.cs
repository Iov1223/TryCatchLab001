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

        public int readNames(string _path)
        {
            string _buffer = "";
            try
            {
                StreamReader myStreamReader = new StreamReader(_path);              
                do
                {
                    _buffer = myStreamReader.ReadLine();
                    Names.Add(_buffer);
                    if (Names == null)
                    {
                        return 0;
                    }
                    Console.WriteLine(_buffer);
                } while (_buffer != null);
            }
            catch (Exception ex001)
            {

                Console.WriteLine(ex001.Message);
            }
            return Names.Count;
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
        }

    }
}
