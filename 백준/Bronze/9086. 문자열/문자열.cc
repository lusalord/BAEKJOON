#include <iostream>
using namespace std;

int main()
{
    int a;
    cin >> a;
    string s = "";
    
    for(int i = 0; i < a; i++){
        string t;
        cin >> t;
        
        cout << t[0];
        cout << t[t.length() - 1] << endl;
    }
    
    return 0;
}
