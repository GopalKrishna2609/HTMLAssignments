namespace HTMLDay3AssignmentProject
{
    internal class LargestValue
    {

        public static void Largest()
        {
            int a = 325, b = 750, c = 478;
            if (a > b && a > c)
            {
                Console.WriteLine(a + " is Largest");
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine(b + " is Largest");
                }
                else
                {
                    Console.WriteLine(c + " is Largest");
                }
            }
        }
    }
}
