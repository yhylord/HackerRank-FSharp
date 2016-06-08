open System

(*
    Trivial to see that after n years (2n cycles),
    the height = 2 ^ (n + 1) - 1,
    which can be written as (1 <<< (x / 2 + 1)) - 1 (x in cycles).
    The height after odd cycles doubles,
    thus left shifted one bit ( <<< (x % 2) ).
*)
let t = Console.ReadLine() |> int
for i in 1 .. t do
    Console.ReadLine()
    |> int
    |> (fun x -> ((1 <<< (x / 2 + 1)) - 1) <<< (x % 2))
    |> printfn "%A"