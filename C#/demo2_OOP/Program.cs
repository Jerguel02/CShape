internal class Program
{
    //static void test(int so1) //truyen tham tri
    static void test(ref int so1)
    {
        so1 += 1;

    }
 
    private static void Main(string[] args)
    {
        int a =5;
        test(ref a); //truyen tham chieu
        Console.WriteLine(a);
    }
}