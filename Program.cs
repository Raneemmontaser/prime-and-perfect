namespace Perfect_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" please enter the first number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the second number");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("perfect numbers between {0} and {1} are:", n1,n2);
            int i = n1; bool z = Isperfectnum(i);
            for (i = n1 + 1; i < n2; i++)
            {

                if (Isperfectnum(i))
                {
                    Console.WriteLine(i);
                }


            }
        }
        static bool Isperfectnum(int n)
        {

            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    sum += i;


            }
            if (sum == n && n != 0)
                return true;
            else
            {
                return false;
            }

       
        }
    }
}