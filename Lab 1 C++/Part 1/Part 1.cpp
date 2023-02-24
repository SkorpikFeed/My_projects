#include "Header.h"
#include <vector>
#include <iostream>
#include <stdlib.h>
#include <string>
using namespace std;

int main()
{

	String First;
	cout << "(If you want to stop type 'STOP')" << endl << "Enter values:" << endl;
	string A;
	for (int i = 0; i != -1; i++)
	{
		cin >> A;
		if (A == "STOP")
			break;
		else if (A >= "A" && A <= "Z"|| A >= "a" && A <= "z")
		{
			cout << "Invalid" << endl;
			exit(0);
		}
		First.value.push_back(A);
	}
	system("cls");
	cout << "Your string:" << " ";
	for (int i = 0; i < First.Size(); i++)
	{
		cout << First.value[i] << " ";
	}
	cout << endl<<endl << "(If you want to delete '5' type 'DELETE')" << endl << "(If you want to know the size of the string type 'SIZE')" << endl << "(If you want to stop type 'STOP')" << endl;
	for (int i = 0; i != -1; i++)
	{
		cin >> A;
		if (A == "DELETE")
		{
			First.Delete5();
			cout << "Your string:" << " ";
			for (int i = 0; i < First.Size(); i++)
			{
				cout << First.value[i]<<" ";
			}
			cout << endl;
		}
		else if (A == "SIZE")
		{
			cout << "Your size:" << "" << First.Size()<<endl;
		}
		else if (A == "STOP") break;
		else cout << "Try again"<<endl;
	}

}
