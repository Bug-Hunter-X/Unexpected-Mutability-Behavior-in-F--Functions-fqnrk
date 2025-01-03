let mutable x = 10
let mutable y = 20

let add x y = 
    x <- x + y
    y

let result = add x y
printf "%d %d" x result // This will print 30 20, not 30 30 as one might expect