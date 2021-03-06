﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.ArrayProb
{
    public class Interval
    {
        public int Start { get; set; }
        public int End { get; set; }

        public Interval(int start, int end)
        {
            Start = start;
            End = end;
        }

        public bool IsOverlapped(Interval interval)
        {
            return (Math.Min(this.End, interval.End) >= Math.Max(this.Start, interval.Start));
        }
    }
}
