namespace FSCollectionExtensions

open System.Collections.Generic

module List =

    let rec skip n list = 
        match n, list with
        | _, [] -> []
        | 0, list -> list
        | n, hd::tl -> skip (n - 1) tl

module Seq = 

    let rev (s : seq<'a>) =
        let stack  = new Stack<'a>()
        s |> Seq.iter stack.Push
        seq {
            while stack.Count > 0 do
                yield stack.Pop()
        }