open System

let v = Console.ReadLine() |> int
Console.ReadLine()
Console.ReadLine().Split()
|> Array.map int
|> Array.findIndex (fun x -> x = v)
|> printfn "%A"