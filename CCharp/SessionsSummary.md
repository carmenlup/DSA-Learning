# Session 1
### Content
1. Number of operations calculation
1. Factors in a number: any number that divide a given number is a factor of that number
1. Prime numbers - numbers that have only 2 factors (1 and the number itself)
1. $log_{a}b = x => a^x = b$ (To what power we need to raise a to get b?)
> Log formula:
> 1. $log_{a}a^n = n$

### Problems
1. Count factors of a number
1. Is a number prime?
1. Reverse an array
2. Rotate an array K number of times to right

Important notes on optimal solution for Rotate an array k times:
![Minim k rotation](./Docs/Images/ArrayRotationRemark.png "Minim k rotation")

# Session 2 - Time complexity 1
### Content
1. Calculate iterations in a given code
- basic formulas
	- Gauss Summation: $`\displaystyle\sum_{i=1}^{n} i = 1 + 2 + 3 + ... + n = \frac{n(n + 1)}{2}`$
  - Geometric Progression (GP): $`\displaystyle\sum_{i=1}^{n} a = a * r^{1} + a * r^{2} + ... a * r^{n} = \frac{a * (r^{n} - 1)}{r - 1}`$
  - Total number of numbers in integer ranges formulas:
    - $`[a, b] => b - a + 1`$
    - $`(a, b], [a, b) => b - a`$
    - $`(a, b) => b - a + 1`$
  - Power formulas:
    - $a^{n} * a^{m} = a^{n\\ +\\ m}$
    - $a^{n} / a^{m} = a^{n\\ -\\ m}$
    - $(a^{n})^{m} = a^{n\\ *\\ m}$
2. Big O
$1 --> logN --> \sqrt{N} --> N -> N logN --> N \sqrt{N} --> N^{2} --> 2^{N} $
### Problems
1. Quizzes on theory
   
# Session 3 - Time complexity 2
### Content
1. Big O
2. Comparison two algorithms
3. Why we considering high order term
4. TLE - Time Limit Exceeded
5. T.C and S.C (Time Complexity and Space Complexity)
### Problems
1. Quizzes on theory
2. Examples

# Session 4 - Carry Forward
### Content
1. Count pairs
2. leaders in the array
3. N Bulbs
### Problems
1. Calculat numbers of pairs in a string for 2 given chars
    - Brute force
    - Optimal solution from end to start
![Carry Forward](./Docs/Images/CarryForwardBack.png "Carry Forward right to left")
    - Optimal solution from start to end
![Carry Forward](./Docs/Images/CarryForward.png "Carry Forward right to left")
1. Number of leaders in an array
    - Brute force: itereate over the array and get max
    - Optimal sol
# Session 5 - Prefix Sum
### Problems
1. Sum Range in a given array for a number of Queries
    - Brute force 
    - Optimal solution
2. Equilibrium problem - LeftSum = RightSum 
3. Count even numbers in ranges for a given array
    - Brute force
    - Optimal solution