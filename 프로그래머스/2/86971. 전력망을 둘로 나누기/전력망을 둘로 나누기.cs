using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int n, int[,] wires) {
        
        int answer = 100;
        

        for(int cut = 0; cut < n; cut++){
            var visit = new bool[n+1];
            var Dwires = new Dictionary<int, List<int>>();
            for (int i = 0; i < n+1; i++){
                Dwires.Add(i,new List<int>());
            }
            
            for (int i = 0; i < wires.GetLength(0); i++){
                if (cut != i){
                    Dwires[wires[i,0]].Add(wires[i,1]);
                    Dwires[wires[i,1]].Add(wires[i,0]);
                }
            }
            int count = SearchDFS(1, Dwires, visit);

            int diff = Math.Abs(count - (n - count));
                
            answer = Math.Min(answer,diff);
        }
        
       
        
        return answer;
        
    }
    
    public int SearchDFS(int Start, Dictionary<int, List<int>> Dwires, bool[] visit){
        
        visit[Start] = true;
        int count = 1;
        
        foreach(int nextnode in Dwires[Start]){
            if(!visit[nextnode]){
                count += SearchDFS(nextnode, Dwires, visit);
            }
        }
        
        
        return count;
    }
    
}