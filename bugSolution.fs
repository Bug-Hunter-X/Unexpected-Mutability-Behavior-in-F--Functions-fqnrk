let x = ref 10
let y = ref 20

let add x y = 
    x := !x + !y
    !y

let result = add x y
printf "%d %d" !x result // This will print 30 20. Changes are reflected correctly

// Explanation:
// In F#, mutable variables are represented using the 'ref' keyword.  This creates a reference cell. 
// Accessing and modifying the value requires using the '!' operator (dereferencing).
// This approach ensures that changes made within the function correctly propagate to the variables outside the function.