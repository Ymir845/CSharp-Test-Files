class Program{
    static void Main(string[]args) {

        string Entrance = "Welcome! What is your name";

        System.Console.WriteLine(Entrance);

        string playerName = Console.ReadLine();

        System.Console.WriteLine("Are you sure your name is " + playerName);

        string playerAnswer = Console.ReadLine();

        if (playerAnswer == "yes") {

            System.Console.WriteLine("Okay! Nice to meet you " + playerName);

        }
        else {
            System.Console.WriteLine("Oh");
        }

    }
}
