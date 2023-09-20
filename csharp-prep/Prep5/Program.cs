using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string name = EnterUserName();
        int favoriteNumber = EnterFavoriteNumber();

        int squaredNumber = SquareNumber(favoriteNumber);

        FinalResult(name, squaredNumber);
    }
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }
    static string EnterUserName(){
        Console.Write("Please enter your name: ");
        string fullName = Console.ReadLine();

        return fullName;
    }
    static int EnterFavoriteNumber(){
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());

        return favoriteNumber;
    }
    static int SquareNumber(int favoriteNumber){
        int square = favoriteNumber * favoriteNumber;

        return square;
    }
    static void FinalResult(string fullName, int square){
        Console.WriteLine($"{fullName}, the square of your number is {square}");
    }
}