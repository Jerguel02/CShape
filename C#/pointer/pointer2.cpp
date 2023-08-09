//Viet chuong trinh khai bao va khoi tao bien con tro p den bien n
#include <iostream>

using namespace std;
void Func(int& x)
{
    cout << "Dia chi cua tham so x: " << &x << endl;
    x = 101;

}
int main()
{
  /*  int n = 5;
    int& r = n;
    //Khai bao va khoi tao con tro p tro den bien n
    int* p = &n; //co tro chi luu dia chi o nho cua bo nho
    cout << "Bien n = "<< n << endl;
    cout << "Dia chi cua bien n = " << &n <<endl;
    cout << "Bien con tro p = " << p << endl;

    cout << "Dia chi cua tham chieu r = " << &r << endl;
    cout <<"r =" << r << endl;

    cout << "Dia chi con tro p = " << &p << endl;
    cout << "p = " << p;
*/
    int n = 5;
    //con tro pn
    cout << "n = " << n << endl;
    cout << "Dia chi cua doi so n = " << &n << endl;
    //doi so n duoc truyen bang tham chieu
    Func(n);
    cout << "n = " << n << endl;
    system("pause");
    return 0;
    
}