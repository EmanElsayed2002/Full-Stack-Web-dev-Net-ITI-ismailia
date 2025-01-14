﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal abstract class GeoShape
    {
        protected double dim1;
        protected double dim2;

        public void SetDim1(double _dim1) { dim1 = _dim1; }
        public void SetDim2(double _dim2) { dim2 = _dim2; }
        public double GetDim1() { return dim1; }
        public double GetDim2() { return dim2; }

        public GeoShape()
        {
        }
        public GeoShape(double _dim1, double _dim2)
        {
            dim1 = _dim1;
            dim2 = _dim2;
        }
        public GeoShape(double _dim)
        {
            dim1 = dim2 = _dim;
        }

        public abstract double Area();
    }
}
