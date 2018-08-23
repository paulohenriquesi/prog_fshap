open System
open System.Collections.Generic

[<Measure>]
type amu
type Atom = { Name : string; Weight : float<amu> }

let periodicTable = new Dictionary<string, Atom>()

periodicTable.Add("H", { Name = "Hydrogen"; Weight = 1.0079<amu>})
periodicTable.Add("He", { Name = "Helium"; Weight = 4.0026<amu>})
periodicTable.Add("Li", { Name = "Lithium"; Weight = 6.9410<amu>})
periodicTable.Add("Be", { Name = "Beryllium"; Weight = 9.0122<amu>})
periodicTable.Add("B", { Name = "Boron "; Weight = 10.811<amu>})

let printElement symbol = 
    if periodicTable.ContainsKey(symbol) then
        let atom = periodicTable.[symbol]
        printfn "atom with name %s has weigth %A." atom.Name atom.Weight
    else 
        printfn "Error. No atom with name %s found." symbol

let printElement2 symbol =
    match periodicTable.TryGetValue(symbol) with
    | true, atom -> printfn "atom with name %s has weigth %A." atom.Name atom.Weight
    | false, _ -> printfn "Error. No atom with name %s found." symbol

printElement "H"
printElement2 "Li"