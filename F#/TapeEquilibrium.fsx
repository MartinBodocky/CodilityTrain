// Details : http://codility.com/demo/results/demoYYAYG7-KP9/
let rnd = System.Random()
let bList = [1..10000] |> List.map(fun a-> rnd.Next(-1000,1000))
let sList = [ -3; 1; -2; 4; - 3 ]

let first (c, _, _) = c

let solution (A:int list) : int =
    let res = Microsoft.FSharp.Core.int.MaxValue
    let sum = A |> List.sum
    A
    |> List.fold(fun (acc,sum1,sum2) elem ->
        let tmpSum1 = sum1 + elem
        let tmpSum2 = sum2 - elem
        let tmp = System.Math.Abs(tmpSum2 - tmpSum1)
        if tmp < acc then (tmp,tmpSum1,tmpSum2)
        else (acc,tmpSum1,tmpSum2)
    ) (res,0,sum)
    |> first

solution sList
solution bList