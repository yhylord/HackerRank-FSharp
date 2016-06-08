open System

Console.ReadLine()
Console.ReadLine().Split()
|> Array.map int
|> Array.sum
|> printfn "%A"