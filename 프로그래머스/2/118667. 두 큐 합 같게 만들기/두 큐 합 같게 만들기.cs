using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
        public int solution(int[] queue1, int[] queue2) {
        Queue<long> q1 = new Queue<long>(queue1.Select(x => (long)x));
        Queue<long> q2 = new Queue<long>(queue2.Select(x => (long)x));

        long sum1 = q1.Sum();
        long sum2 = q2.Sum();
        long total = sum1 + sum2;

        if (total % 2 != 0) return -1;

        long target = total / 2;
        int maxCount = queue1.Length * 3;
        int count = 0;

        int p1 = 0, p2 = 0;

        while (count <= maxCount) {
            if (sum1 == target) return count;

            if (sum1 > target) {
                long n = q1.Dequeue();
                sum1 -= n;
                q2.Enqueue(n);
            } else {
                long n = q2.Dequeue();
                sum1 += n;
                q1.Enqueue(n);
            }

            count++;
        }

        return -1;
        }
}