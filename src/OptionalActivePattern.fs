open System

let (|ToBool|_|) x =
    let success, result = Boolean.TryParse(x)
    if success then Some(result)
    else            None

let (|ToInt|_|) x =
    let success, result = Int32.TryParse(x)
    if success then Some(result)
    else            None

let (|ToFloat|_|) x =
    let success, result = Double.TryParse(x)
    if success then Some(result)
    else            None

let describeString str =
    match str with
    | ToBool  b -> printfn "%s is a bool with value %b" str b
    | ToInt   i -> printfn "%s is an integer with value %d" str i
    | ToFloat f -> printfn "%s is a float with value %f" str f
    | _         -> printfn "%s is not a bool, int, or float" str