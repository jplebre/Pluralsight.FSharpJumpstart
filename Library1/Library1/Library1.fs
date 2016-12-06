#if INTERACTIVE
#else
module JumpStart
#endif

let x = 42
let hi = "Hello"

// To force the return type:
let Greeting name : string =
    if System.String.IsNullOrWhiteSpace(name) then
        "Whoever you are"
    else
        name

// Type inference examples:
let SayHiTo personName =
    printfn "Hi, %s" (Greeting personName)

let TellMeANumber y =
    printfn "Your number is %i", y

// Sometimes inference is not right
let Square x = x * x
let Area length height =
    length * height

// Overriding inference of type:
let PreciseArea (length:float) (height:float) =
    length * height


// Looping
let CountToNumber max =
    for i in 0..max do
        printfn "%i" i

let CountThroughRange min max =
    for i in min..max do
        printfn "%i" i

// Nested Functions (note the () to make it clear it's a function call
let PrintSquareNumbers min max =
    let square n = n * n
    for x in min..max do
        printfn "%i squared is: %i" x (square x)
