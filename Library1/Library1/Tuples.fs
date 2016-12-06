#if INTERACTIVE
#else
module JumpStart.Tuples
#endif

// Tuples
// This method returns a tuple
let GenerateCoordinates() =
    let r = new System.Random()
    r.NextDouble(), r.NextDouble()

// Decompose the return into multiple values:
let latitude, longitude = GenerateCoordinates();

// You'll see that .net functions come declared with tuple parameters
// EG.: EnumerateFiles(Directory, something else)
// But in F# we usually don't. 
// This gives us partial declarations:
let Area length height =
    length * height

// Call area with 2 argunments, 5 is now 25
let x = Area 5 5;;

// Call area with only 1 argument, y is now a partial execution
let y = Area 5;;

// This means that y is Area of 5 missing the second argument, and can be called like so:
let z = y 5;;

// Voila, z is 25m^2
