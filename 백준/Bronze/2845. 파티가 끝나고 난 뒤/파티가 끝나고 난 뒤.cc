#include <iostream>
#include <string>
using namespace std;

int main() {
	int a, b;
	cin >> a >> b;

	int n, m, v, c, x;
	cin >> n >> m >> v >> c >> x;

	int people = a * b;

	int n1 = n - people;
	cout << n1 << endl;
	int n2 = m - people;
	cout << n2 << endl;
	int n3 = v - people;
	cout << n3 << endl;
	int n4 = c - people;
	cout << n4 << endl;
	int n5 = x - people;
	cout << n5 << endl;
}