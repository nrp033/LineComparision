namespace LineComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation");


            int x1, x2, y1, y2;
            Console.WriteLine("Enter the value of x1,y1,x2,y2 cordinates for Line 1 : ");

            x1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            int length1 = Length(x1, y1, x2, y2);

            Console.WriteLine("Enter the value of x1,y1,x2,y2 cordinates for Line 2 : ");

            x1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            int length2 = Length(x1, y1, x2, y2);

            if (length1.Equals(length2) == true)
            {
                Console.WriteLine("Lines are Equal !");

            }
            else
            {
                Console.WriteLine("Lines are Not Equal ");
            }
            
            Console.ReadKey();

        }

        private static int Length(int x1, int y1, int x2, int y2)
        {
            return (int)Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

    }

}