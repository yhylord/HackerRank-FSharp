open System

(*
    To get the maximum number in n-digit,
    we need 5's as much as possible.
    To split n into a multiple of 5 and one of 3:
    match n % 3 with
    | 0 -> (no need to minus 5's)
    | 1 -> (minus 2 * 5 = 10 = 1 (mod 3))
    | 2 -> (minus 1 * 5 = 5 = 2 (mod 3))
*)
let solve () =
    let n = Console.ReadLine() |> int
    let tryFill threes =
        match n with
        | x when x >= 5 * threes ->
            (String.replicate (n - 5 * threes) "5")
            + (String.replicate (5 * threes) "3")
        | _ -> "-1"
    match n % 3 with
    | 0 -> tryFill 0
    | 1 -> tryFill 2
    | _ -> tryFill 1

let t = Console.ReadLine() |> int
for i in 1 .. t do
    solve () |> printfn "%s"