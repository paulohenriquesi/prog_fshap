// slow one...
let removeConsecutiveDupes1 lst = 
    let foldFunc acc item = 
        let lastNumber, dupesRemoved = acc
        match lastNumber with
        | Some c when c = item -> Some(c), dupesRemoved
        | Some c -> Some(item), dupesRemoved @ [item]
        | None -> Some(item), [item]    

    let (_, dupesRemoved) = List.fold foldFunc (None, []) lst
    dupesRemoved

// fast one
let removeConsecutiveDupes2 lst =
    let f item acc = 
        match acc with
        | [] -> [item]
        | hd :: tl when hd <> item -> item :: acc
        | _ -> acc
    List.foldBack f lst []