#include <iostream>
using namespace std;

int main()
{
    string s;
    
    cin >> s;
    
    int arr[26];

    for(int i = 0; i < 26; i++){
        arr[i] = -1;
    }
    
    for(int i = 0; i < s.length(); i++){
        int index = s[i] - 'a';
        if(arr[index] == -1){
            arr[index] = i;
        }
    }
    
    for(int i = 0; i < 26; i++){
        cout << arr[i] << ' ';
    }
    
    return 0;
}
