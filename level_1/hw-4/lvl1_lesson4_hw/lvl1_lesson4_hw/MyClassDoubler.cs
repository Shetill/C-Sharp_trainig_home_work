using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1_lesson4_HW
{
    class MyClassDoubler
    {
        int current; //текущее значение
        public int finish; //число которого нужно достичь

        public int Current { get => current; set => current = value; }

        public MyClassDoubler(int a)
        {
            this.finish = a;
        }

        //Конструктор по умолчанию
        public MyClassDoubler()
        {
        }

        public int GetUpOne()
        {
            return this.Current++;
        }
        public int GetMultiTwo()
        {
            return this.Current = this.Current * 2;
        }
        public int GetBreakToOne()
        {
            return this.Current = 1;
        }
    }
}
