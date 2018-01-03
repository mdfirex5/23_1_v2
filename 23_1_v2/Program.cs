using System;

namespace _23_1_v2
{
    public static class MyFunctions
    {
        public static void Wrate(string i)
        {
            Console.WriteLine("Минимальная слово: {0}\n",i);
        }
    }

    internal class A
    {
        private string str; // компоненты данные
        private int k;
        
        public A()
        {  // конструктор по умолчанию
            this.str = "NULL";
        }

        public A(string s, int i) // конструктор с параметрами;
        {
            k = i;
            this.str = s;
        }

        ~A ()
        {
            Console.WriteLine("{0} обьект класса А уничтожен",k+1);
            Console.ReadKey();
        }

        public A(A a) // конструктор копирования;
        {
            this.str = a.str;
        }

        public string getString()
        {
            return this.str;
        }
    }

    internal class B
    {
        private string str;

        public B()
        {
            this.str = "Null";
        }

        public B(string s)
        {
            this.str = s;
        }

        public string getString() //method
        {
            return this.str;
        }

        public string getMinWord()
        {
            string[] str = this.str.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int maxlen = str.Length, index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length < maxlen)
                {
                    maxlen = str[i].Length;
                    index = i;
                }
            }

            return str[index];
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            A a = new A(input,1);
            A a2 = new A(a);
            //A a3 = new A(a);
            B b = new B(a2.getString());
            MyFunctions.Wrate(b.getMinWord());

        }
    }
  
}