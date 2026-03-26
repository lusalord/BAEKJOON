#include <iostream>
#include <cmath>
#include <iomanip>
using namespace std;

int main() {
	int n, m;
	cin >> n >> m;
	
	int cnt = n - (m * 2);

	cout << fixed << setprecision(1);
	cout << round(((float)cnt / 2) * 10) / 10;
}