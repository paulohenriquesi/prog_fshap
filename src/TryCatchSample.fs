open System.IO

[<EntryPoint>]
let main (args : string[]) =
    let exitCode = 
        try
            let filePath = args.[0]

            printfn "Trying to gather information about file:"
            printfn "%s" filePath

            let matchingDrive = 
                Directory.GetLogicalDrives()
                |> Array.tryFind (fun drivePath -> drivePath.[0] = filePath.[0])
           
            if matchingDrive = None then
                raise <| new DriveNotFoundException(filePath)
            
            let directory = Path.GetPathRoot(filePath)
            if not <| Directory.Exists(directory) then
                raise <| new DirectoryNotFoundException(filePath)
            
            if not <| File.Exists(filePath) then
                raise <| new FileNotFoundException(filePath)
            
            let fileInfo = new FileInfo(filePath)
            printfn "Created = %s" <| fileInfo.CreationTime.ToString()
            printfn "Access = %s" <| fileInfo.LastAccessTime.ToString()
            printfn "Size = %s" <| fileInfo.Length.ToString()

            0
        with
        | :? DriveNotFoundException
        | :? DirectoryNotFoundException
            ->  printfn "Unhandled Drive or Directory not found exception"
                1
        | :? FileNotFoundException as ex
            ->  printfn "Unhandled FileNotFoundExecption: %s" ex.Message
                4
        | :? IOException as ex
            ->  printfn "Unhandled IOException: %s" ex.Message
                4
        | _ as ex
            ->  printfn "Unhandled Exception: %s" ex.Message
                5

    printfn "Exiting with code %d" exitCode
    exitCode