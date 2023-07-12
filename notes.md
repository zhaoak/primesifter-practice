# notes.md

scratchpad for working through programming process -- here to keep notes 
together with repo, not intended to be read by end-user

## notes start below

goal: find all primes less than or equal to user-provided integer `n`

### algorithm

1. get value `n` from user
2. create C# `List` of `int`s, populate with ints from 2 to `n`
3. iterate through list; remove any number `x` that is a multiple of `y`, with `y` initially holding a value of 2
    - determine if multiple by using `x % y`; if `x % y == 0`, `x` is a multiple of 2
4. once `x > n` is reached, return to beginning of list; pick lowest non-eliminated number to be `y`
5. repeat steps 3 and 4 until `y > n`, then terminate; the remaining numbers in the list are primes

