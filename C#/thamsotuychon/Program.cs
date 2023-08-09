internal partial class Program
{
    //private chi duoc truy xuat trong noi bo class
    //public duoc phep giao tiep ra ben ngoai
    //private static chia se cung chung noi bo
    //public static chia se ra ben ngoai, dung chung cho tat ca cac doi tuong
    static int tong(int x, int y = 5, int z = 7)
    {
        int kq = x+y+z;
        return kq;
    }
    private static void Main(string[] args)
    {
        //int kq = tong(1,2,3);
        //int kq = tong(1,2);
        //int kq = tong(1);
        //int kq = tong(1, z: 3);
        int kq = tong(x: 1, z: 3);

        Console.WriteLine(kq);
    }
}