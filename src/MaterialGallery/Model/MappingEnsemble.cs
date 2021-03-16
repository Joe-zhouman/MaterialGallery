using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace Model
{
    public class MappingEnsemble<T> where T :struct
    {
        public double Ub { get; set; }
        public double Lb { get; set; }
        public SortedList<double,T> Val { get; set; }

        public MappingEnsemble(IDictionary<double, T> val) {
            Val =new SortedList<double, T>(val);
            Lb = Val.Keys.First();
            Ub = Val.Keys.Last();
        }
    }
}
