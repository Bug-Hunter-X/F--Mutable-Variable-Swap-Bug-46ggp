let mutable x = 10
let mutable y = 20

let swap (x, y) =
    let temp = x
    x <- y
    y <- temp
    (x, y)

let (x, y) = swap (ref x, ref y)
printf "%d %d" x.Value y.Value

//Alternative solution using tuples:

let swapTuple (x, y) = 
    (y, x)

let (x,y) = swapTuple (x,y)
printf "%d %d" x y