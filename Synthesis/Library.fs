module Synthesis

let abelar num =
        match (num > 12) && (num < 3097) && (num % 12 = 0)  with
        | true -> true
        | false -> false

    

let area b h =
    match (b >= 0.0) || (h >=0.0) with
    | true -> 0.5 * b * h
    | false ->  failwith "Base or height is negative"

let zollo numb =
    match numb >= 0 with
    | true -> numb * 2
    | false -> numb * (-1)
   

let min a b =
    match a < b with
    | true -> a
    | false -> b

let max a b =
    match a > b with
    | true -> a
    | false -> b

let ofTime h m s =
    match (h >= 0 && h < 25) && (m >= 0 && m <= 60) && (s >= 0 && s < 60) with
    | true -> (h * 60 * 60) + (m * 60) + s
    | false -> failwith "Incorrect time format"

let toTime _ =
    
    


let digits d =
    let rec numDig index acc =
        match (d>=index) || (d<=(-index)) with
        | false -> acc
        | _ -> numDig (index * 10) (acc + 1)
    numDig 10 1

let minmax f s t ff =
    let rec checksmall f s t ff=
        match f = 0 with
        | true -> checkbig f s t ff
        | _ -> p
        
    
    let check2 ss tt fff =
        match tt < fff with
        | true -> check3 ss tt 
        | _ -> check3 ss fff
        
    let check3 
    

let isLeap year =
    match (year % 4 = 0) && (year < 1582) with
    | true -> true
    | false -> false
    

let month m =
    match (m < 1) && (m > 12) with
    |true -> failwith "Incorrect range entered!"
    |false -> ()

    match m with
    |1 -> "January 31 days"
    |2 -> "February 28 days"
    |3 -> "March 31 days"
    |4 -> "April 30 days"
    |5 -> "May 31 days"
    |6 -> "June 30 days"
    |7 -> "July 31 days"
    |8 -> "August 31 days"
    |9 -> "September 30 days"
    |10 -> "October 31 days"
    |11 -> "November 30 days"
    |12 -> "December 31 days"
 

let toBinary _ =
    failwith "Not implemented"

let bizFuzz _ =
    failwith "Not implemented"

let monthDay _ _ =
    failwith "Not implemented"

let coord _ =
    failwith "Not implemented"