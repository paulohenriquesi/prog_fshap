type ChessPiece = 
    | Empty = 0
    | Pawn = 1
    | Knight = 3
    | Bishop = 4
    | Rook = 5
    | Queen = 8
    | King = 100000

let createChessBoard() = 
    let board = Array2D.init 8 8 (fun _ _ -> ChessPiece.Empty)

    for i = 0 to 7 do
        board.[1, i] <- ChessPiece.Pawn
        board.[6, i] <- enum<ChessPiece> (-1 * int ChessPiece.Pawn)

    let pieces = [| ChessPiece.Rook; ChessPiece.Knight; ChessPiece.Bishop; ChessPiece.Queen;
                    ChessPiece.King; ChessPiece.Bishop; ChessPiece.Knight; ChessPiece.Rook |]

    Array.iteri (fun i p -> board.[0, i] <- p) pieces
    Array.iteri (fun i p -> board.[7, i] <- enum<ChessPiece> (-1 * int p)) pieces
    
    board