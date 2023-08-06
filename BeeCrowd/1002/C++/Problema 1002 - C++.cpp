
#include <iostream>
#include <cmath>
#include <ctgmath>
using namespace std;

int main()
{
    double raio;
    cin >> raio;

    cout.precision(4);
    cout << fixed;
    cout << "A=" << pow(raio, 2) * 3.14159 << endl;
}

