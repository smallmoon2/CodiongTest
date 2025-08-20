using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string[,] clothes) {
        //Console.WriteLine(();
        
        int answer = 1; 
        
        Dictionary<string, int> clothecount = new Dictionary<string, int>();
        
        for(int i = 0 ; i < clothes.GetLength(0); i++ ){
            

            String type = clothes[i,1];
            if(clothecount.ContainsKey(type)){
                
                clothecount[type] = clothecount[type] + 1;
                
            }
            else{
                clothecount[type] = 1;
            }

        }
        
        foreach(var num in clothecount.Values ){
            
            answer = answer * (num+1);
            
        }
        
        return answer -1 ;
    }
}