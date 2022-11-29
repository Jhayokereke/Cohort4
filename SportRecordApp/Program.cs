using SportRecordLibrary;

Console.WriteLine("Welcome to our app....");

List<SportRecord> sportRecords = new List<SportRecord>();
Dictionary<string, SportRecord> sportRecordDictionary = new Dictionary<string, SportRecord>();

bool done = false;
do
{
    Console.WriteLine("Enter a new sport record.");

    Console.Write("Sport Name: ");
    string sportName = Console.ReadLine();
    Console.WriteLine();

    //For first position
    Console.WriteLine("First Position");

    Console.Write("Name: ");
    string firstName = Console.ReadLine();
    Console.Write("Country: ");
    string firstCountry = Console.ReadLine();
    Console.Write("Tag Number: ");
    int firstTagNumber = int.Parse(Console.ReadLine());
    Console.WriteLine();

    //For second position
    Console.WriteLine("Second Position");

    Console.Write("Name: ");
    string secondName = Console.ReadLine();
    Console.Write("Country: ");
    string secondCountry = Console.ReadLine();
    Console.Write("Tag Number: ");
    int secondTagNumber = int.Parse(Console.ReadLine());
    Console.WriteLine();

    //for third position
    Console.WriteLine("Third Position");

    Console.Write("Name: ");
    string thirdName = Console.ReadLine();
    Console.Write("Country: ");
    string thirdCountry = Console.ReadLine();
    Console.Write("Tag Number: ");
    int thirdTagNumber = int.Parse(Console.ReadLine());
    Console.WriteLine();

    SportRecord newRecord = new()
    {
        SportCategory = sportName,
        FirstPosition = new Competitor { Name = firstName, Country = firstCountry, TagNumber = firstTagNumber },
        SecondPosition = new Competitor { Name = secondName, Country = secondCountry, TagNumber = secondTagNumber },
        ThirdPosition = new Competitor { Name = thirdName, Country = thirdCountry, TagNumber = thirdTagNumber }
    };

    sportRecords.Add(newRecord);

    Console.WriteLine("\nAdd a new record? click 'enter' to continue.");
    var input = Console.ReadKey(true);
    var key = input.Key;
    if (key != ConsoleKey.Enter)
    {
        done = true;
    }
    Console.Clear();
} 
while (!done);

foreach (SportRecord record in sportRecords)
{
    Console.WriteLine(record);
    Console.WriteLine("-------------------------------------------------------------");
}