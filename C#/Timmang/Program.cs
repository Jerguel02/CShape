internal class Program
{
    static int BinSearch(int[] a, int x)
    {
        int k = 0;
        int kq;
        int i = 0;
        int j = a.GetUpperBound(0);
        bool found = false;
        while ((i<=j)&& (!found))
        {
            k = (i+j)/2;
            if (x < a[k])
                 j = k-1;
            else if (x==a[k])
                found = true;
            else i = k+1;
        }
        if (found)
        kq = k;
        else kq = -1;
        return kq;

        }

    
 /*   static int SeqSearch(int[]
    {
        int kq;
        
        bool found = false;
        int i = 0;
        while ((i < Array.Length) && (! found))
        if (Array[i] == searchKey)
        found = true;
        else
        i++;
        if (found)
        kq = i;
        else 
        kq = -1;
        return kq;
    } */
    private static void Main(string[] args)
    {
        while (true)
        {
        int[] Arr = {5,10,15,20,22};
        Console.WriteLine("Nhap so can tim: ");
        int find = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("So can tim o vi tri so {0}", BinSearch(Arr,find));
        }
    }
}