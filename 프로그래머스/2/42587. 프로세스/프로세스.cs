using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] priorities, int location) {
        int answer = 0;
        
        Queue<int> Qlist = new Queue<int>();
        
        foreach (int num in priorities)
        {
            Qlist.Enqueue(num);
        }
    
        
        while(Qlist.Count > 0){
            if(Qlist.Peek() == Qlist.Max()){
                Qlist.Dequeue();
                answer++;
                if(location ==0){
                    break;
                }
                location--;
                if(location < 0){
                    location = Qlist.Count -1;
                }
                
            }
            else{
                Qlist.Enqueue(Qlist.Peek());
                Qlist.Dequeue();
                
                location--;
                if(location < 0){
                    location = Qlist.Count -1;
                }
            }
        }
        
        return answer;
    }
}