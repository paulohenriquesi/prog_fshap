open System.IO

let (|KBInSize|MBInSize|GBInSize|) filePath =
    let file = File.Open(filePath, FileMode.Open)
    if file.Length < 1024L * 1024L then
        KBInSize
    elif file.Length < 1024L * 1024L * 1024L then
        MBInSize
    else 
        GBInSize  

let (|EndsWithExtension|_|) extension filePath = 
    if Path.GetExtension(filePath) = extension then
        Some()
    else
        None

let (|IsImageFile|_|) filePath = 
    match filePath with
    | EndsWithExtension ".jpg"
    | EndsWithExtension ".bmp"
    | EndsWithExtension ".gif"
        -> Some()
    | _ -> None        

let imageTooBigForEmail filePath = 
    match filePath with
    | IsImageFile & (MBInSize | GBInSize) -> true
    | _ -> false