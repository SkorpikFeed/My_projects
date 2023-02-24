#pragma once
#include <vector>
#include <string>
using namespace std;
class String
{
public:
	vector <string> value;
	vector <string> Delete5()
	{
		for (int i = 0; i < value.size(); i++)
		{
			if (value[i] == "5")
			{
				for (int j = i; j < value.size() - 1; j++)
				{
					value[j] = value[j + 1];
					if (j == value.size() - 2)
					{
						value.resize(value.size() - 1);
					}
				}
				i--;
			}
		}
		return value;
	}
	int Size()
	{
		int A = value.size();
		return A;
	};
};