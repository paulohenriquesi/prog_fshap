type RecordType = { X : int }
type ClassType2(x: int) =
    member this.Value = x
    override this.Equals(o : obj) =
        match o with
        | :? ClassType2 as other -> other.Value = this.Value
        | _ -> false
    override this.GetHashCode() = x

let a = { X = 10 }
let x = new ClassType2(31)
let y = new ClassType2(31)
let z = new ClassType2(2300)

