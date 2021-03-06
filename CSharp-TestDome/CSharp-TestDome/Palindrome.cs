﻿/*
    A palindrome is a word that reads the same backwards and forwards.

    Write a function that checks if a given word is a palindrome.
    Character case should be ignored.

    For example, IsPalindrome("Deleveled") should return true as character case should be ignored, resulting in "deleveled",
        which is a palindrome since it reads the same backwards and forwards.
 */

using System;

public class Palindrome
{
    public static bool IsPalindrome(string word)
    {
        // Take the first half
        string first = word.Substring(0, word.Length / 2);
        char[] arr = word.ToCharArray();

        // Reverse the array, then take the second half
        Array.Reverse(arr);
        string temp = new string(arr);
        string second = temp.Substring(0, temp.Length / 2);

        // Character case should ignored; but still using ToLower();
        return first.ToLower().Equals(second.ToLower());
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
    }
}