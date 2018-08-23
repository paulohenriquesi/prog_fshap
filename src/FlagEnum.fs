open System

type FlagsEnum = 
    | Conservative = 0b0001
    | Progressist  = 0b0010
    | Liberalism   = 0b0100
    | Coletivism   = 0b1000

let isFlagSet (e : FlagsEnum) (flag : FlagsEnum) = 
    let flagName = Enum.GetName(typeof<FlagsEnum>, flag)
    if e &&& flag = flag then
        printfn "Flag [%s] is set." flagName
    else
        printfn "Flag [%s] is not set." flagName

let rightWing = FlagsEnum.Liberalism|||FlagsEnum.Conservative
isFlagSet rightWing FlagsEnum.Coletivism
isFlagSet rightWing FlagsEnum.Liberalism