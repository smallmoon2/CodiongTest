using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(int[] numbers) {
        // 1. 숫자를 문자열로 변환
        string[] strNumbers = numbers.Select(n => n.ToString()).ToArray();

        // 2. 커스텀 정렬 (내림차순)
        Array.Sort(strNumbers, (a, b) => (b + a).CompareTo(a + b));

        // 3. 이어붙이기
        string result = string.Join("", strNumbers);

        // 4. 예외 처리 (모두 0인 경우)
        if (result.StartsWith("0")) return "0";

        return result;
    }
}