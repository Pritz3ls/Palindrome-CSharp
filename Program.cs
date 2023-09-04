using System;

namespace Excersise
{
    // Guerrero, Prince Marco R.
    // BSIT 2104 - Advance Computer Programming CS-121
    // Dont copy codes! understand and analyze it
    // If you do copy and didnt understand how the code works, i will know and i will find you. >:(
    // class NumberTwo{
    //     static void Main(string[] args){
    //         // Declare a string variable and assigned it to be empty
    //         string input = string.Empty;
    //         // We will use while-loops
    //         while (true){
    //             // Now we prompt the user to enter a word
    //             Console.Write("Enter a word: ");
    //             input = Console.ReadLine();
    //             // Afterwards, we convert the word to lower-case for case sensitive
    //             input.ToLower();
    //             // Before we continue or check if its a palindrome, we first check if its
    //             // 'exit' word input, if yes we terminate the program
    //             if(input == "exit"){Console.WriteLine("Program Terminated");break;}
    //             // If the above did'nt satisfy, we continue on here
    //             // We call out our CheckPalidrome method to check if its a palindrome
    //             if(CheckPalindrome(input)){Console.WriteLine("This is a palindrome")/*If the return value is true, then its a palindrome*/;
    //             }else{Console.WriteLine("This is not a palindrome!");/*otherwise, we simply say its not a palindrome*/}
    //         }
    //     }
    //     // We will create a new method that has one parameter and a returning value
    //     static bool CheckPalindrome(string str){
    //         // We convert our str/string to two arrays
    //         char[] ori = str.ToCharArray();
    //         char[] rev = str.ToCharArray();
    //         // One of the arrays, rev, we will reverse all the elements inside that array
    //         Array.Reverse(rev);
    //         // using for-loops we can iterate all the elements inside the two arrays (both arrays have the same length)
    //         for (int i = 0; i < ori.Length; i++){
    //             // if one of the element in original array in an index position doesnt satisfy with
    //             // the reversed array element with the same index position, we simply return false.
    //             if(ori[i] != rev[i]){return false;}
    //         }
    //         // If the for-loops did'nt encounter any mishaps, we return true.
    //         return true;
    //     }
    // }
}