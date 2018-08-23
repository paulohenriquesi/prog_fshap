namespace MyProject.Utilities

type internal MyClass = 
    new : unit -> MyClass
    member public Property1 : int
    member private Method1 : int * int -> int