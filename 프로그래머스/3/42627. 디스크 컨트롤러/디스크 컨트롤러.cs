using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[,] jobs) {
        int answer = 0;
        int time = 0;
        int totaltime = 0;
        // 	 〉	(3, 0) (6, 2) (9, 1)
        
        var job = new List<(int, int)>();
        for(int i =0; i < jobs.GetLength(0); i++){
            job.Add((jobs[i,1],jobs[i,0]));
        }
        
        job.Sort();
        //Console.WriteLine(job[0].Item1);
        
        while(job.Count > 0){
            
            for(int j = 0; j < job.Count; j++){
                if(time >= job[j].Item2){
                    
                    totaltime = totaltime + job[j].Item1 + time - job[j].Item2;
                    time = time + job[j].Item1 - 1;
                    job.RemoveAt(j);
                    break;
                }
            }
            //foreach (var item in job) {
                //Console.WriteLine(item);
            //}
            time ++;
            //Console.WriteLine(time);
        }

        return totaltime/jobs.GetLength(0);;
    }
}