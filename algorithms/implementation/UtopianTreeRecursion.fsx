open System

let solve () =
    let n = Console.ReadLine() |> int64
    let rec calc n =
        match n with
        | 0 -> 1
        | x when x % 2 = 1 -> calc(n - 1) * 2
        | _ -> calc(n - 1) + 1
    calc n |> printfn "%d"

let t = Console.ReadLine() |> int
for i in 1 .. t do
    solve ()