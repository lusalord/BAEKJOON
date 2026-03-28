#include <iostream>
#include <stack>
#include <vector>

using namespace std;

bool solution(string str) {
	stack<char> s;
	for (int i = 0; i < str.size(); i++) {
		if (str[i] == '(') {
			s.push('(');
		}
		else {
			if (s.empty() == true) {
				return false;
			}
			s.pop();
		}
	}
	if (s.empty() == false) {
		return false;
	}
	return true;
}

int main() {

	int n;
	cin >> n;
	vector<string> arr(n);
	for (int i = 0; i < n; i++) {
		string s;
		cin >> s;

		if (solution(s)) {
			arr[i] = "YES";
		}
		else {
			arr[i] = "NO";
		}
	}

	for (int i = 0; i < n; i++) {
		cout << arr[i] << endl;
	}
	
}