namespace MyProject.Utilities

type internal MyClass() =
    member this.Property1 = 10
    member this.Property2 with set (x : int) = ()
    member this.Method1 (x, y) = x + y
    member this.Method2 () = true