using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    interface ISeries
    {
        //устанавливает начальное значение
        void SetStart(int x);
        //возвращает следующее число ряда
        int GetNext();
        //выполняет сброс к начальному значению
        void Reset();
    }
}
