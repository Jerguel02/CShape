//con tro kep
#include <iostream>
using namespace std;

int main()
{
    //bien n
    int n = 5;
    //con tro pn
    int* pn = &n;
    //con tro tham chieu kep ppn
    int** ppn = &pn;

    cout << "Gia tri cua bien n :" << endl;
    cout << "Tham chieu truc tiep (ten bien):" << n << endl;
    cout << "Tham chieu gian tiep (con tro): " << *pn << endl;
    cout << "Tham chieu gian tiep kep: " << **ppn << endl;
    cout << "Dia chi cua bien n (truc tiep): " << pn << endl;
    cout << "Dia chi cua bien n(gian tiep): " << *ppn << endl;


}