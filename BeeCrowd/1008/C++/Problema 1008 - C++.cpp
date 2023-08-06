#include <iostream>
using namespace std;

int main()
{
	int code, hour;
	double price;

	cin >> code;
	cin >> hour;
	cin >> price;

	cout << "NUMBER = " << code << endl;
	cout.precision(2);
	cout << fixed;
	cout << "SALARY = U$ " << price*hour << endl;
}

