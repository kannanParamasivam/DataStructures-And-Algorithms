using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_and_algorithms_practice
{
    class BigONotation
    {
        public void ForLoopWithConstantLoop(int n)
        {
            //O(N)
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Printing: " + i);
            }

            //O(100)
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Printing: " + i);
            }

            // O(N) + O(100)  --> O(N+100) --> O(N)
        }

        public void TwoForLoopsOfN(int n)
        {
            // O(N)
            for (int i = 0; i < n; i++)
            {
                // O(N)
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Printing: " + i * j);
                }
            }

            // O(N) * O(N) --> O(N^2)
        }

        public void TwoForLoopsNM(int n, int m)
        {
            // O(N)
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("N:Printing: ", +i);
            }

            // O(M)
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("M:Printing: ", +i);
            }

            // O(N) + O(M) --> O(N+M)

        }

        public void TwoForLoopsNAndM(int n, int m)
        {

            // O(N)
            for (int i = 0; i < n; i++)
            {
                // O(M)
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Printing: " + n * m);
                }
            }

            // O(N) * O(M) --> O(NM)
        }



        public void TwoForLoopsNesterAndNonNested(int n)
        {
            // O(N)
            for (int i = 0; i < n; i++)
            {
                // O(N)
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Printing: " + i * j);
                }
            }
            // O(N) * O(N) --> O(N^2)

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Printing: " + i);
            }
            // O(N)

            // O(N^2) + O(N) --> O(N^2 + N)
            // Because we only consider higher order term here O(N) gets eliminated.
            // When n vlaue is extremely high O(N) can be omitted

            // O(N^2 + N) --> O(N^2)
        }

        public void TwoForLoopsCompletelyStraightForward(int n)
        {

            // O(N)
            for (int i = 0; i < n; i++)
            {
                // O(N/2)
                for (int j = n; j > n / 2; j--)
                {
                    Console.WriteLine(String.Format("Printing:{0} * {1} = {2}", i, j, i * j));
                }

                Console.WriteLine();
            }

            // O(N * (N/2)) --> O((N^2)/2) 
            // Because we only consider higher order term we can remove dividing part
            // O(N^2)
        }

        public void DoublingLoopVariable(int n)
        {

            for (int i = 1; i < n; i = i * 2)
            {
                Console.WriteLine("Value is " + i);
            }

            // first iteration i = 1 = 2^0
            // Second iteration i = 1*2 = 2^1
            // Third iteration i = 2*2 = 2^2
            // Fourth iteration i = 4*2 = 2^3
            // Kth iteration i = 2^(K-1)
            // At some point 2^K => N where we breakout the loop
            // We need to find at what value of K we breakout the loop
            // log(base 2)(2^k) = log(base 2)(N)
            // Klog(base 2)2 = log(base 2)(N)
            // As we know log(base 2)2 = 1
            // K*1 = log(base 2)N
            // K = log(base 2)N
            // O(log(base 2)N)
            // O(log N)

        }

        public void HalvingLoopVariable(int n)
        {
            for (int i = n; i > 0; i = i / 2)
            {
                Console.WriteLine("Value of i is " + i);
            }
            // Similar as above but halving loop variable instead of doubling
            // O(log N)

            
        }



    }
}
