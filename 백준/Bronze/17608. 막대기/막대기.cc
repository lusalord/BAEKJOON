#include <iostream>
#include <stack>
using namespace std;
int main() {
    int a;
    int cnt = 0;
    int max = 0;
    cin >> a;

    stack<int> s;

    for (int i = 0; i < a; i++) {
        int x;
        cin >> x;
        s.push(x);
    }

    while (s.size()) {
        if (s.top() > max) {
            max = s.top();
            cnt++;
        }
        s.pop();
    }
    cout << cnt;
    return 0;
}