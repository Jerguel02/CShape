using System;
namespace GPTB2 {
class Program {
//₫ịnh nghĩa các biến cần dùng
static double a, b, c;
static double delta;
static double x1, x2, x; //thêm 1 biến x cho trường hợp a = 0 (pt bặc I)
//₫ịnh nghĩa hàm nhập 3 thông số a,b,c của phương trình bậc 2
static void NhapABC() {
String buf;
Console.Write("Nhập a : "); buf= Console.ReadLine();
a = Double.Parse(buf);
Console.Write("Nhập b : "); buf = Console.ReadLine();
b = Double.Parse(buf);
Console.Write("Nhập c : "); buf = Console.ReadLine();
c = Double.Parse(buf);
}
//₫ịnh nghĩa hàm tính nghiệm của phương trình bậc 2
static void GiaiPT() {
//tính biệt số delta của phương trình
if (a == 0)
{
x = -c/b;
}
else
{
delta = b * b - 4 * a * c;

if (delta >= 0) //nếu có nghiệm thực
{
x1 = (-b + Math.Sqrt(delta)) / 2 / a;
x2 = (-b - Math.Sqrt(delta)) / 2 / a;
}
}
}

//₫ịnh nghĩa hàm xuất kết quả
static void XuatKetqua() {
if (delta < 0)
//báo vô nghiệm
Console.WriteLine("Phương trình vô nghiệm");
else if (a == 0)
{
Console.WriteLine("X = " + x);
}
else //báo có 2 nghiệm
{
Console.WriteLine("Phương trình có 2 nghiệm thực : ");
Console.WriteLine("X1 = " + x1);
Console.WriteLine("X2 = " + x2);
}
}

//₫ịnh nghĩa chương trình (hàm Main)
static void Main(string[] args) {
NhapABC(); //nhập a,b,c
GiaiPT(); //giải phương trình
XuatKetqua(); //xuất kết quả
//chờ người dùng ấn Enter ₫ể ₫óng cửa sổ Console lại.
Console.Write("Ấn Enter ₫ể dừng chương trình : ");
Console.Read();
}
} //kết thúc class
} //kết thúc namespace