using org.mariuszgromada.math.mxparser;
using System;

namespace ConsoleMathParser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Expression basic
            Expression e = new Expression("2+(3-5)^2");
            var result=e.calculate();
            Console.WriteLine("Resultado: "+ result);

        }
    }
}
