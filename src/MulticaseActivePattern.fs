
open System

let (|Paragraph|Sentence|Word|WhiteSpace|) (input : string) = 
    let input = input.Trim()

    if input = "" then
        WhiteSpace
    elif input.IndexOf(".") <> - 1 then
        let sentences = input.Split([|"."|], StringSplitOptions.None)
        Paragraph (sentences.Length, sentences)
    elif input.IndexOf(" ") <> - 1 then
        Sentence (input.Split([|" "|], StringSplitOptions.None))
    else
        Word (input)

let rec countLetters str = 
    match str with
    | WhiteSpace                -> 0
    | Word x                    -> x.Length
    | Sentence words            -> Array.sumBy countLetters words
    | Paragraph (_, sentences)  -> Array.sumBy countLetters sentences       