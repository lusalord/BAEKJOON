#include <iostream>
#include <queue>
using namespace std;

int main(){
    queue<int> q1;
    queue<int> q2;

    int n, m;
    cin >> n >> m;

    for(int i = 1; i <= n; i++){
        q1.push(i);
    }

    for(int i = 0; i < n; i++){
        for(int j = 0; j < m; j++){
            if(j < m - 1){
                q1.push(q1.front());
                q1.pop();
            }
            else{
                q2.push(q1.front());
                q1.pop();
            }
        }
    }
    cout << "<";
    for(int i = 0; i < n; i++){
        if(i == n - 1){
            cout << q2.front() << ">";
        }
        else{
            cout << q2.front() << ", ";
            q2.pop();
        }
    }
}