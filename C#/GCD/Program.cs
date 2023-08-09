internal class Program
{   
    // static int GCD(int n1, int n2)
    // {
    // if (n2 == 0) return n1;
    // return GCD(n2, n1%n2);
    // } 
    // static int GCD(int n1, int n2)
    // {
    // int tmp;
    // while(n2 != 0) {
    //     tmp = n1 % n2;
    //     n1 = n2;
    //     n2 = tmp;
    // }
    // return n1;
    // }
    //static int GCD(int n1, int n2) => (n1 == 0) ? n2 : GCD(n2 % n1, n1);
    static int GCD(int n1, int n2)
    {
        while (n1^=n2^=n1^=n2%=n1)
        return n2;
    }
    private static void Main(string[] args)
    {
       Console.WriteLine("Nhap 2 so:");
       int num1 = Convert.ToInt32(Console.ReadLine());
       int num2 = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine(GCD(num1,num2));
    }
}