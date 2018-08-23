let describeArray arr = 
    match arr with
    | null -> "The array is null"
    | [||] -> "The array is empty"
    | [|x|] -> sprintf "The array has one element, %A" x
    | [|x; y|] -> sprintf "The array has two elements, %A and %A" x y
    | a -> sprintf "The array had %d elements, %A" a.Length a

describeArray [| 1 .. 4 |]
describeArray [| ("tuple", 1, 2, 3)|]