internal class Program
{
    static int pas(int hang, int cot)
    {
        if (cot == 0 || hang == cot) return 1;
        return pas(hang-1, cot-1) + pas(hang-1, cot);
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap so hang: ");
        int sohang = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i<sohang+1; i++)
        {
            Console.Write("n = {0}: ", i);
            for (int j=0; j<i+1; j++)
            {
                Console.Write("{0} ", pas(i,j));
            }
            Console.WriteLine();
        }
    }
}