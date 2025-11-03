using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Observers
{
    public class KeyReader : AbstractStringSubject
    {
        public void ReadKeys()
        {
            ConsoleKey key;
            do
            {
                key = Console.ReadKey().Key;
                Item = key.ToString();
            } while (key != ConsoleKey.Escape);
        }
    }
}