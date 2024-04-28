using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les1
{
    internal class Point
    {

		private int myVar;

		public int MyProperty
		{
			get { return myVar; }
			
		}
		private int myVar1;

		public int MyProperty1
		{
			get { return myVar1; }
			
		}
		private string myVar2;

		public string MyProperty2
		{
			get { return myVar2; }
			
		}
		 public Point(int val1,int val2,string name)
		 {
			myVar = val1;
			myVar1 = val2;
			myVar2 = name;
         }


    }
}
