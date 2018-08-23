let whatIs (x: obj) =
    match x with
    | :? string as s -> printfn "x é uma string %s" s
    | :? int as i -> printfn "x é um inteiro %d" i
    | :? list<int> as l -> printfn "x é uma list '%A'" l
    | _ -> printfn "x is a '%s'" <| x.GetType().Name;;

whatIs [1 .. 5]
whatIs "Rosebud"
whatIs (new System.IO.FileInfo(@"C:\config.sys"))