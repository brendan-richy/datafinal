# Sets

## What are they?

Sets, or more accurately HashSets is a collection of unique elements. Each element in a set has to be different from all other elements in the same set. You cannot add duplicate elements to a set.

Sets offer different types of operations to act on them. They include unions, intersections, and differences.

## What do those operations mean?

### Union

When you have multiple sets and want to compare them, using a union will combine all unique elements from set A and B. Basically, a union is a set of a set.

Unions expressions can be represented with the `∪` character. `∪` will go between the two sets you are comparing like this.

```csharp
A = {1, 2, 3}
B = {3, 4, 5}
A ∪ B = {1, 2, 3, 4, 5}
```

As you can see, the expression A ∪ B is all elements that occur in either set A or B, but with no duplicates. If there is a shared element in sets A and B, it will be in the resulting union, but only represented once.

### Intersection

Intersections is another operation that can be performed on two sets. An intersection of two sets will return elements common to both set A and set B.

Intersection expressions can be represented with the `∩` character. Just like a union `∩` goes between the two sets you are comparing.

```csharp
Set A = {1, 2, 3}
Set B = {3, 4, 5}
Intersection (A ∩ B) = {3}
```

The intersection of set A and Set B only contains the element 3, because that is the only shared element between the sets.

### Symmetric Difference

The symmetric difference, or "difference" of two sets generates a new set that contains elements that are unique to each set, but not those elements that are shared between two sets. Differences are very similair to a `Union` but with an added step that elements present in both sets A and B are not included in the difference.

Differences can be expressed using the `Δ` character, between set A and set B.

```csharp
Set A = {1, 2, 3}
Set B = {3, 4, 5}
Symmetric Difference (A Δ B) = {1, 2, 4, 5}
```

As you can see, this difference, does not contain the element 3. Thats because it is present in both set A and B. All other elements in those sets are in the resulting difference, because they are unique to that set and not shared.

## Creating a Set

Using C#, we can create a set as follows.

```csharp
HashSet<char> setA = new HashSet<char> { `Yellow`, `Blue`, `Red` };
```

But in order to do any operations on sets, we will need to have two of them. So make sure to create a second one.

```csharp
HashSet<char> setB = new HashSet<char> { `Red`, `Green`, `Black` };
```

Now that we have our two sets, we can practice our operations on them. We can refer to these sets, with their variable names `setA` and `setB`

It is absolutely critical to understand that when you perform a method on 2 sets, the resulting set will replace the set on the left side of the method. For example, when you get the Intersection of SetA and SetB, the left or `original` set, will be re-written with the resulting set.

For example

```csharp
// setA contains (A, B, C)
// SetB contains (C, D, E)

SetA.IntersectWith(SetB);

// Now we have overwritten the original setA, and replaced it with the intersecting. setA now contains only the element (3). setB remains unchanged
```

## Lets Practice our Methods

Lets reset our sets. We will use these sets for practice.

```csharp
HashSet<char> setA = new HashSet<char> { 'Q', 'R', 'S' };
HashSet<char> setB = new HashSet<char> { 'S', 'T', 'U' };
```

### Using a Union

To create the Union of two sets, we can use the `.UnionWith()` method

```csharp
setA.UnionWith(setB);

// Now that we have performed the union, the resulting set is stored in setA

foreach (var item in setA)
    {
        Console.WriteLine(item);
    }

>>> Q
>>> R
>>> S
>>> T
>>> U
```

As you can see, the union of the sets contains all the unique elements from both sets. No duplicates.

### Using an Intersection

Lets first reset setA

``` csharp
HashSet<char> setA = new HashSet<char> { 'Q', 'R', 'S' };
```

We will do this each time after we perform an operation it, just to be more clear about what has changed.

```csharp
setA.IntersectWith(setB);

// WE have now found the intersection of setA and setB. This is stored in the new `setA`

Console.WriteLine("Intersection Result:");

foreach (var item in setA)
    {
        Console.WriteLine(item);
    }

>>> S
```

Just as a reminder, an intersection is the elements that are shared between two sets. After you find the intersection of two sets, the remaining set will be only shared elemets between the sets.

### Finding the difference

Lets first reset setA

``` csharp
HashSet<char> setA = new HashSet<char> { 'Q', 'R', 'S' };
```

Now that we have reset setA, we can find the difference of setA and setB. To do this, we use the `.SymmetricExceptWith()`

```csharp
setA.SymmetricExceptWith(setB);

Console.WriteLine("Symmetric Difference Result:");

foreach (var item in setA)
{
    Console.WriteLine(item);
}

>>> Q
>>> R
>>> T
>>> U
```

Notice that `S` is missing. That is because it is the shared element between the original setA and setB.

## Problem to Solve - find followers

### Social Media Use-Case

On popular social platforms like instagram or facebook, it is a common feature to be able to view people that follow your accounts, accounts that you follow, and the accounts that other people follow. Basically, a list of followers/subscribers is stored with each user and there are seperate pages for mutual followes, or lists of people that you both follow.

For this practice problem we will look at two seperate users, and they people that they follow, as well as the people that follow them. Using set operations we will practice finding unions etc etc of these users.

### Your task is to

Using the given sets of userA and user B

* Find all users that userA or user B follow. These are called "accounts you both follow" this is an intersection.
* Find users that follow both userA and userB. These are called "mutual followers" and is also an intersection.
* To practice finding a difference, although there is really no real world use case for followers, find people that follow userA or userB, but not both. You could think of these people as "possible interests" if userA and userB are similarly focused accounts.

[Practice File](../datafinal\sets-solution\Program.cs)

[Back to outline](outline.md)
