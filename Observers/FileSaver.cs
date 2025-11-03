using System;
using System.IO;

namespace Observers
{
    public class FileSaver : IObserver<AbstractStringSubject>
    {
        private readonly TextWriter sw;

        public FileSaver(string path)
        {
            sw = new StreamWriter(path, true);
        }

        public void Update(AbstractStringSubject sub)
        {
            string keyString = sub.Item;
            
            if (keyString == ConsoleKey.Escape.ToString())
            {
                sw.Close();
            }

            else
            {
                sw.WriteLine(keyString);
            }
        }
    }
}