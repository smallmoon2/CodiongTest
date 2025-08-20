using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] answers) {
        int[] answer = new int[] {};
        int[] people1 = new int[]{1, 2, 3, 4, 5};
        int[] people2 = new int[]{2, 1, 2, 3, 2, 4, 2, 5};
        int[] people3 = new int[]{3, 3, 1, 1, 2, 2, 4, 4, 5, 5};
        


        int s1 = 0, s2 = 0, s3 = 0;
        
        for(int k = 0; k < answers.Length; k++){
            if(answers[k] == people1[k % people1.Length]){
                s1++;
            }
            if(answers[k] == people2[k % people2.Length]){
                s2++;
            }
            if(answers[k] == people3[k % people3.Length]){
                s3++;
            }
        }
        int maxScore = Math.Max(s1, Math.Max(s2, s3));
        

        
        var res = new List<int>(3);
        if (s1 == maxScore) res.Add(1);
        if (s2 == maxScore) res.Add(2);
        if (s3 == maxScore) res.Add(3);

        return res.ToArray();
    }
}