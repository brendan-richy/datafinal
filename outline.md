# Data Structures Tutorial

## About me
| Name | Email | Class |
|------|-------|-------|
| Brendan Richards | brenrichards@byui.edu | CSE 212-01|

## I. Stacks 

* Stacks are a type of data structure where the collection of elements is managed by a last in, first out (LIFO) order. This means the last added element to the stack will be the first one removed.

* The efficiency of a stack is O(1), since you can only work on the latest added element at a time. It doesn't matter if you have 10 or 10 million elements in a stack. You can only access the top element, regardless of the size of the stack.

* An example of a stack is a browser's history tab. Browser history tracks all the unique webpages you've been to, and a common function in browsers is to want to go back to a previous webpage. When you hit the back arrow in your browser, you are accessing a stack with all your history, and it takes you to the top element in the stack.

* For our first stack, we will be creating a stack that contains a list of recent purchases. We want to see which purchases have been returned and which ones have not. Go through the stack, and if a purchase has been returned, place it in the returns list and discard unreturned items.

## II. Sets 

* Sets are a collection of unique unordered elements. A key identifier of a set is that all elements are unique.

* The efficiency of a set depends on the operation you want to do. To add an element to the set, you must check if it is not already present (O(n)). To remove an element from a set, it's O(1).

* Sets can be demonstrated with unique usernames when registering for a website. You wouldn't want to have multiple people with the same username, or things could get messy. When you sign up for a website, it checks that your username/email haven't already been taken or signed up with.

* To practice sets, we will be registering students for classes. We wouldn't want to add a student again to a class they are already registered for. Check the class registry set to see if they are registered, if they aren't, add them to the list. If they are, print a warning message and don't add them.

## III. Trees 

* Trees are a hierarchical data type. Each tree starts at the top, and as it goes farther and farther down, you get more and more parents, and each parent has a child. Each individual child if it has children of its own is also a parent.

* If you want to search a tree for an element, you have an efficiency of O(n). When you search for something you are probably going to use recursion otherwise you will start approaching O(n^2).

* An example of a tree is a family tree. Literally. Each element in a tree has to have parents and you can trace the history of each element back to the start of when records for them were kept.

* For practice, we will be making a file directory tree for our class schedule. Our parent, or top-level folder will be the school we attend, and the children of that folder are the semesters. Each semester will have our registered classes.
