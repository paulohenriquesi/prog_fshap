open System
open System.IO
open System.Collections.Generic

type MultiFileLogger() = 
    do printfn "Constructing..."
    let m_logs = new List<StreamWriter>()

    member t.AttachLogFile file = 
        let 