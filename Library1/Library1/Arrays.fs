#if INTERACTIVE
#else
module JumpStart.Arrays
#endif

// You need both the [] and the ||
let array = [|1; 2; 3|]

// If you don't use ; then you are creating an array with one tuple (1,2,3)
let arrayWithOneTuple = [|1, 2, 3|]

// If values are in different lines, you can ommit the ;
let fruits =
[|
    "Strawberry"
    "Mango"
    "Orange"
|]

// Array of range of numbers:
let oneToFifty = [|1..50|]

// Array of range of numbers with specific interval
let oneToHundredInTenths = [|1..10..100|]

