#include <string>
#include <vector>
#include <sstream>

using namespace std;

string solution(string s) {
    string answer = s;
    answer.at(0) = toupper(answer.at(0));

    for (int i = 1; i<answer.size(); i++) {
        if (answer[i - 1] == ' ')
            answer[i]=toupper(answer[i]);
        else
            answer[i]=tolower(answer[i]);
    }
    return answer;
}