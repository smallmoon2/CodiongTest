using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public string solution(string number, int k) {

        List<int> numList = new List<int>();
        foreach (char c in number)
        {
            numList.Add(c - '0');
        }

        Stack<int> numStack = new Stack<int>();

        foreach (int i in numList)
        {
            while (k > 0 && numStack.Count > 0 && numStack.Peek() < i)
            {
                numStack.Pop();
                k--;
            }
            numStack.Push(i);
        }

        while (k > 0)
        {
            numStack.Pop();
            k--;
        }


        StringBuilder sb = new StringBuilder();
        foreach (int c in numStack.Reverse())  // 스택 순서 뒤집고 append
        {
            sb.Append(c);
        }

        return sb.ToString();

    }
}