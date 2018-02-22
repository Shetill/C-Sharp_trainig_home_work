using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1_Lesson1
{
    class PrintPause
    {
        public string Msg;

        static public void Print(string msg)
        {

            Console.WriteLine(msg);
        }

        static public void Pause()
        {
            Console.ReadKey();
        }

    }
}
