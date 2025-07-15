using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        int[,] tree = new int[n, n];
        int[] dx = { 1, 0, -1 }; 
        int[] dy = { 0, 1, -1 };
        
        int x = 0, y = 0, dir = 0, num = 1;
        int max = n * (n + 1) / 2;

        for (int i = 0; i < max; i++) {
            tree[x, y] = num++;
            
            int nx = x + dx[dir];
            int ny = y + dy[dir];

            if (nx < 0 || ny < 0 || nx >= n || ny >= n || tree[nx, ny] != 0) {
                dir = (dir + 1) % 3;
                nx = x + dx[dir];
                ny = y + dy[dir];
            }

            x = nx;
            y = ny;
        }

        List<int> answer = new List<int>();
        for (int i = 0; i < n; i++) {
            for (int j = 0; j <= i; j++) {
                answer.Add(tree[i, j]);
            }
        }

        return answer.ToArray();
    }
}