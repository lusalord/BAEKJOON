#include <iostream>
using namespace std;
int main() {

    int a;
    cin >> a;
    cin.ignore();

    string str;




    for (int i = 0; i < a; i++) {
        getline(cin, str);

        for (int i = 0; i < str.length(); i++) {
            str[0] = toupper(str[0]);
            cout << str[i];
        }
        cout << endl;
    }
    return 0;
}