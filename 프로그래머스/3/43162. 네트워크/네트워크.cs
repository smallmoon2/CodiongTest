using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int n, int[,] computers) {
        int answer = 0;
        
        var visited = new bool[n]; 
        
        //Console.Write(computers[2,2]);
        for(int i = 0; i < n ; i++ ){
            if(!visited[i]){
                nodebfs(i, n, computers,  visited);
                answer ++;
            }
           
            
        }
        
        return answer;
    }
    
    public void nodebfs(int node, int n , int[,] computers, bool[]  visited){
        visited[node] = true;
        Console.Write(node);

        for(int j = 0; j < n; j++){
            if(computers[node,j] == 1 && (!visited[j])){
                nodebfs(j, n, computers, visited );   
            }
        }
    } 
}
