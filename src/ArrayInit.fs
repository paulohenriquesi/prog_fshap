open System

let divisions = 4.0
let twoPi = 2.0 * Math.PI
let divisionsArray = Array.init (int divisions) (fun i -> float i * twoPi / divisions)
let emptyIntArray : int[] = Array.zeroCreate 3
let emptyStringArray : string[] = Array.zeroCreate 3