namespace HTMLDay3AssignmentProject
{
    internal class AllOddNumbersBetween
    {
        public static void Oddnumbers()
        {
            for(int i = 0; i < 10; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }
        }
    }
}
