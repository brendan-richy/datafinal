// Start by creating a stack

Stack<string> actions = new Stack<string>();

// Add objects to a stack that could be recent user actions
// for this example, ill be picking actions a user could do
// if they were using photo manipulation software like photoshop

actions.Push("Import Image");
actions.Push("Select Image");
actions.Push("Reduce transparency by 20%");
actions.Push("Scale image by 50% on x axis");
actions.Push("Select export format at .png");

// We now have our stack of recent actions.

// Now check to see what our last action was and print it

string mostrecent = actions.Peek();

Console.WriteLine(mostrecent);

// This should return "Select export format at .png"

// Now lets pretend we hit ctrl+z on our keyboard to undo our
// most recent action. Turns out, we dont want to set our 
// export format as png.

actions.Pop();

// We have now simulated hitting ctrl+z and undoing our most
// recent action. If we were to check our work by peeking the
// stack again we would see that the new top of our stack is  
// "Scale image by 50% on x axis"

mostrecent = actions.Peek();

Console.WriteLine(mostrecent);

// Now lets practice counting the height of our stack.
// This would be useful because you wouldnt want to store
// every single action the user took in a program. This
// would eat up a ton of memory so most programs limit
// undo history to a few dozen actions.

int count = actions.Count();

Console.WriteLine(count);

// This will return 4, not five. Our stack was originally 5 high,
// but remember, we just popped the top  object.


// Lastly, lets clear our stack of recent actions. This would
// happen when you close your program if you dont store that info
// somewhere when you save your file. Or maybe you didnt want
// to save your file. 

actions.Clear();

// Our stack is now empty. Lets check.

count = actions.Count();

Console.WriteLine(count);

// This should return 0
