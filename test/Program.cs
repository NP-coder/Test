﻿using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //B obj1 = new A();
            //obj1.Foo();

            B obj2 = new B();
            obj2.Foo();

            A obj3 = new B();
            obj3.Foo();

        }
        class A
        {
            public virtual void Foo()
            {
                Console.Write("Class A!");
            }
        }
        class B : A
        {
            public override void Foo()
            {
                Console.Write("Class B!");
            }
        }
        class C
        {
          int age{get;set};
          string name{get;set};

          public void person()
          {
            age=this.age;
            name=this.name;
            Console.Write("hello");
            Console.Write($"{name}, {age}");
          }
        }

    }
}
