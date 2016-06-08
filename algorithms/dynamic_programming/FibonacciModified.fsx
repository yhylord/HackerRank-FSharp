open System

let ints = Console.ReadLine().Split() |> Array.map (int64 >> bigint)
let a = ints.[0]
let b = ints.[1]
let n = ints.[2]

let sqr x = x * x

let rec calc n =
    match n with
    | x when x = 1I -> a
    | x when x = 2I -> b
    | _ -> (n - 1I |> calc |> sqr, n - 2I |> calc) ||> (+)
    
calc n |> printfn "%O"