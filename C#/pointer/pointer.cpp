/*pointer?
* x = 2: bien x luu gia tri la so 2
* kieu nguoi dunf gtu dinh nghia: struct, enum
* kieu cau truc du lieu (data structure): list, dictionary, tuple, set
* linked list, queue, stack
*/
//---------------------------------------------------------------------
/*
* bien con tro: la bien co kieu du lieu se luu dia chi cua o nho 
* kieu con tro: 
*/

#include <iostream>
using namespace std;
int main()
{
    //int* p;
    //bien tham chieu, ki hieu &, scanf(&x)
    //1. ciet chuong trinh tao tham chieu r cua so nguyen n
    //va tham chieu den so thuc x

    // khai bao bien so nguyen n
    int n;
    //khai bap kieu so thuc x
    double x;
    //tao tham chieu r cua bien n
    int& r = n;
    //tao tham chieu s cua bien x
    double& s = x;

    n = 5;
    x = 10.5;
    cout << "Bien n = " << n << endl;
    cout << "Tham chieu r = " << r << endl; 
    cout << "Tham bien x = " << x << endl;
    cout << "Tham chieu s =" << s << endl;
    n = 10;
    cout << "Bien n = " << n << endl;
    cout << "Tham chieu r = " << r << endl; 
    r = 15;
    cout << "Bien n = " << n << endl;
    cout << "Tham chieu r = " << r << endl; 
    //dia chi cua bien n va thamm chieu r
    cout << "Dia chi cua bien n = " << &n << endl;
    cout << "Dia chi cua tham chieu r " << &r << endl;
return 0;
}