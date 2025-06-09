using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string dirs) {
        int answer = 0;

        
        bool[,,,] Check = new bool[11,11,11,11]; 

        
        int x =0;
        int y =0;
        
        Dictionary<char, (int mx, int my)> move = new Dictionary<char, (int, int)>{
            {'U', (0, 1)},
            {'D', (0, -1)},
            {'L', (-1, 0)},
            {'R', (1, 0)}
        };
        
        foreach(char dir in dirs){
            int nx = x + move[dir].mx;
            int ny = y + move[dir].my;
            
            if (nx < -5 || nx > 5|| ny < -5 || ny > 5 ){
                continue;
            }
            if(!Check[nx+5, ny+5, x+5, y+5]){
                
                Check[nx+5, ny+5, x+5, y+5] = true;
                Check[x+5, y+5, nx+5, ny+5] = true;
                answer++;
            }
            
            x = nx;
            y = ny;
           
        }
        

        return answer;
    }
}