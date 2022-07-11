using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLDay3AssignmentProject
{
    public interface IAdd
    {
        int Add(int num1, int num2);
    }
    public interface IMultiply
    {
        float Multiply(float num1, float num2);
    }
    internal class Question8 : IAdd, IMultiply
    {
        int result1;
        float result2;
        public int Add(int a, int b)
        {
            result1 = a + b;
            Console.WriteLine("sum of two num " + a +" & "+ b + " = " + result1);
            return result1;
        }
        public float Multiply(float num1, float num2)
        {
            result2 = num1 * num2;
            Console.WriteLine("Product of two num "+ num1 +" & "+ num2 + " = " + result2);
            return result2;
        }
    }
}
