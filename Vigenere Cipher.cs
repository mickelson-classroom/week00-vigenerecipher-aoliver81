//Vigenere Cipher
//This program encrypts the charecters of a message using the Vigenere Method

using System;
using System.Diagnostics;
class app
{
    //Returns true if the given character is a lowercase letter and false outherwise
    public static bool IsLowercaseLetter(char c)
    {
        return c>= 'a'&& c<= 'z' ;
    }
    static void Tests();
    
    public static void TestIsLowercaseLetter()
    {
        Debug.Assert(IsLowercaseLetter('a'));
        Debug.Assert(IsLowercaseLetter('b'));
        Debug.Assert(IsLowercaseLetter('z'));
        Debug.Assert(!IsLowercaseLetter('A'));
        Debug.Assert(!IsLowercaseLetter('{'));
    
    }   
   public static bool IsValidImput()
    { 
        Debug.Assert(IsValidImput('a'));
        Debug.Assert(IsValidImput('z'));
        Debug.Assert(!IsValidImput('A'));
        Debug.Assert(!IsValidImput('{'));
    {
            
        Debug.Assert(ShiftLetter(char);
        Debug.Assert(ShiftLetter(char);
        Debug.Assert(ShiftMessage)
    }
    static void Main()
    {
       TestIsLowercaseLetter();
        Console.WriteLine("This program encrypts the characters of a message using the Vigenere method.");
        Console.WriteLine("Please enter the message");
        string message = Console.ReadLine();
        Console.WriteLine("Please enter the encryption key");
        string key = Console.ReadLine();
        Console.WriteLine("Here is the message");
        Console.WriteLine(message);
        
    }
}