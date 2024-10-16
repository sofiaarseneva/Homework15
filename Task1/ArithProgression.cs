using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class ArithProgression : ISeries
    {
        //шаг прогрессии
        int step;
        //начальное значение
        int startValue;
        //текущее значение
        int currentValue;

        public int StartValue { get; set; }
        public int Step
        {
            get
            {
                return step;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Значение шага прогрессии не может быть отрицательным!");
                }
                else
                {
                    step = value;
                }
            }
        }

        public ArithProgression(int step, int startValue)
        {
            Step = step;
            StartValue = startValue;
        }

        public int GetNext()
        {
            currentValue += step;
            return currentValue;
        }

        public void Reset()
        {
            currentValue = startValue;
        }

        public void SetStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
    }
}
