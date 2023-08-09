
#include <iostream>
#include <math.h>

using namespace std;
bool ktra(long long int pt)
{

  for (int i = 0; i < sqrt(pt); i++)
  {
    if (pt%i == 0)
    {
      return false; 
      
    }
  }
  
  return true;
}
int main()
{
  int n;
  cin >> n;
  ktra(n) ? cout<<"True" : cout << "False";
  return 0;
}