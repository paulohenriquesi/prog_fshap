// non tail recursive
let rec factorialBad x = 
    if x <= 1 then 1
    else
        let resultOfRecursion = factorialBad (x - 1)
        x * resultOfRecursion

let factorial x =
    let rec tailRecursiveFactorial x acc = 
        if x <= 1 then
            acc
        else
            tailRecursiveFactorial (x - 1) (acc * x)
    tailRecursiveFactorial x 1        