#if INTERACTIVE
#else
module JumpStart.ReturnTypes
#endif

// This function returns unit (ie. void)
let TellMeANumber y =
    printfn "Your number is %i", y

// This function returns an integer
let square x =
    x * x

// Because this function doesn't have parameters, it needs the ()
// This means that the function gets passed in an unit
let GiveMeARandomNumber() =
    let r = System.Random()
    r.NextDouble()

// If it doesn't have the (), the expression will be immediately evaluated
// (Try it in interactive, with and without () and you see it gets immediately evaluated and never returns a diff value
