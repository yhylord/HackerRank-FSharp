open System

let n = Console.ReadLine() |> int
let print row =
    {1 .. n - row} |> Seq.iter (fun i -> printf " ")
    {1 .. row} |> Seq.iter (fun i -> printf "#")
    printfn ""

{1 .. n} |> Seq.iter print