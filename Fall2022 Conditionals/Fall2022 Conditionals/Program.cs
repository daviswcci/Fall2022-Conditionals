// Conditionals 
// Conditionals allow us to create various paths within our code that we can take and perform different actions from

// If/Else-If/Else Statement
// Ask a question, perform an action if true, and perform a different action if false.
// We will create boolean statements to represent our conditions, and then write some code that runs if any of those conditions is true

// if(condition){
//  code we want to run if condition is true
// }
// else if(another condition){
//  code we want to run if all previous conditions are false and this condition is true
// }
// ...
// else {
//  code we want to run if all previous conditions are false
// }

var isSunny = true;
var isRaining = false;
var temp = 75;

if (isSunny && temp > 65)
{
    Console.WriteLine("It's sunny outside!");
}
else if(isSunny && temp >= 65)
{
    Console.WriteLine("It's a lovely day!");
}
else
{
    Console.WriteLine("It's not sunny outside!");
}

// How do we expand this to include more conditions?
// Else If block allows us as a user to check for an additional condition in the event that the first one is false

// What if we don't want to do anything in the else block?
// Else If and the Else blocks are both optional. If block is the only one that is mandatory

// If/Else statements will only ever execute one condition. Once a condition is true, we execute that code and skip to the end.
if (isSunny) // true
{
    Console.WriteLine("example");
}
else if(isSunny || true)
{
    Console.WriteLine("WOW!");
}
// skip to end

// Switch Case Statement
// We can use Switch/Case with many other values instead of just booleans
// int, bool, enums, floats, strings, characters ...
// You provide a value you want to 'switch' on, and the code falls into a 'case' where the values match
// Essentially... this means a switch case is just a bunch of equality checks
var errorCode = 404;
switch (errorCode)
{
    case 404:
        Console.WriteLine("Page not found.");
        break;
    case 200:
        Console.WriteLine("Hello!");
        goto case 404;
    case 201:
        Console.WriteLine("API error somehow");
        break;
    default:
        Console.WriteLine("Unknown error occured");
        break;
}

// break -> ends the switch case
// goto case X -> jumps over to another case
// goto default -> jumps to default
// we can put case labels next to each other without code inbetween if we want them to perform the same action.

// Ternary Statements
// Ternary -> three parts 
// Part 1: Question (condition)
// Part 2: Value if true
// Part 3: Value if false
// One of the main uses for ternary statements is shorthand for assigning values of some kind
var moodRating = 0;
var isHappy = false;
var isGlad = true;

if (isHappy)
{
    moodRating = 100;
}
else
{
    moodRating = -100;
}

// this is same as the above lines of code
// slightly limited in that the 'things' after the ? and : must be values and only values
moodRating = isHappy ? 100 : -100;

// Increment/Compound Operators
// Shorthand for operations/actions

moodRating = moodRating + 1; // increases the value of moodrating by 1
// shorthand, same as above
moodRating += 1; // (slightly different from =+), but for now just use +=
// generalized: variable += X -> increases variable by X
// shorthand for increasing a variable by 1:
moodRating++; // -- decreases a variable by 1

moodRating *= 100;