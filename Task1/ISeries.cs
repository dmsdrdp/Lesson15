using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();
    }

    class ArithProgressin : ISeries
    {
        int step;
        int startValue;
        int currentValue;

        public int GetNext()
        {
            currentValue += step;
            return currentValue;
        }

        public void SetStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }

        public void Reset()
        {
            currentValue = startValue;
        }
        public void setStep(int s)
        {
            step = s;
        }
    }

    class GeomProgression : ISeries
    {
        int step;
        int startValue;
        int currentValue;

        public int GetNext()
        {
            currentValue *= step;
            return currentValue;
        }

        public void SetStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }

        public void Reset()
        {
            currentValue = startValue;
        }
        public void setStep(int s)
        {
            step = s;
        }
    }


}
