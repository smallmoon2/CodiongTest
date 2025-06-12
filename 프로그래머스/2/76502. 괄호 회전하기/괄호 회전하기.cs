using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
        int answer = 0;

        for (int i = 0; i < s.Length; i++) {
            if (IsValid(s)) {
                answer++;
            }
            // 왼쪽으로 한 칸 회전
            s = s.Substring(1) + s[0];
        }

        return answer;
    }

    // 괄호 문자열이 올바른지 검사
    private bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s) {
            if (c == '(' || c == '{' || c == '[') {
                stack.Push(c);
            } else {
                if (stack.Count == 0) return false;

                if (IsMatch(stack.Peek(), c)) {
                    stack.Pop(); // 매칭되면 제거
                } else {
                    return false;
                }
            }
        }

        return stack.Count == 0; // 남은 괄호 없으면 OK
    }

    private bool IsMatch(char open, char close) {
        return (open == '(' && close == ')') ||
               (open == '{' && close == '}') ||
               (open == '[' && close == ']');
    }
}