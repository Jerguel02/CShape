using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so dong cua ma tran: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Nhap so cot cua ma tran: ");
        int m = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, m];

        Console.WriteLine("Nhap cac phan tu cua ma tran: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Kiểm tra hàng giống nhau
        bool isDuplicateRowExists = false;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                bool isSame = true;
                for (int k = 0; k < m; k++)
                {
                    if (matrix[i, k] != matrix[j, k])
                    {
                        isSame = false;
                        break;
                    }
                }
                if (isSame)
                {
                    isDuplicateRowExists = true;
                    Console.WriteLine($"Hai hang {i+1} va {j+1} giong nhau");
                }
            }
        }

        if (!isDuplicateRowExists)
        {
            Console.WriteLine("Khong co hai hang nao giong nhau");
        }
        
        Console.ReadLine();
    }
}
