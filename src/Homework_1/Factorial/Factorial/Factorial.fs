module Factorial

/// calculates the factorial of a number.
/// returns the factorial of a number.
let factorial number = 
    if number < 0 then
        None
    else
        let rec recFactorial number acc = 
            match number with
            | 0 -> Some(acc)
            | _ -> recFactorial (number - 1) (number * acc)

        recFactorial number 1