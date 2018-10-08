# Shortest Path To 1

I found a [nice post about dynamic programming on freecodecamp]( https://medium.freecodecamp.org/demystifying-dynamic-programming-24fbdb831d3a).

In that post, the author describes a problem and solves it using dynamic programming,
both 'top down' and 'bottom' up'.

[jeroen-dhollander](https://github.com/jeroen-dhollander) implement the solution in python on his repo [shortest-path-to-1](https://github.com/jeroen-dhollander/shortest-path-to-1)

I decided to implement the same solution in c# using a few different solutions as  [jeroen-dhollander](https://github.com/jeroen-dhollander)

# The problem

Given an integer n, find the minimum number of steps to reach integer 1.

At each step, you can:
   *  Substract 1
   *  Divide by 2 (if it is divisible by 2)
   *  Divide by 3 (if it is divisible by 3)
