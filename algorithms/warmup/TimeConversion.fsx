open System

let s = Console.ReadLine()
let h = int s.[0..1];
let f = s.[8];
let h' =
    match (h, f) with
    | (12, 'P') -> 12
    | (12, 'A') -> 0
    | (x, 'A') when x <> 12 -> h
    | _ -> h + 12
printfn "%02i%s" h' s.[2..7]