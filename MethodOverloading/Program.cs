namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {

            int addInts = Add(5, 5);
            Console.WriteLine(addInts);

            decimal addDecimal = Add(9.8m, 5.9m);
            Console.WriteLine(addDecimal);
            
            string addedWithBool = Add(8, 9, true);
            Console.WriteLine(addedWithBool);
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool addMoney)
        {
            if (addMoney == true)
            {
                int total = x + y;

                if (total == 1)
                {
                    return $"{total} dollar";
                }

                else
                {
                    return $"{total} dollars";
                }
            }
            else
            {
                return "Try Again";
            }
        }
    }
}
