using System;

public class Solution {
    public int solution(string skill, string[] skill_trees) {
        int answer = 0;
        
        for(int i = 0 ; i < skill_trees.Length ; i++){
        string filtered ="";
            for(int j = 0 ; j < skill_trees[i].Length ; j++){
                
                if (skill.Contains(skill_trees[i][j])) {
                    filtered += skill_trees[i][j];
                }
            }
            
            if (skill.StartsWith(filtered)) {
                Console.Write(filtered);
                answer++;
            }
            //성공 여부 확인
        }
        
      
        return answer;
    }
}