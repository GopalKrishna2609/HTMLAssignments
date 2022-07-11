namespace HTMLDay3AssignmentProject
{
    public class OverloadedConstructor
    {
        public  OverloadedConstructor()
        {
            Console.WriteLine("1st Cunstructor With no Parameters");
        }
        public  OverloadedConstructor(int num)
        {
            int fact = 1;
            for (int i = num; i > 0; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("2nd Cunstructor With one Parameters gives factorial of num " + num + " = " + fact);
        }
        public OverloadedConstructor(int num1, int num2)
        {
            int sum;
            sum = num1 + num2;
            Console.WriteLine("3rd Cunstructor With Two Parameters gives sum of two numbers " + num1 + " And " + num2 + " = " + sum);
        }

        
    }
}
