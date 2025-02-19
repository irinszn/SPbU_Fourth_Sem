module Fibonacci

let fibonacci number = 
    if number <= 0 then
        None
    else
        let rec recFibonacci number current next =
            match number with
            | 0 -> Some(current) 
            | _ -> recFibonacci (number - 1) next (current + next)

        recFibonacci number 0 1
