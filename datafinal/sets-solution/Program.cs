
// Hers the list of users you will be comparing to. 

HashSet<string> userAfollowers = new HashSet<string> { "alice_smith", "bob_jones", "chris_wilson", "david_martin", "emily_harris", "frank_jackson", "grace_thompson", "henry_miller", "isabel_turner", "jack_roberts" };
HashSet<string> userBfollowers = new HashSet<string> { "james_carter", "lily_anderson", "owen_mitchell", "sophia_rodriguez", "samuel_cooper", "grace_thompson", "frank_jackson", "chris_wilson", "emily_harris", "jack_roberts" };

HashSet<string> userAfollows = new HashSet<string> { "john_smith", "lisa_jones", "michael_wilson", "susan_martin", "william_harris" };
HashSet<string> userBfollows = new HashSet<string> { "michael_smith", "linda_jones", "peter_wilson", "sarah_martin", "william_harris" };

// After performing the set operations, you will need to reset
// userAfollows and userAfollowers to avoid progression that is unwanted. to do this, after 
// performing your set method and printing result, reset setA to 
// match originalsetA

HashSet<string> originalUserAfollowers = new HashSet<string>(userAfollowers);
HashSet<string> originalUserAfollows = new HashSet<string>(userAfollows);

// run these lines after performing the methord and printing the result


userAfollowers = new HashSet<string>(originalUserAfollowers);
userAfollows = new HashSet<string>(originalUserAfollows);


// TASK 1
// FIND USERS THAT userA OR userB FOLLOW



// print results
foreach (var item in userAfollows)
{
    Console.WriteLine("All users that userA or userB follow:");
    Console.WriteLine(item);
}


// reset userAfollows
userAfollows = new HashSet<string>(originalUserAfollows);

// TASK 2
// FIND MUTUAL FOLLOWERS Of userA and userB
// AKA THESE ARE PEOPLE THAT FOLLOW BOTH aserA AND userB


foreach (var item in userAfollowers)
{
    Console.WriteLine("All users that follow userA and userB");
    Console.WriteLine(item);
}

// reset userafollowers
userAfollowers = new HashSet<string>(originalUserAfollowers);

// TASK 3
// FIND POTENTIAL FOLLOWERS aka SUGGESTED
// There are users that follow userA, or userB, but not both
// you could think of these people that might be suggested to 
// follow the other user if they are similarly focused accounts



foreach (var item in userAfollowers)
{
    Console.WriteLine("Potential followers for both users");
    Console.WriteLine(item);
}
