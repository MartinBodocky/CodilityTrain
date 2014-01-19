//details: http://codility.com/demo/results/demoJYANDY-QFY/
let X = 10
let Y = 85
let D = 30

let solution (X:int) (Y:int) (D:int) : int =
    match X < Y with
    | true ->
        let distance = Y - X
        let steps = distance / D
        if distance % D <> 0 then steps+1
        else steps
    | false -> 0

solution X Y D