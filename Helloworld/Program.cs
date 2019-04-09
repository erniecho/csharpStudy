class StormingTheCastle
{
    static void Main()
    {
        System.Console.WriteLine("Hello. My name is Inigo Montoya. ");
        string valerie;
        string requirements, miracleMax;
        requirements = miracleMax = "Have fun storming the castle!";

        valerie = "Think it will work?";
        System.Console.WriteLine(miracleMax);
        System.Console.WriteLine(valerie);

        miracleMax = "It would take a miracle.";
        System.Console.WriteLine(miracleMax);

        string firstName, lastName; //Variable for storing the first and last name.
        System.Console.WriteLine("Hey you");

        System.Console.Write/* No new line */("Enter your first name: "); 
        firstName = System.Console.ReadLine();

        System.Console.Write/* No new line */("Enter your last name: ");
        lastName = System.Console.ReadLine();
            
            
            /* Display a greeting to the console 
            using composite formatting */
        System.Console.WriteLine(
        $"Your full name is {0} {1}.", firstName, lastName);
        // This is the end
        // of the programming listing.

    }
}
