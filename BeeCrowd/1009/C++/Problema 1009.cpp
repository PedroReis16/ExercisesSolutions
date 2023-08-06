#include <iostream>
#include <string>

using namespace std;
int main()
{
	string nome;
	double a, b;

	cin >> nome;
	cin >> a;
	cin >> b;

	cout.precision(2);
	cout << fixed;
	cout << "TOTAL = R$ " << a + (b * 0.15) << endl;
}
