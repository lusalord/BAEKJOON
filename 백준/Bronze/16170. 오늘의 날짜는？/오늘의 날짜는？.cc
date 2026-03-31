#include <iostream>
#include <ctime>
using namespace std;

int main() {
    time_t now = time(nullptr);
    tm* utc = gmtime(&now);

    cout << utc->tm_year + 1900 << '\n';
    cout << utc->tm_mon + 1 << '\n';
    cout << utc->tm_mday << '\n';

    return 0;
}