﻿// 12321 
Console.Write("Enter a number ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10000 && number <= 99999)
{

    if (Palindrome(number)) Console.WriteLine("Yes");
    else Console.WriteLine("No");


    bool Palindrome(int num)
    {
        int firstDigit = num / 10000;
        int lastDigit = num % 10;
        int firstDigit2 = num % 10000;
        int lastDigit2 = firstDigit2 / 1000;
        int firstDigit3 = num % 100;
        int lastDigit3 = firstDigit3 / 10;

        return firstDigit == lastDigit && lastDigit2 == lastDigit3;


    }
}
else Console.WriteLine("You have entered the wrong number");