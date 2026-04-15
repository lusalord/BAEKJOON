#include <bits/stdc++.h>
using namespace std;

using ll = long long;

// 추가: 아직 바로 사용할 수 없는 간선을 컴포넌트별로 관리하기 위한 구조체
struct WaitingEdge {
    ll needMySum;   // 이 컴포넌트의 합이 여기까지 커지면 다시 확인할 가치가 있음
    int otherRoot;  // 반대편 컴포넌트 대표자(꺼낼 때 최신화)
    ll s;           // 필요한 최소 합
    int idx;        // 간선 번호

    bool operator<(const WaitingEdge& other) const {
        return needMySum > other.needMySum; // min-heap
    }
};

// 추가: 지금 당장 사용할 수 있는 간선을 번호 작은 순으로 뽑기 위한 구조체
struct ReadyEdge {
    int idx;
    int aRoot;
    int bRoot;

    bool operator<(const ReadyEdge& other) const {
        return idx > other.idx; // min-heap
    }
};

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int n, m;
    cin >> n >> m;

    vector<ll> compSum(n + 1);
    vector<int> parent(n + 1);

    // 추가: 각 컴포넌트의 대기 간선 힙
    vector< priority_queue<WaitingEdge> > waiting(n + 1);

    // 추가: 지금 즉시 사용 가능한 간선 힙
    priority_queue<ReadyEdge> ready;

    vector<int> answer;

    for (int i = 1; i <= n; ++i) {
        cin >> compSum[i];
        parent[i] = i;
    }

    // 추가: DSU find
    auto findRoot = [&](int x) {
        int r = x;
        while (parent[r] != r) r = parent[r];
        while (parent[x] != x) {
            int p = parent[x];
            parent[x] = r;
            x = p;
        }
        return r;
    };

    // 추가: 현재 상태에서 간선을 ready 또는 waiting에 넣는 함수
    auto addOrDelay = [&](int aRoot, int bRoot, ll s, int idx) {
        aRoot = findRoot(aRoot);
        bRoot = findRoot(bRoot);
        if (aRoot == bRoot) return;

        if (compSum[aRoot] + compSum[bRoot] >= s) {
            ready.push({idx, aRoot, bRoot});
            return;
        }

        ll deficit = s - compSum[aRoot] - compSum[bRoot];
        ll needA = compSum[aRoot] + (deficit + 1) / 2;
        ll needB = compSum[bRoot] + (deficit + 1) / 2;

        waiting[aRoot].push({needA, bRoot, s, idx});
        waiting[bRoot].push({needB, aRoot, s, idx});
    };

    for (int i = 1; i <= m; ++i) {
        int a, b;
        ll s;
        cin >> a >> b >> s;
        addOrDelay(a, b, s, i);
    }

    // 추가: small-to-large로 컴포넌트 병합
    auto mergeComponents = [&](int x, int y) {
        x = findRoot(x);
        y = findRoot(y);
        if (x == y) return x;

        if (waiting[x].size() < waiting[y].size()) swap(x, y);

        parent[y] = x;
        compSum[x] += compSum[y];

        while (!waiting[y].empty()) {
            WaitingEdge cur = waiting[y].top();
            waiting[y].pop();
            cur.otherRoot = findRoot(cur.otherRoot);

            if (cur.otherRoot == x) continue;
            waiting[x].push(cur);
        }

        return x;
    };

    // 추가: 컴포넌트 합이 커진 뒤, 다시 볼 가치가 생긴 대기 간선 처리
    auto activate = [&](int root) {
        root = findRoot(root);

        while (!waiting[root].empty()) {
            WaitingEdge cur = waiting[root].top();
            int other = findRoot(cur.otherRoot);

            if (other == root) {
                waiting[root].pop();
                continue;
            }

            if (compSum[root] < cur.needMySum) break;

            waiting[root].pop();

            if (compSum[root] + compSum[other] >= cur.s) {
                ready.push({cur.idx, root, other});
            } else {
                ll deficit = cur.s - compSum[root] - compSum[other];
                ll needRoot = compSum[root] + (deficit + 1) / 2;
                ll needOther = compSum[other] + (deficit + 1) / 2;

                waiting[root].push({needRoot, other, cur.s, cur.idx});
                waiting[other].push({needOther, root, cur.s, cur.idx});
            }
        }
    };

    while (!ready.empty()) {
        ReadyEdge cur = ready.top();
        ready.pop();

        int aRoot = findRoot(cur.aRoot);
        int bRoot = findRoot(cur.bRoot);

        if (aRoot == bRoot) continue;

        answer.push_back(cur.idx);
        int mergedRoot = mergeComponents(aRoot, bRoot);
        activate(mergedRoot);
    }

    cout << answer.size() << '\n';
    for (int idx : answer) {
        cout << idx << ' ';
    }
    cout << '\n';

    return 0;
}