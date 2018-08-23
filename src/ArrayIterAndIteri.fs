let vowels = [| 'a'; 'e'; 'i'; 'o'; 'u' |]

Array.iter (fun chr -> printfn "vowel = %c" chr) vowels
Array.iteri (fun i chr -> printfn "vowel.[%d] = %c" i chr) vowels