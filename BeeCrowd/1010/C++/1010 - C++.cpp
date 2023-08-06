#include <iostream>
#include <string>
#include<vector>
#include<sstream>
using namespace std;

int main()
{
	string vendaA, vendaB;
	getline(cin, vendaA);
	getline(cin, vendaB);

	vector<string>vendaAItens;
	vector<string>vendaBItens;

	istringstream separaA{ vendaA };
	string trabalho;

	while (separaA >> trabalho) {
		vendaAItens.push_back(trabalho);
	}
	trabalho = "";

	istringstream separaB{ vendaB };

	while (separaB >> trabalho) {
		vendaBItens.push_back(trabalho);
	}

	cout.precision(2);
	cout << fixed;
	cout << "VALOR A PAGAR: R$ " << (stoi(vendaAItens[1]) * stod(vendaAItens[2])) + (stoi(vendaBItens[1]) * stod(vendaBItens[2])) << endl;
}
