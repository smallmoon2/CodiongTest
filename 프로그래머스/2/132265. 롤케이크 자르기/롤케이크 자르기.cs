using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] topping) {
        int answer = 0;
        Dictionary<int, int> right = new Dictionary<int, int>();
        HashSet<int> left = new HashSet<int>();

        // 초기 상태: 전체 토핑을 right에 카운트
        foreach (int t in topping) {
            if (!right.ContainsKey(t))
                right[t] = 0;
            right[t]++;
        }

        // 하나씩 왼쪽으로 옮기면서 비교
        for (int i = 0; i < topping.Length; i++) {
            int t = topping[i];

            // 왼쪽에 추가
            left.Add(t);

            // 오른쪽에서 제거
            right[t]--;
            if (right[t] == 0)
                right.Remove(t);

            // 종류 수가 같으면 정답++
            if (left.Count == right.Count)
                answer++;
        }

        return answer;
    }
}