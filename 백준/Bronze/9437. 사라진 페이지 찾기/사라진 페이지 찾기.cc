#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    while (true) {
        int N, P;
        cin >> N;
        
        // 추가: 입력 종료 조건 처리
        if (N == 0) break;
        
        cin >> P;

        // 추가: 각 종이 묶음을 순서대로 확인
        for (int i = 0; i < N / 4; i++) {
            vector<int> pages = {
                2 * i + 1,
                2 * i + 2,
                N - 2 * i - 1,
                N - 2 * i
            };

            // 추가: 현재 묶음에 P가 포함되어 있으면 정답 처리
            bool found = false;
            for (int page : pages) {
                if (page == P) {
                    found = true;
                    break;
                }
            }

            if (found) {
                vector<int> answer;

                // 추가: 선택된 페이지 P를 제외한 나머지 3페이지 저장
                for (int page : pages) {
                    if (page != P) {
                        answer.push_back(page);
                    }
                }

                // 추가: 문제 조건에 맞게 오름차순 정렬
                sort(answer.begin(), answer.end());

                cout << answer[0] << ' ' << answer[1] << ' ' << answer[2] << '\n';
                break;
            }
        }
    }

    return 0;
}