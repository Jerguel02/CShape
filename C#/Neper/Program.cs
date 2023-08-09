
internal class Program
{
    static float gt(float m)
    {
        float gthua;
        if (m == 0) gthua = 1;
        else  gthua = m*gt(m-1);
        return gthua;
    }
    static float Neper(float n)
    {
        float kq;
        if (n == 0) kq = 1;
        else 
        kq = Neper(n-1)+(1/gt(n));
        return kq;       
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap: ");
        int max = Convert.ToInt32(Console.ReadLine());
   
            Console.WriteLine("Neper({0}) = {1}",max, Neper(max));

      
    }
}