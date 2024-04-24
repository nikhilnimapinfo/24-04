using System;
namespace ExtensionMethod
{
    public static class Person 
    {
        public static void m3(this Student s)
        {
            Console.WriteLine("System");
        }
        public static void m4(this Student s1)
        {
            Console.WriteLine("Bolo");
        }
    }
}
