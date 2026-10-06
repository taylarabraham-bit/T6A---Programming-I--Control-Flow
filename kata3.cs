// Kata 3: Multiplication table using nested loops
// ** OBJECTIVE** Comment out your code. To better understand nested loops**
// Commit 1: "scaffold nested loops"
// Commit 2: "added multiplication logic"
// Commit 3: "refactored for readability and spacing"
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {   //Prints the multiplication of i and j in a formatted string. The outer loop iterates through numbers 1 to 10, while the inner loop does the same for each iteration of the outer loop. 
    
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
}