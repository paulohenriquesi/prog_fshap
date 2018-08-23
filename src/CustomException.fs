// open System
// open System.Collections.Generic

// exception NoMagicWandException
// exception NoFullMoonException of int * int
// exception BadMojoException of string

// let castHex (igredients : HashSet<string>) =
//     try
//         let currentWand = Environment.MagicWand

//         if currentWand = null then
//             raise NoMagicWandException
        
//         if not <| igredients.Contains("Toad Wart") then
//             raise <| BadMojoException("Need Toad Wart to cast hex!")
        
//         if not <| isFullMooon(DateTime.Today) then
//             raise <| NoFullMoonException(DateTime.Now.Month, DateTime.Now.Day)
        
//         let mana = 
//             igredients
//             |> Seq.map (fun i -> i.GetHashCode())
//             |> Seq.fold (+) 0
        
//         sprintf "%x" mana

//     with
//     | NoMagicWandException -> "Error: A magic wand is required to hex!"
//     | NoFullMoonException(m, d) -> "Error: Hexes can only be cast during a full moon."
//     | BadMojoException(m) -> sprintf "Error: Hex failed due to bad mojo [%s]" m    