type Tastiness = 
    | Delicious
    | SoSo
    | TrySomethingElse

type IConsumable = 
    abstract Eat : unit -> unit
    abstract Tastiness : Tastiness

type Apple() = 
    interface IConsumable with
        member this.Eat() = printfn "Tasty!"
        member this.Tastiness = Delicious

type CardboardBox() =
    interface IConsumable with
        member t.Eat() = printfn "Yuck!"
        member t.Tastiness = TrySomethingElse

let apple = new Apple();
let consumable = apple :> IConsumable

consumable.Tastiness;;
