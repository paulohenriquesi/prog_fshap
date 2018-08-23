open System

let daysOfWeek = Enum.GetNames( typeof<DayOfWeek> )
let days2To4 = daysOfWeek.[2..4]
let days4To = daysOfWeek.[4..]
let daysTo2 = daysOfWeek.[..2]
let copy = daysOfWeek.[*]
