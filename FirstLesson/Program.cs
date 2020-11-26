using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Operators
            #region 1 = Primary
            ////операторы
            //// ++, new, typeof
            //Int16 x = new Int16();
            //Console.WriteLine(x++);
            //Console.WriteLine(typeof(Int16));
            //Console.WriteLine(typeof(object));
            //Console.WriteLine(typeof(string));

            ////checked/unchecked
            //byte y = 250;
            ////y += 10;
            ////y = checked((byte)(y + 10));
            //checked
            //{
            //    unchecked
            //    {
            //        int y1 = 2 + 2;
            //        Console.WriteLine(y1);
            //    }
            //}
            //Console.WriteLine(y);

            ////default - с параметром, а можем и без
            //byte x1 = default(int);
            //Console.WriteLine(x1);

            ////nameof
            //Console.WriteLine(nameof(Int16));
            //Console.WriteLine(nameof(Console));
            //Console.WriteLine(nameof(Main));

            ////sizeof
            //Console.WriteLine(sizeof(Int16));
            //Console.WriteLine(sizeof(byte));
            //Console.WriteLine(sizeof(bool));
            ////Для string не получится, потому что string - ссылочный тип

            ////stackalloc - выделяет память на стеке
            ////->
            ////Vector *vector = new Vector();//если делаем указатель на вектор, то доступ к его методам через "->"
            ////vector->length();
            ////Vector vector1 = new Vector();//без указателя - через точку
            ////vector1.length();
            #endregion

            //Итого, primary операторы = выполняются в первую очередь:
            //x.y
            //x?.y
            //a[i]
            //a?[i]
            //f(x)
            //x++
            //x--
            //new, typeof, checked/unchecked, default, nameof, sizeof, delegate, stackalloc, ->

            //Приоритет номер 2
            //Unary operators = унарные операторы
            //+x
            //-x
            //!x
            //~x
            //++x
            //--x
            //^x
            //(T)x
            //await
            //&x
            //*x
            //true
            //false

            #region 2nd
            ////haha))
            //int x = 10;
            ////x = x++ + 10;
            ////x = x +++ 10;
            ////x = x++ + ++x;
            //x = x+++ ++x;
            //Console.WriteLine(x);

            //bool x1 = false;
            //x1 = !!!!!!!!!x1; //так делать не надо))
            //Console.WriteLine(x1);

            ////~ заменяет все 0 на 1, а 1 на 0 в двоичном представлении
            //byte x2 = 0b00011110; //30;
            //Console.WriteLine(x2);
            //var y2 = (byte)~x2;
            //Console.WriteLine(y2);

            //////только с C# 8.0
            ////int[] mas = { 0, 1, 2, 3, 4, 5 };
            ////Console.WriteLine(mas[^1]);

            ////true,false - переопределение
            //Vector vector = new Vector();
            //if(vector)
            //    Console.WriteLine("Yes!");

            #endregion

            //3 = Range Operator: x..y for C# 8 or greater - Для задания интервала
            //x..y

            //4 = Multiplicative operators
            //x * y
            //x / y
            //x % y

            //5 = Additive operators
            //x + y
            //x - y

            //6 = Shift operator
            //x >> y
            //x << y
            #region 6
            //int x = 12;
            //x >>= 1;
            //Console.WriteLine(x);
            #endregion

            //7 = Relational operators, перегружать - только парами!
            //x > y
            //x < y
            //x >= y
            //x <= y
            //is, as: is - проверка в Runtime что является экземпляром, as - безопасное приведение типов

            //8 = Equality operators
            //x == y
            //x != y

            //9,10,11 = Boolean logical/bitwise operators
            //x & y
            //x ^ y
            //x | y

            //12,13 Conditional operators
            //x && y
            //x || y

            //14 = Null-coalescing operator
            //x ?? y

            //15 = Conditional operator, t и f - должны быть одного типа
            //c ? t : f

            //16 = Assignment operators
            //все опраторы с присваиванием: x=y, x+=y, x*=y, x|=y...
            //16 = Lambda declaration operator
            //=>

            #endregion

            #region Methods

            //локальные функции = функции внутри метода (функция и метод - одно и то же по сути в C#)
            static bool isPalindrome(string text)
            {
                return check(0, text.Length - 1);
                bool check(int lo, int hi)
                {
                    if (lo >= hi) return true;
                    if (text[lo] != text[hi]) return false;
                    return check(lo + 1, hi - 1);
                }
            }
            Console.WriteLine(isPalindrome("bazar"));
            Console.WriteLine(isPalindrome("bazab"));
            Console.WriteLine();

            string text = "ABBA";
            Console.WriteLine(text.IsPalindrome());

            //перегрузка методов
            string alfa = "alfa";
            string beta = "beta";
            Swap<string>(ref alfa, ref beta);
            Console.WriteLine(alfa);
            Console.WriteLine(beta);


            Vector a = new Vector(5, 10);
            Vector b = new Vector(20, 10);
            var c = a + b;
            var p = a * b;
            var m = 5 * a;
            var m2 = a * 10;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(p);
            Console.WriteLine(m);
            Console.WriteLine(m2);
            Console.WriteLine(-a);
            Console.WriteLine(!a);
            Console.WriteLine();

            Vector f = new Vector(1, 1);
            Vector d = new Vector(2, 2);
            Vector e = new Vector(1, 1);
            Console.WriteLine(f==e);
            Console.WriteLine(f==d);


            #endregion

            Console.ReadKey();
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        #region PrimaryDop
        //оператор new
        //позволяет написать строку ниже: чтобы объект имел публичный конструктор без параметров
        static void Foo<T>() where T: new()
        {
            T someObject = new T();
        }

        //default
        static T Foo2<T>()
        {
            return default;
        }
        #endregion

        

    }
}
