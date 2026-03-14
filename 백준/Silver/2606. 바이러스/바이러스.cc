#include <iostream>
using namespace std;

const int MAX = 1001;

int adjacent[MAX][MAX];
bool visited[MAX];

int cnt = 0;


void DFS(int idx, int node){
    visited[idx] = true;
    cnt++;

    for(int i = 1; i <= node; i++){
        if(adjacent[idx][i] && !visited[i]){
            DFS(i, node);
        }
    }
}

int main(){
    int n, m;
    cin >> n >> m;

    int u, v;
    for(int i = 0; i < m; i++){
        cin >> u >> v;
        adjacent[u][v] = 1;
        adjacent[v][u] = 1;
    }

    DFS(1, n);

    cout << cnt - 1;
}