internal partial class Program
{
    static int number(int num, int x)
    {
        int sumcd;

        if(x==1)
                sumcd = 1;
        else if(num%x==0)
                sumcd = x + number(num,x-1);
        else
                sumcd = number(num,x-1);
    
    return sumcd;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap: ");
        int num = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Tong cua uoc: {0}", number(num, num/2));
         if ( number(num, num/2) < num) Console.WriteLine("deficient");
        else if ( number(num, num/2) > num) Console.WriteLine("abundant");
        else Console.WriteLine("perfect");
    }
}