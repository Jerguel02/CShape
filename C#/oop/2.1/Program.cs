using System;
using System.Collections.Generic;
using System.Text;
namespace TinhLap
{
 class Program
 {

 //₫ịnh nghĩa hằng gợi nhớ miêu tả sai số mong muốn
 const double EPSILON = 0.0000001;
 //₫ịnh nghĩa hàm tính n!
 static long giaithua(int n)
 {
 if (n <= 1) return 1;
 return n*giaithua(n-1);
 }
 //₫ịnh nghĩa hàm tính thành phần x^n/n!
 static double EnS1(double x, int n)
 {
 return (Math.Pow(x,n))/giaithua(n);
 }
 //₫ịnh nghĩa hàm tính công thức S1(x)
 static double S1(double x)
 {
 //1. Lúc ₫ầu, thiết lập S = 1 và n = 1
 double S = 1;
 int n = 1;
 double En;
 do {
 //2. Tính En, tích lũy En vào S
 En = EnS1(x,n);
 S = S + En;
 n++;
 } while (Math.Abs(En) >= EPSILON); //3. Lặp bước 2 nếu En >= epsilon
 //gởi kết quả về lệnh gọi hàm này
 return S;
 }
 //₫ịnh nghĩa hàm tính thành phần (-1)^nx^n/n!
 static double EnS2(double x, int n)
 {
 return Math.Pow(-1,n)*Math.Pow(x,n)/giaithua(n);
 }
 //₫ịnh nghĩa hàm tính công thức S2(x)
 static double S2(double x)
 {
 //1. Lúc ₫ầu, thiết lập S = 1 và n = 1
 double S = 1;
 int n = 1;
 double En;
 do {
 //2. Tính En, tích lũy En vào S
 En = EnS2(x,n);
 S = S + En;
 n = n + 1;
 } while (Math.Abs(En) >= EPSILON); //3. Lặp bước 2 nếu En >= epsilon

 //gởi kết quả về lệnh gọi hàm này
 return S;
 }
 //₫ịnh nghĩa hàm tính công thức S3(x)
 static double S3(double x)
 {
 //1. Lúc ₫ầu, thiết lập S = 1 và n = 1
 double S = 1;
 int n = 1;
 double En;
 do {
 //2. Tính En, tích lũy En vào S
 En = Math.Sin(n*x);
 S = S + En;
 n++;
 } while (Math.Abs(En) >= EPSILON); //3. Lặp bước 2 nếu En >= epsilon
 //gởi kết quả về lệnh gọi hàm này
 return S;
 }
 //chương trình chính thử dùng các hàm ₫ược viết
 static void Main(string[] args)
 {
 double x;
 String buf;
 //yêu cầu người dùng nhập x
 Console.Write("Nhập x : "); buf = Console.ReadLine();
 x = double.Parse(buf);
 //gọi thử hàm S1(x)
 Console.WriteLine("S1(" + x + ")= "+ S1(x));
 //gọi thử hàm S2(x)
 Console.WriteLine("S2(" + x + ")= " + S2(x));
 //gọi thử hàm S3(x)
 Console.WriteLine("S3(" + x + ")= " + S3(x));
 }
 }
} 