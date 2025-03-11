module CS220.Quiz1.Math

open System

let f n = 
  if n%2UL=0UL then n/(2UL) else 3UL*n+1UL

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let rec iter cnt n = 
    let result = f n
    if result = 1UL then cnt else iter (cnt+1UL) result
  int32 (iter 1UL (uint64 n))