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
            //Console.WriteLine("Resultado: "+ result);



            //Triangle area
            Function At = new Function("At(b,h) = 1/2 * b * h");
            Expression e1 = new Expression("At(2,4)", At);
            Console.WriteLine("Expression: " + e1.getExpressionString() + "" + e1.calculate());
            Argument arg1 = new Argument("b=3");
            Argument arg2 = new Argument("h=10");
            Expression e2 = new Expression("At(b,h)", At, arg1, arg2);
            Console.WriteLine("Expression: " + e2.getExpressionString() + "" + e2.calculate());
        }
    }
}
