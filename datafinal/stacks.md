# Stacks

## What are they?

Stacks are a type of data structure where the collection of elements is managed by a last in, first out (LIFO) order. This means the last added element to the stack will be the first one removed.

* An example of a stack is a browser's history tab. Browser history tracks all the unique webpages you`ve been to, and a common function in browsers is to want to go back to a previous webpage. When you hit the back arrow in your browser, you are accessing a stack with all your history, and it takes you to the top element in the stack.

* Another example could be using `ctrl+z` in your favorite design software. ctrl+z is the common shortcut for undo. Your actions are organized into a stack and you would want to just undo to a random point. You just want to correct your recent mistake which is what stacks are perfect for.

## Creating a Stack

Using C#, we can create a set as follows.

```csharp
Stack<string> myStack = new Stack<string>();

// <string> represents the data type you will be storing in a stack.

// myStack is the name of your stack. Name it so you can recogniz e it.
```

## Functions

There are different ways we can use stacks in c#. We will go over the most common ways to use these structures.

`.Push()`

* This will add whatever is in the parentheses to the top of the stack. If we push multiple things to the stack, whatever we added last will be at the top of the stack.

`.Pop()`

* The function will remove the top item in a stack and return it. If the stack is empty it will throw an exception.

`.Peek()`

* Action will observe the object at the top of the stack without removing it. It does not change the stack.

`.Clear()`

* This will empty the stack of all elements.

`.Count()`

* Will return the number of objects in the stack.

## Practice

For our first stack, we will be creating a stack that contains our browsing history. This is a good example for a stack because most browsers let us navigate back to our recently viewed pages using the back button by the search bar or a keyboard shortcut.

### Push - lets create a stack

```csharp
Stack<string> myStack = new Stack<string>();

// add individual items to the stack

myStack.Push('www.mail.google.com');
myStack.Push('www.mail.google.com/emails/unread');
myStack.Push('www.mail.google.com/emails/394850');
```

What weve done here is create a stack with 3 objects in it. Remember, if we want to check what the stack contains we can only ever check the most recently added object. Think of it like a stack of milk crates. Whats inside each milk crate might be different, but if you want to access whats inside any of the crates besides the top one you need to take them off the stack.

For this specific example, you would want to create a stack so you could easily go back to your recent pages. At this point if we were viewing email `394850` and hit the back button, we would go back to viewing our unread emails.

### Peek - check the top of the stack

```csharp
// check the stack, then print the top item.

string top = myStack.Peek()

Console.Writeline(top);
>>> www.mail.google.com/emails/394850
```

Peek is useful when you just want to look at the top item in your stack. The defining characteristic of `.Peek()` is that it only observes. It takes no action on what it sees.

### Pop - remove the top of the stack

```csharp
// remove the top of the stack, then print it

string poppedItem = myStack.Pop();

// we now have the object 'www.mail.google.com/emails/394850' stored in our variable 'poppeditem'
Console.Writeline(poppedItem);
>>> www.mail.google.com/emails/394850
```

We have now popped the top item in our stack. If we were to use `.Peek()` again, it would look like this.

```csharp
string newTop = myStack.Peek();

Console.Writeline(newTop)
>>> www.mail.google.com/emails/unread
```

So from this we can see that `.Pop()` will remove the top item in a stack. This is the most important part of this function. If you call `.Pop()` on an empty stack, it will throw an exception as there is nothing at the top of the stack.

### Count - check how many objects are in a stack

```csharp
int count = mystack.Count();

Console.Writeline(count);
>>> 2
```

This one is pretty self explanatory. It simple returns a count of all the objects in a list. It doesnt read any of the contents of an object, just counts the length, or more appropriately.. the height of the stack. Notice how instead of initializing a string variable we used an `int`. This is because `.Count()` will return a specific integer rather than the contents of the stack.

### Clear - remove all items from the stack

```csharp
myStack.Clear()
```

We have now removed all items from the stack. if we want to check our work we can count the height of our stack again.

```csharp
int count = mystack.Count();

Console.Writeline(count);
>>> 0
```

## Problem to Solve - Edit History

Create and  manipulate a stack in a way that editing or content creation software might do with actions like ctrl+z in mind. Programs like photoshop, blender, or even visual studio code let you undo recent changes to whatever you are working on. These recent actions, or edits that you made are stored in a stack and then access when you decdide to undo your work or go back to an earlier point.

Your task is to:

* Initialize a stack named "actions" then add 5+ actions someone might have taken in a digital manipulation software application.
* Use `.Peek()` to view the most recent action, store it in a variable and print it to console.
* Use `.Pop()` to simulate using ctrl+z to undo your most recent action. Store this most recent action in a variable, and print it to console.
* Then, use `.Count()` to well, obviously count the height of the stack. Print this, and make sure it matches the number of items you added to the stack -1.
* Lastly, use `.Clear()` to empty the stack completly. Then check your work with `.Count()` again to make sure that it worked.

[Practice File](../datafinal\stacks-solution\Program.cs)

[Solution](../datafinal\stacks-solution\Solution.cs)

[Back to Welcome Page](Welcome.md)
