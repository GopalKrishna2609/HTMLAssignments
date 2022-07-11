namespace HTMLDay3AssignmentProject
{
    public class CountEvenAndOddNumbers
    {
        public static void Count()
        {
            int even = 0, odd = 0;
            List<int> num = new List<int>();
            num.Add(50);
            num.Add(65);
            num.Add(56);
            num.Add(71);
            num.Add(81);


            foreach (int i in num)
            {
                if (i % 2 == 0)
                {
                    even++;
                }
                else if (i % 2 == 1)
                    odd++;
            }
            Console.WriteLine("There are " + even + "even numbers");
            Console.WriteLine("There are " + odd + "odd numbers");

        }
    }
}
