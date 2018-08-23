open System

type private Ruby private(shininess, carats) = 
    let mutable m_size = carats
    let mutable m_shininess = shininess

    member this.Polish() = 
        this.Size <- this.Size - 0.1
        m_shininess <- m_shininess + 0.1
    
    member public this.Size with get() = m_size
    member private this.Size with set newSize = m_size <- newSize
    member this.Shininess with get() = m_shininess

    public new() =
        let rng = new Random()
        let s = float (rng.Next() % 100) * 0.01
        let c = float (rng.Next() % 16) + 0.1
        new Ruby(s, c)

    public new(carats) =
        let rng = new Random()
        let s = float (rng.Next() % 100) * 0.01
        new Ruby(s, carats)    