using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string[,] clothes) {
        int answer = 1;
        
        Dictionary<String,int> clothe_kind = new Dictionary<String, int>();
        
        for(int i = 0; i < clothes.GetLength(0); i++){
            //clothe_kind.Add = clothes[i];
            
            if(clothe_kind.ContainsKey(clothes[i,1])){
                clothe_kind[clothes[i,1]] ++;
            }
            else{
                //clothe_kind.Add(clothes[i,1],1);
                clothe_kind[clothes[i,1]] = 1;
            }
                
            
            Console.WriteLine($"{clothes[i,1]}");
            
        }
                    
        foreach (var item in clothe_kind)
        {
            Console.WriteLine($"종류: {item.Key}, 개수: {item.Value}");
            answer = answer * (item.Value + 1) ;
        }
            
        return answer - 1 ;
    }
}