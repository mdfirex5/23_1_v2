﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _23_1_v2
{
    public static class MyFunctions
    {
        
        public static void Wrate(string i)
        {

            Console.WriteLine(i);
        }
    }
    class A
    {
        private string str; // компоненты данные

        public A () {  // конструктор по умолчанию
            this.str = "NULL";
            
        }

        public A(string s) // конструктор с параметрами;
        {
            this.str = s;
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

    class B
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
            int maxlen = 0, index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxlen)
                {
                    maxlen = str[i].Length;
                    index = i;
                }
            }
           
            return str[index];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            A a = new A(input);
            A a2 = new A(a);
            B b = new B(a2.getString());
            MyFunctions.Wrate(b.getMinWord());
            Console.ReadLine();
        }
    }
}


