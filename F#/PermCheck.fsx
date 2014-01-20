// Details: http://codility.com/demo/results/demoSX6U9N-ASB/

let bList = [1..10000] |> List.map(fun a-> a+2)
let sListPer = [ 4;1;3;2 ]
let sListNonPer = [ 4; 2; 2; 2 ]

let solution (A:int list) : int =
    let sum  = A.Length*(A.Length+1)/2
    let sumList = A |> List.sum
    if sum = sumList then
        let disCount = A |> List.toSeq |> Seq.distinct |> Seq.length
        if disCount <> A.Length  then 0 else 1
    else 0

solution bList
solution sListPer
solution sListNonPer