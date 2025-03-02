using System;

class AgeCalculator {
    static void Main() {
        Console.Write("Enter birth year: ");
        int birthYear = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your age: " + (DateTime.Now.Year - birthYear));
    }
}
