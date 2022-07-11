namespace HTMLDay3AssignmentProject
{
    public class BoxingAndUnboxing
    {
        static int i = 12345;
       static object obj = i; //Boxing int i
        static int j = (int)obj;
        public static void PrintFunction()
        {
            Console.WriteLine("Boxed Value " + obj);
            Console.WriteLine("Unboxed Value " + j);
        }
    }
}
