#include <string>
#include <iostream>
#include <vector>

using namespace std;

vector<int> solution(int brown, int yellow) {
    vector<int> answer;
    int i = 3;
    while(1){
        if ((brown + yellow)%i == 0){
            if (yellow == (((brown+yellow)/i)-2) * (i-2)){
                break;
            }
        }
        i++;
    }
    answer.push_back((brown+yellow)/i);
    answer.push_back(i);
       
    return answer;
    
    
    
}