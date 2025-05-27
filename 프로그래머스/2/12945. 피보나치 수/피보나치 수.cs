using System;

public class Solution {
    public int solution(int n) {
        int f0 = 0;
        int f1 = 1;
        int fn = 0;
        for(int i = 2; i < n+1; i++){
            fn = (f0 + f1)%1234567;
            f0 = (f1)%1234567;
            f1 = fn%1234567;
        }
        Console.WriteLine($"현재 플레이어 수는 {fn}입니다.");
        return fn%1234567;
    }
}