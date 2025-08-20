using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        var answer = new List<int>();
        var pro = new Queue<int>();
        
        
        for (int i = 0; i < progresses.Length ; i++){
            int p = progresses[i];
            int count = 0; 
            
            while(p < 100){
                count++;
                p = progresses[i] + speeds[i] * count;
                
            }
            
            pro.Enqueue(count);
            
            
            //progresses[i];
            //speeds[i];
            
        }
        int Maxday = pro.Peek();
        int Count = 0;

        
        for(int j = 0; j < progresses.Length ; j++){
            pro.Dequeue();
            Count++;

            if(pro.Count() !=0){
                if (Maxday < pro.Peek()){
                    answer.Add(Count);
                    Count = 0;
                    
                    Maxday = pro.Peek();
                }   
            }
            
        }
        answer.Add(Count);
            
        // 7 3 9
        //pro.Enqueue(1);
        //Console.Write(pro.Peek());
        //pro.Dequeue();
        
        return answer.ToArray();
    }
}