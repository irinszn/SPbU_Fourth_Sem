module PowerSeries

/// function that gives n and m and sets a list of elements from 2^n to 2^(n + m).
/// returns list.
let powerSeries n m  = 
    if n < 0 || m < 0 then None else 
    let rec getSeries i acc =
        match i with
        | 0 -> Some(acc)
        | _ -> getSeries (i - 1) (List.head acc / 2 :: acc)
    
    getSeries m [pown 2 (n+m)]