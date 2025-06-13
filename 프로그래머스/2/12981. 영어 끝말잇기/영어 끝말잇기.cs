using System;
using System.Collections.Generic;

class Solution
{
    public int[] solution(int n, string[] words)
    {
        int[] answer = { 0, 0 };
        HashSet<string> usedWords = new HashSet<string>();

        string prev = words[0];
        usedWords.Add(prev);

        for (int i = 1; i < words.Length; i++)
        {
            string curr = words[i];


            if (usedWords.Contains(curr) || prev[prev.Length - 1] != curr[0])
            {
                answer[0] = (i % n) + 1;   
                answer[1] = (i / n) + 1;        
                return answer;
            }

            usedWords.Add(curr);
            prev = curr;
        }

        return answer;  
    }
}