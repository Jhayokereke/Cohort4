/*
 * LINQ - Language Integrated Query
 * 
 * Projection - Return a collection/group/item in a different format
 * Select - Return a single collection/item based in a new format
 * SelectMany - Returns a flattened out colection/item in a new format
 * 
 * Filteration - pick certain items from a larger collection/group
 * Where - returns a new collection that matches a given criteria/condition
 */

List<string> names = new()
{
    "Bola", "Shade", "Robert", "Ronaldo", "Messi", "Asafa"
};

var projectedNames = names.Select(x => new { Name = x, Size = x.Length });

var query = from x in names
            select new { Name = x, Size = x.Length };

var groupOfNames = names.SelectMany(x => x);

Dictionary<string, List<string>> sportRecord = new()
{
    { "high jump", new List<string> { "Ade", "Bolu", "Sola" } },
    { "long jump", new List<string> { "Greg", "Sina", "Tega" } },
    { "Pole vault", new List<string> { "Kate", "Pam", "Irene" } },
    { "Tennis", new List<string> { "Paul", "Saul", "John" } },
    { "Discus", new List<string> { "Messi", "Ronaldo", "Mbappe" } }
};

var allWinners = sportRecord.SelectMany(sr => sr.Value);

var fiveLetterNames = names.Where(name =>  name.Length == 5);
var fiveLettersOrMore = names.Where(name => name.Length >= 5);

var startsWithA = names.Where(n => n[0] == 'A');
var startsWithR = names.Where(n => n[0] == 'R');

Console.WriteLine(string.Join("\n", fiveLetterNames));