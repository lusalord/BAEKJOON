#include <iostream>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int n;
    int caseNumber = 1; // 추가: 테스트케이스 번호 관리

    while (true) {
        cin >> n;

        if (n == 0) { // 추가: 입력 종료 조건
            break;
        }

        for (int i = 0; i < n; i++) { // 추가: 정렬할 숫자들은 그냥 입력만 받고 버림
            int x;
            cin >> x;
        }

        cout << "Case " << caseNumber << ": Sorting... done!\n"; // 추가: 정답 형식 출력
        caseNumber++;
    }

    return 0;
}