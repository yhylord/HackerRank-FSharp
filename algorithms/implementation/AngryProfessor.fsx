open System

let solve () =
    let k = int (Console.ReadLine().Split()).[1]
    let attendances =
        Console.ReadLine().Split()
        |> Array.map int
        |> Array.filter (fun x -> x <= 0)
        |> Array.length
    match attendances with
    | x when x < k -> printfn "YES"
    | _ -> printfn "NO"

let t = Console.ReadLine() |> int
for i in 1 .. t do
    solve ()