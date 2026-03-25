#include <iostream>
#include <queue>
using namespace std;

int main() {
    queue<int> q;
    queue<int> q2;
    int n, m;
    cin >> n >> m;

    for (int i = 1; i <= n; i++) {
        q.push(i);
    }

    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            if (j < m - 1) {
                q.push(q.front());
                q.pop();
            }
            else {
                q2.push(q.front());
                q.pop();
            }
        }
    }

	cout << "<";
    for (int i = 0; i < n; i++) {
        cout << q2.front();
        q2.pop();
        if (i < n - 1) {
            cout << ", ";
        }
    }
	cout << ">";
    return 0;
}