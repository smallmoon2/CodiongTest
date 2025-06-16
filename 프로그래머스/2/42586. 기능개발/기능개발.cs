using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        
        int frist = 0;
        int num = 1; 
        List<int> answer  = new List<int>();
        int[] count = day(progresses, speeds);
        
        frist =  count[0];
        for (int i = 1; i < count.Length; i++){
            if (frist < count[i]){
                frist = count[i];
                answer.Add(num);
                num = 0;
            }
            num ++;
        }
        answer.Add(num);
            
        return answer.ToArray();;
    }
    
    
    public int[] day(int[] progresses, int[] speeds){
        List<int> Rday  = new List<int>();
        int Tday = 0;
        for (int i = 0; i < progresses.Length; i++){
            Tday = 0;
            while (progresses[i] < 100){
                progresses[i] = progresses[i] + speeds[i] ;
                Tday++;
                
            }
            Rday.Add(Tday);
        }
        
        return Rday.ToArray();
    }
}