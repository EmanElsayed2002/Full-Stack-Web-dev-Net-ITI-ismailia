﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
	class Geoshape
	{
		protected double dim1;
		protected double dim2;

		public void SetDim1(double _dim1) { dim1 = _dim1; }
		public void SetDim2(double _dim2) { dim2 = _dim2; }
		public double GetDim1() { return dim1; }
		public double GetDim2() { return dim2; }

		public Geoshape()
		{
			dim1 = dim2 = 0;
			Console.WriteLine("Geo def ctor");
		}
		public Geoshape(double _dim1, double _dim2)
		{
			dim1 = _dim1;
			dim2 = _dim2;
			Console.WriteLine("geo 2p ctor");
		}
		public Geoshape(double _dim)
		{
			dim1 = dim2 = _dim;
			Console.WriteLine("Geo 1p ctor");
		}
	}
	///////////////////////////////////
	class Rectangle : Geoshape
	{
		
		public Rectangle()
		{
			Console.WriteLine("rect def ctor");
		}
		public Rectangle(double _d1, double _d2) : base(_d1, _d2)
		{
			
			Console.WriteLine("Rect 2p ctor");
		}
		public double CArea()
		{
			return dim1 * dim2;
		}
	}
	/////////////////////////////////////////////////
	class Square : Geoshape
	{
		public Square()
		{

		}
		public Square(double _dim) : base(_dim)
		{

		}

		public double CArea()
		{
			return dim1 * dim2;
		}
		//
		public void SetDim1(double _dim1) { dim1 = dim2 = _dim1; }
		public void SetDim2(double _dim2) { dim1 = dim2 = _dim2; }
		//
	}
	/////////////////////////////////////////////
	class SquareV2 : Rectangle
	{
		public SquareV2()
		{

		}
		public SquareV2(double _dim) : base(_dim, _dim)
		{

		}
	}
	///////////////////////////////////////////
	class Circle : Geoshape
	{
		public Circle()
		{

		}
		public Circle(double _radius) : base(_radius)
		{

		}
		public double CArea()
		{
			return Math.PI * dim1 * dim2;
		}
	}
	///////////////////////////////////////////////
	class Triangle : Geoshape
	{
		public Triangle()
		{

		}
		public Triangle(double _base, double _height) : base(_height, _base)
		{

		}
		public double CArea()
		{
			return 0.5 * dim1 * dim2;
		}
	}
}