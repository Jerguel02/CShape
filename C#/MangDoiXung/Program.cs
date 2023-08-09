internal class Program
{
    static bool doixung(int[,] arr,int m)
    {

    for(int i=0;i<m;i++)
    {
        
        for(int j=i+1;j<m;j++)
        {
            if(arr[i,j] != arr[j,i]) return false; 
        }    
    }

     return true;
    }
   
    private static void Main(string[] args)
    {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
    
    Console.WriteLine("Nhap ma tran vuong: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] Arr = new int[n,n];
    for(int i=0;i<Arr.GetLength(0);i++)
    {
        for(int j=0;j<Arr.GetLength(1);j++)
        {
         Console.Write("Arr[{0},{1}] = ",i,j);
         Arr[i,j] = Convert.ToInt32(Console.ReadLine());
        }
    }
     for(int i=0;i<Arr.GetLength(0);i++)
    {
        for(int j=0;j<Arr.GetLength(1);j++)
        {
         Console.Write("{0} ",Arr[i,j]);   
        }
        Console.WriteLine();
    }
    Console.WriteLine(doixung(Arr, n));
}
}