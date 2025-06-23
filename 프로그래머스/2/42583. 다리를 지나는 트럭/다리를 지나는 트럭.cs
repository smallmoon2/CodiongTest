using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int bridge_length, int weight, int[] truck_weights) {
        int time = 0;
        int num = 0;
        int all_Weight = 0;
        Queue<(int, int)> OnBridge = new Queue<(int, int)>();
        
        while(num < truck_weights.Length || OnBridge.Count != 0) {
            
            // 다리를 지난 트럭 제거
            if(OnBridge.Count > 0 && OnBridge.Peek().Item2 == time - bridge_length){
                all_Weight -= OnBridge.Peek().Item1;
                OnBridge.Dequeue();
            }

            // 새 트럭이 올라갈 수 있으면 올림
            if(num < truck_weights.Length && (all_Weight + truck_weights[num]) <= weight){
                OnBridge.Enqueue((truck_weights[num], time));
                all_Weight += truck_weights[num];
                num++;
            }

            time++;
        }

        return time;
    }
}