#include <iostream>
#include <queue>
#include <cstring>

using namespace std;

const int MAX = 1001;

int adjacent[MAX][MAX];
bool visited[MAX];

queue<int> q;

void DFS(int idx, int node){
    visited[idx] = true;
    cout << idx << " ";

    for(int i = 1; i <= node; i++){
        if(adjacent[idx][i] && !visited[i]){
            DFS(i, node);
        }
    }
}

void BFS(int idx, int node){
    q.push(idx);
    visited[idx] = true;

    while(!q.empty()){
        int current = q.front();
        q.pop();

        cout << current << " ";

        for(int i = 1; i <= node; i++){
            if(adjacent[current][i] && !visited[i]){
                q.push(i);
                visited[i] = true;
            }
        }
    }
}

int main(){
    int node, line, start;
    cin >> node >> line >> start;

    for(int i = 0 ; i < line; i++){
        int u, v;
        cin >> u >> v;

        adjacent[u][v] = 1;
        adjacent[v][u] = 1;
    }
    DFS(start, node);
    cout << "\n";

    memset(visited, false, sizeof(visited));
    BFS(start, node);
    cout << endl;
    return 0;
}