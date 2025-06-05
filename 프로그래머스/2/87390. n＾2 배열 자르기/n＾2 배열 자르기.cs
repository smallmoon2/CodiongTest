using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int n, long left, long right) {
        
        List<int> list = new List<int>();

        // 2차원 배열이라고 생각하고 x, y 좌표를 찾는다.
        // 해당 좌표의 x, y 값 중 더 큰 값을 추가.
        for(long i = left; i <= right; i++)
        {
            int x = (int)(i / n);
            int y = (int)(i % n);

            int value = x > y ? x + 1 : y + 1;
            list.Add(value);                
        }

        return list.ToArray();
    }
}