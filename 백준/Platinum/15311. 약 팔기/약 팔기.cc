#include <iostream>
using namespace std;

int main(void)
{
    cout << 2000 << "\n";
    for (int i = 0; i < 1000; ++i)
        cout << 1 << ' ';
    for (int i = 0; i < 1000; ++i)
        cout << 1000 << ' ';
    return 0;
}