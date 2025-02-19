module ListReverse

let reverse list =
    let rec recReverse list acc = 
        match list with
        | [] -> acc
        | head :: tail -> recReverse tail (head :: acc)

    recReverse list []