using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Jake Gillenwater
// 4/30/2016
// Start Time: 2:11am
// End Time: 2:25am
// Completion time: 14 minutes
//
// Challenge: Write a recursive funtion to find the nth sequence in the Fibonacci Sequence
//
// Link : http://blog.smartbear.com/programming/7-silly-programming-challenges-to-do-for-fun/
//
// What I learned from this: Code-breaks are a gift to mankind. I already knew how to set
//      up a recursive function, but I wasn't sure how to set it up to count the fibonacci 
//      sequence. So the first thing I did was check if it was 0, then return 0, because that
//      means I hit the end of the calculation. My Next instinct was to say if it wasn't equal 
//      to zero, to add it back to itself. This created a number that grew infinately high.
//
//      From there, I concluded I would have to subtract 1, not add. So that got me counting 
//      downward. This is where I remembered code-breaks in MS Visual Studio, so I started 
//      to put them to good use. Once I did that, I realized I was just counting down to
//      0, so I needed a way to impletment the acutal sequence. My first idea was to add 1
//      back into it, but that just made it lock up in an infinate loop of adding one, then
//      subtracting 1. So I subtracted 1 instead. This was close, but it made it go back
//      and forth a lot before getting down to a real answer.
//
//      Next I thought about the sequence was, which is  old + current = new. I worked backwards
//      think if subtracting 1 gave me the current, subtracting 2 should give me the old, right?
//      I had it. Using the code-breaks and steps I followed the numbers on a piece of paper.
//      Then I recognized the end of that sequence, then it got to one and then... -1.
//      Housten, we had a problem. An easy fix however, I simply added a check for 1 like I did
//      at the very beginning for 0. That corrected the issue, and I had my program.
//
// What I would do differently: Use a loop because recursion was confusing, and now I have a bunch
//          of seemingly random numbers written on paper around my desk.
//  

namespace FibonacciRecursion {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("What nth value would you like from the Fibonacci Sequence?");
            int TERM = int.Parse(Console.ReadLine());

            Console.WriteLine(fibSeq(TERM));
            Console.ReadLine();
        }

        static int fibSeq(int t) {
            if (t == 0)
                return 0;
            if (t == 1)
                return 1;
            else {
                return fibSeq(t - 1) + fibSeq(t - 2);
            }
        }
    }
}
