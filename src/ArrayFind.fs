let rec isPowerOfTwo x = 
    if x = 2 then
        true
    elif x % 2 = 1 then
        false
    else isPowerOfTwo (x / 2)

// First element that returns true
let tryFind = 
    [| 1; 7; 13; 64; 32 |]
    |> Array.tryFind isPowerOfTwo
   
let tryFindIndex = 
    [| 1; 7; 13; 64; 32 |]
    |> Array.tryFindIndex isPowerOfTwo