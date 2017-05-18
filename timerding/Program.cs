using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace timerding
{
    class Program
    {
        static Timer tmr = new Timer();
        static int row = 1;
        static int col = 10;

        static void Main(string[] args)
        {
            tmr.Interval = 50;
            tmr.Elapsed += Tmr_Elapsed;
            tmr.Start();           
            Console.ReadKey(false);

        }

        private static void Tmr_Elapsed(object sender, ElapsedEventArgs e)
        {
            row++;
            Console.Clear();
            Console.SetCursorPosition(row, col);
            Console.Write("HEY");            

        }
    }
}
