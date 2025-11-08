#include <iostream>
using namespace std;

int main()
{
    int arr[9][9];
    int max = -1;
    int h, y;
    
    for(int i = 0; i < 9; i++){
        for(int j = 0; j < 9; j++){
            cin >> arr[i][j];
        }
    }
    
    for(int i = 0; i < 9; i++){
        for(int j = 0; j < 9; j++){
            if(arr[i][j] > max){
                max = arr[i][j];
                h = i + 1;
                y = j + 1;
            }
        }
    }
    cout << max << endl << h << " " << y << endl;
    
    return 0;
}
