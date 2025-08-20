using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] array, int[,] commands) {

        // commands.GetLength(0)
        List<int> answer = new List<int>();
        
        List<int> Newarray = new List<int>();
        
        for(int i = 0; i < commands.GetLength(0); i++){
            Newarray = new List<int>();
            int a = commands[i,0];
            int b = commands[i,1];
            int c = commands[i,2];
            
            for (int j = 0; j < b - a + 1; j++ ){
                
                Newarray.Add(array[a-1+j]);
                Newarray.Sort();
            }
            
            answer.Add(Newarray[c-1]);
            
            Console.WriteLine($"{a}, {b}, {c}");
            
        }

        
        return answer.ToArray();
    }
}