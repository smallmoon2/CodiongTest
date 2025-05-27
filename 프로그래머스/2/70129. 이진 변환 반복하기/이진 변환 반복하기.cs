using System;

public class Solution {
    public int[] solution(string s) {
        int zeroCount = 0;
        int loopCount = 0;
        while(s != "1")
        {
            string replaceStr = s.Replace("0", string.Empty);
            int lengthDiff = s.Length - replaceStr.Length;
            zeroCount += lengthDiff;
            loopCount++;
            s = Convert.ToString(replaceStr.Length, 2);
        }
        
        int[] answer = new int[] {loopCount, zeroCount};
        return answer;
    }
}