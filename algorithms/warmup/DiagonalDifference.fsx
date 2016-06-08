open System

let n = Console.ReadLine() |> int
let a =
    Array.init n (fun r -> Console.ReadLine().Split(' ')
                           |> Array.map int)
let primarySum =
    Array.init n (fun i -> a.[i].[i]) |> Array.sum
let secondarySum =
    Array.init n (fun i -> a.[i].[n - i - 1]) |> Array.sum
primarySum - secondarySum |> abs |> printfn "%A"