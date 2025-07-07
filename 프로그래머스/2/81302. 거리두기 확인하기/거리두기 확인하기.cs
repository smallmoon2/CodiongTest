using System;

public class Solution {
    public int[] solution(string[,] places) {
        int[] answer = new int[5];

        for (int i = 0; i < 5; i++) {
            string[] place = new string[5];
            for (int j = 0; j < 5; j++) {
                place[j] = places[i, j];
                
            }

            answer[i] = IsSafe(place) ? 1 : 0;
            //Console.Write($"^^^^{i}번째 테이블\n");
        }

        return answer;
    }
    
    
    public bool IsSafe(string[] place){
        int[] dx = {-1, 1, 0, 0};
        int[] dy = {0, 0, 1, -1};

        bool check = true;
        
        for(int x = 0; x < 5 ; x++){
            for(int y = 0; y <5; y++){
                if (place[x][y] != 'P') continue;
                
                //Console.Write($"{x},{y} 시작");

                for(int k = 0; k < 4 ; k++){
                    int nx = x + dx[k];
                    int ny = y + dy[k];
                    
                    if(nx < 0 || ny < 0 ||  nx >= 5 || ny >=5 ) continue;

                    if(place[nx][ny] == 'P'){

                        check =  false;
                        //Console.Write($"{nx},{ny} 1거름-------------\n");

                    }

                    if(place[nx][ny] == 'O'){
                        //Console.Write($"{nx},{ny} 중간\n");
                        for(int Rk = 0; Rk < 4 ; Rk++){
                            int Rnx = nx + dx[Rk];
                            int Rny = ny + dy[Rk];
                            
                            
                            if(Rnx < 0 || Rny < 0 ||  Rnx >= 5 || Rny >=5 ) continue;
                            //Console.Write($"-----------------{Rnx},{Rny} 중간 가지치기 {place[Rnx][Rny]} 값\n");
                            if(place[Rnx][Rny] == 'P' && !(x == Rnx && y == Rny) ){

       
                                check =  false;
                                //Console.Write($"{Rnx},{Rny} 2거름-------------\n");
                            }
                        }  
                    }
                    
                }
            }
        }

        return check;
            
    }
}