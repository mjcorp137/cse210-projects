using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("Ateneo de Cagayan University", "Cagayan de Oro", "Misamis Oriental", "Philippines");

        Lecture lecture = new Lecture("American Literature Survey: From Puritans to Postmodernism", "Introduction to Colonial Literature - Anne Bradstreet and Jonathan Edwards", "Dec 4, 2023", "8 AM", address, "Prof. Cunningham", 6000);
        Console.WriteLine();

        Console.WriteLine("Event Number: 1");
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateDetailedLecture());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateShortLecture());

        Address addressR = new Address("Climbs Hall", "Shenea", "Negros Oriental", "Philippines");

        Reception reception = new Reception("Fundamentals of Physics: Classical Mechanics and Beyond", "Newtonian Mechanics - Sir Isaac Newton", "Feb 14, 2024", "9 AM", addressR, "Career@edu.com");
        Console.WriteLine();

        Console.WriteLine("Event Number: 2");
        Console.WriteLine();
        Console.WriteLine(reception.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateDetailedReception());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateShortReception());

        Address addressOG = new Address("EB Magalona City Hall", "Sheesh", "Negros Occidental", "Philippines");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Introduction to Political Philosophy: Theories of Government", "The Social Contract - Thomas Hobbes and John Locke", "Jan 28, 2024", "10 AM", addressOG, "Fair");
        Console.WriteLine();

        Console.WriteLine("Event Number: 3");

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateDetailedOutdoorGathering());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateShortOutdoorGathering());
    }
}