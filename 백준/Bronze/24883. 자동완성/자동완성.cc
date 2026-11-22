#include <iostream>
using namespace std;


int main() {
	string a;
	cin >> a;

	cout << ((a[0] == 'n' || a[0] == 'N') ? "Naver D2" : "Naver Whale");
}
