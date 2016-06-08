open System

Console.ReadLine()
Console.ReadLine().Split()
|> Array.map int64
|> Array.sum
|> printfn "%d"