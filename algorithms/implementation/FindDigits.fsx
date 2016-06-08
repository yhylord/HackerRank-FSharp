open System

let solve () =
    let s = Console.ReadLine()
    let n = int s
    s.ToCharArray()
    |> Array.map (fun x -> (int x) - (int '0'))
    |> Array.filter (fun x -> x <> 0 && n % x = 0)
    |> Array.length

let t = Console.ReadLine() |> int
(printfn "%A", [ for i in 1 .. t do yield solve ()]) ||> List.map