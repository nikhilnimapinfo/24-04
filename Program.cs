using System;
namespace Nullable_Type_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime? date= null;
            Console.WriteLine("GetValueOrDefault ()"+date.GetValueOrDefault());
            Console.WriteLine("HashValue"+date.HasValue);
           // Console.WriteLine("Value"+date.Value); 
           // it's gives a Exception error

            DateTime? date2 = new DateTime(2014, 01, 01);
            var date3 = date2.GetValueOrDefault();
            Console.WriteLine(date3);
        }
    }
}
