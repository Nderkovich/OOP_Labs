using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class LichKing
    {
        private static LichKing instance;
        private static readonly object _lock = new object();

        private LichKing()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Frostmorne hungers");
            Console.ResetColor();
        }

        public static LichKing GetInstance()
        {
            if (LichKing.instance == null)
            {
                lock (_lock)
                {
                   instance = new LichKing();
                }
            }
            return LichKing.instance;
        }
    }
}
