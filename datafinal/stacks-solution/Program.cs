// STEP 1
// Start by creating a stack, name it whatever you like.


// STEP 2
// Add objects to a stack that could be recent user actions
// for this example, ill be picking actions a user could do
// if they were using photo manipulation software like photoshop


// STEP 3
// We now have our stack of recent actions.
// Now check to see what our last action was and print it



// This should return "Select export format at .png"
// STEP 5
// Now lets pretend we hit ctrl+z on our keyboard to undo our
// most recent action. Turns out, we dont want to set our 
// export format as png.


// We have now simulated hitting ctrl+z and undoing our most
// recent action. If we were to check our work by peeking the
// stack again we would see that the new top of our stack is  
// Whatver the second to last thing oyu added to the stack was.
// STEP 6
// Peek at the stack and print it




// STEP 7
// Now lets practice counting the height of our stack.
// This would be useful because you wouldnt want to store
// every single action the user took in a program. This
// would eat up a ton of memory so most programs limit
// undo history to a few dozen actions.
// Count the height of the stack and print it. It should 
// be one less than the number of objects you added to it.


// STEP 8
// Lastly, lets clear our stack of recent actions. This would
// happen when you close your program if you dont store that info
// somewhere when you save your file. Or maybe you didnt want
// to save your file. 



// Our stack is now empty. Lets check.
// STEP 9
// Check the height of the stack and return it.



// This should return 0
