using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLDay3AssignmentProject
{
    public interface IFact
    {
        int Fact(int num1);
    }
    public interface IMultiply
    {
        float Multiply(float num1, float num2);
    }
    internal class Question8 : IFact, IMultiply
    {
        int result1;
        float result2;
        public int Fact(int a)
        {
            int fact = 1;
            for(int i = a ; i > 0; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of num " + a + " = " + fact);
            return fact;
        }
        public float Multiply(float num1, float num2)
        {
            result2 = num1 * num2;
            Console.WriteLine("Product of two num "+ num1 +" & "+ num2 + " = " + result2);
            return result2;
        }
    }
}
