using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Maths
    {

        public int X { get; set; }
        public int Y { get; set; }



        public static int Add(int x , int y) {
        return x + y;
        }
        public static int Sub(int x , int y) {
            return x - y;
        }
        public static int Mul(int x , int y) {
            return x * y;
        }
        public static int Div(int x , int y) {
            return  y==0?0 :  x / y;
        }
    }
}
