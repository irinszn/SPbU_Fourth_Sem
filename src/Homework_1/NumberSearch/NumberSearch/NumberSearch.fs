module NumberSearch

/// function that returns the first position of a given number in a list.
/// returns the first position or None.
let searchNumber list number =
    let rec recSearch list acc =
        match list with
        | [] -> None
        | head :: tail -> if head = number then Some(acc) else recSearch tail (acc + 1)

    recSearch list 0