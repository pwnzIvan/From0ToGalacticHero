using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLesson
{
    public class Vector
    {
        //public static bool operator true(Vector vector)
        //{
        //    return true;
        //}
        //public static bool operator false(Vector vector)
        //{
        //    return false;
        //}

        readonly double x, y;

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector operator + (Vector a, Vector b) => new Vector(a.x + b.x, a.y + b.y);

        public static double operator *(Vector a, Vector b) => a.x * b.x + a.y * b.y;

        public static Vector operator *(double n, Vector a) => new Vector(a.x * n, a.y * n);

        public static Vector operator *(Vector a, double n) => n * a;

        public override string ToString() => $"[{x},{y}]";

        public static Vector operator -(Vector a) => -1 * a;

        //вычисление длины сделаем через оператор "!"
        public static double operator !(Vector a) => Math.Sqrt(a.x * a.x + a.y * a.y);

        public static bool operator ==(Vector a, Vector b) => (a.x == b.x && a.y == b.y);

        public static bool operator !=(Vector a, Vector b) => !(a == b);
    }
}
