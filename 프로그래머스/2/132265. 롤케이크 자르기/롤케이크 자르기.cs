using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] topping) {
        int answer = 0;
        Dictionary<int, int> right = new Dictionary<int, int>();
        HashSet<int> left = new HashSet<int>();


        foreach (int t in topping) {
            if (!right.ContainsKey(t)){
                right[t] = 0;
                
            }
            right[t]++;
        }

        for (int i = 0; i < topping.Length; i++) {
            int t = topping[i];


            left.Add(t);

            right[t]--;
            if (right[t] == 0)
                right.Remove(t);

            if (left.Count == right.Count)
                answer++;
        }

        return answer;
    }
}