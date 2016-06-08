open System

Console.ReadLine()
let a = Console.ReadLine().Split(' ') |> List.ofArray |> List.map int

let count compare =
    List.filter (fun x -> compare x 0) a |> List.length
let positiveCount = count (>)
let negativeCount = count (<)
let zeroesCount = count (=)

let getFraction x = (float x) / (float a.Length)
List.map getFraction [positiveCount; negativeCount; zeroesCount]
|> List.iter (printfn "%f")