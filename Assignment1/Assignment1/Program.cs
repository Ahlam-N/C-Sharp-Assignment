// Program to count the number of 1's
namespace assignments
{
    public class numberofones
    {
        public static void Main(String[] args)
        {
            int m;
            int count = 0;
            Console.WriteLine("Enter the limit: ");
            m = int.Parse(Console.ReadLine());
            int[] a = new int[m];
            Console.WriteLine("Enter the numbers: ");
            for (int i = 0; i < m; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int o in a)
            {
                if (o == 1)
                {
                    count++;
                }
            }
            Console.WriteLine("The number of 1's in the Entered Number : ");
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}