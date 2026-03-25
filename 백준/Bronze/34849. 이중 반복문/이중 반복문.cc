#include <iostream>
using namespace std;

int main() {
    long long N;
    cin >> N;

    if (N <= 10000) {
        cout << "Accepted";
    }
    else {
        cout << "Time limit exceeded";
    }

    return 0;
}