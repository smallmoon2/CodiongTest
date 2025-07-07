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
        }

        return answer;
    }
    
    
    public bool IsSafe(string[] place){
       int[] dx = { -1, 1, 0, 0 };
        int[] dy = { 0, 0, -1, 1 };

        // 대각선
        int[] diagDx = { -1, -1, 1, 1 };
        int[] diagDy = { -1, 1, -1, 1 };

        for (int x = 0; x < 5; x++) {
            for (int y = 0; y < 5; y++) {
                if (place[x][y] != 'P') continue;

                // 1. 상하좌우 확인
                for (int d = 0; d < 4; d++) {
                    int nx = x + dx[d];
                    int ny = y + dy[d];

                    if (nx < 0 || ny < 0 || nx >= 5 || ny >= 5) continue;

                    if (place[nx][ny] == 'P') {
                        return false; // 거리두기 위반
                    }

                    // 2. 맨해튼 거리 2인 경우 (직선 2칸)
                    int nnx = x + dx[d] * 2;
                    int nny = y + dy[d] * 2;
                    if (nnx >= 0 && nny >= 0 && nnx < 5 && nny < 5) {
                        if (place[nnx][nny] == 'P' && place[nx][ny] != 'X') {
                            return false;
                        }
                    }
                }

                // 3. 대각선 확인
                for (int d = 0; d < 4; d++) {
                    int nx = x + diagDx[d];
                    int ny = y + diagDy[d];

                    if (nx < 0 || ny < 0 || nx >= 5 || ny >= 5) continue;

                    if (place[nx][ny] == 'P') {
                        if (place[x][ny] != 'X' || place[nx][y] != 'X') {
                            return false;
                        }
                    }
                }
            }
        }

        return true;
    }
}