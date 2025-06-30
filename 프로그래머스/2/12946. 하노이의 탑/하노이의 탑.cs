using System;
using System.Collections.Generic;

public class Solution {
    public List<int[]> moves = new List<int[]>();

    public int[][] solution(int n) {
        Hanoi(n, 1, 3, 2);
        return moves.ToArray();
    }

    void Hanoi(int n, int from, int to, int via) {
        if (n == 1) {
            moves.Add(new int[] { from, to });
            return;
        }

        Hanoi(n - 1, from, via, to);     
        moves.Add(new int[] { from, to });
        Hanoi(n - 1, via, to, from);     
    }
}