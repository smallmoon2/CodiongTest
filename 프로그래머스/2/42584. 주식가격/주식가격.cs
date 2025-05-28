using System;

public class Solution {
    public int[] solution(int[] prices) {
        int[] answer = new int[prices.Length];
        
        for (int i = 0; i <  prices.Length ; i++){
            
            for (int j = i ;  j < prices.Length  ; j++){
                
                if(prices[i] > prices[j]){
                    answer[i] = j - i;
                    break;
                }   
            }
            if(answer[i] == 0){
                answer[i] = prices.Length -i -1;
            }
        }
        answer[prices.Length-1] = 0;
        return answer;
    }
}