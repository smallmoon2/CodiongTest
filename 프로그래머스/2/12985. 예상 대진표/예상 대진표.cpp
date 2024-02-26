#include <iostream>
using namespace std;

int solution(int n, int a, int b)
{
    int answer = 0;
    if (b < a){
        answer = b;
        b = a;
        a = answer;
        answer = 0;
    }
    cout << a << ","<<  b << endl;
    while(1){
        
        if (a+1 == b && a%2 ==1){
            answer ++;
            break;
        }
        a = (a+1)/2;
        b = (b+1)/2;
        answer ++;
        cout << a << ","<<  b << endl;
    }
    // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.


    return answer;
}