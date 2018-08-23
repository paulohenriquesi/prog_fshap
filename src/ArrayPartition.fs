let isGreaterThanTen x = x > 10
let partition = 
    [|5;5;6;20;1;3;7;11|]
    |> Array.partition isGreaterThanTen