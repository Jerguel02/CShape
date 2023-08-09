internal class Program
{
    static int fibonacci(int n)
    {
        if (n == 0 || n ==1) return n;
        else return (fibonacci(n-1) + fibonacci(n-2));
    } 
    static int fibonacci(int n)
    {
        int f0 = 0, f1 = 1, fn = 1;
        if (n==0 || n == 1) return n;
        else 
        {
            for (int i = 2; i < n; i++)
            {
            f0 = f1;
            f1 = fn;
            fn = f0 + f1;
            }
        }
        return fn;

    } 
    private static void Main(string[] args)
    {
       Console.WriteLine("Nhap: ");
        int max = Convert.ToInt32(Console.ReadLine());
        //int max = System.Int32.Parse((Console.ReadLine());
       
      

        for (int i=0; i<max; i++)
        {
            Console.Write("{0} ", fibonacci(i));
        }
    }
}