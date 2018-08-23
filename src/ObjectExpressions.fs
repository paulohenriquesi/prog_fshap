open System.Collections.Generic

type Person = 
    { First : string; Last : string }
    override t.ToString() = sprintf "%s, %s" t.First t.Last

let people = 
    new List<_>(
        [|
            { First = "Paulo"; Last = "Fernandes" }
            { First = "Camilla"; Last = "Teixeira" }
            { First = "Alice"; Last = "Fernandes" }
        |]
    )

let printPeople () = 
    Seq.iter (fun p -> printfn "\t %s" <| p.ToString()) people

printfn "Initial ordering:"
printPeople()

people.Sort(
    {
        new IComparer<Person> with
            member t.Compare(l, r) =
                if l.First > r.First then 1
                elif l.First = r.First then 0
                else -1
    }
)

printfn "After sorting by first name:"
printPeople()

people.Sort(
    {
        new IComparer<_> with
            member t.Compare(l, r) = 
                if l.Last > r.Last then 1
                elif l.Last = r.Last then 0
                else -1
    }
)

printfn "After sorting by last name:"
printPeople()