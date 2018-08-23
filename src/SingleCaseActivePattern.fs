open System.IO
let (|FileExtension|) filePath = Path.GetExtension(filePath)
let determineFileType filePath = 
    match filePath with
    | filePath when Path.GetExtension(filePath) = ".txt" 
        -> printfn "It's a text file."
    | FileExtension ".jpg"
    | FileExtension ".png"
    | FileExtension ".gif"
        -> printfn "It's an image file."
    | FileExtension x 
        -> printfn  "Uknown file extension [%s]" x
