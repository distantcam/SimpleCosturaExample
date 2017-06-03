using System;

namespace LibB
{
    public static class B
    {
        public static void Foo()
        {
            Console.WriteLine("B");
            LibC.C.Foo();
        }
    }
}