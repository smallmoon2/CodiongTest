using System;

public class Solution {
    public bool solution(string s) {
        bool answer = true;
        int L_count = 0;
        int R_count = 0;
        for(int i= 0; i < s.Length ; i++){
            if(s[i] == '('){
            
                L_count++;
            }
            else{
                R_count++;
            }
            if ((L_count - R_count) ==-1)
                answer = false;
        }   
        Console.WriteLine($"{L_count}");
    
        if ((L_count - R_count) != 0){
            answer = false;
        }
        return answer;
        
    }
}