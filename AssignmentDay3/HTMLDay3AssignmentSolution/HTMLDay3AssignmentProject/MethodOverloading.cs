namespace HTMLDay3AssignmentProject
{
    internal class MethodOverloading
    {
        public static void Method()
        {
            Console.WriteLine("Method With no Parameters");
        }
        public static void Method(int num)
        {
            int fact =1;
            for(int i = num; i > 0; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("Method With one Parameters gives factorial of num " + num + " = " + fact);

        }
        public static void Method(int num1 , int num2)
        {
            int sum;
            sum = num1 + num2;
            Console.WriteLine("Method With Two Parameters gives sum of two numbers "+ num1 +" And " + num2 +" = " + sum);
        }
    }
}
