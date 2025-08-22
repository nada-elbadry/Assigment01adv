using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment01adv
{
    internal class Range<T> where T : IComparable<T>
    {
        private T Min;
        private T Max;

        public Range(T min, T max)
        {
            Min = min;
            Max = max;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public double Length()
        {
           
            dynamic min = Min;
            dynamic max = Max;
            return (double)(max - min);
        }
    }
}
