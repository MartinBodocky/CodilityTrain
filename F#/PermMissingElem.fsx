// Details : http://codility.com/demo/results/demoZMT7D9-DFA/

let bList = [1..10000] |> List.map(fun a-> a+1)
let sList = [ 1;3;2;5;6;7;8;4;10 ]

let solution (A:int list) : int =
    let sum = (A.Length + 1) *(A.Length+2)/2
    let sumList = A |> List.sum 
    sum - sumList

solution bList
solution sList