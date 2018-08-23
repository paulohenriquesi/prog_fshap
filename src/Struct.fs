[<Struct>]
type StructPoint(x : int, y : int) = 
    member t.X = x
    member t.Y = y

type StructRect(top : int, bottom : int, left : int, right : int) =
    struct
        member t.Top = top
        member t.Bottom = bottom
        member t.Left = left
        member t.Right = right
    end

[<Struct>]
type MPoint = 
    val mutable X : int
    val mutable Y : int