/*
 * LINQ - Language Integrated Query
 * 
 * Projecting - Return a collection/group/item in a different format
 * Select - Return a single collection/item based in a new format
 * SelectMany - Returns a flattened out colection/item in a new format
 * 
 * Filtering - pick certain items from a larger collection/group
 * Where - returns a new collection that matches a given criteria/condition
 * 
 * Searching - picking a particular item from the collection
 * First/FirstOrDefault - 
 * SingleOrDefault - 
 * 
 * Grouping - Combining items of a collection into groups based on a key
 * GroupBy -
 * 
 * Ordering- Arranges the items in a chronologial manner based on a key
 * OrderBy - 
 * OrderByDescending - 
 */

List<string> names = new()
{
    "Ronaldo", "Bola", "Shade", "Robert", "Messi", "Asafa",
    "Paul", "Saul", "John", "Greg", "Sina", "Tega", "Kate",
    "Pam", "Irene"
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

var fiveLetterNames = names.Where(name => name.Length == 5);
var fiveLettersOrMore = names.Where(name => name.Length >= 5);

var startsWithA = names.Where(n => n[0] == 'A');
var startsWithR = names.Where(n => n[0] == 'R');

var firstOccurenceOfE = names.FirstOrDefault(n => n.Contains('e', StringComparison.OrdinalIgnoreCase));
var firstOccurenceOfEWithSixLetters = names.FirstOrDefault(n => n.Contains('e', StringComparison.OrdinalIgnoreCase) && n.Length == 6);
var firstOccurenceOfEOrFourLetterWord = names.FirstOrDefault(n => n.Contains('e', StringComparison.OrdinalIgnoreCase) || n.Length == 4);

var sizeGroup = names.GroupBy(n => n.Length).Select(grp => new { grp.Key, Items = string.Join(", ", grp.Select(x => x))});
var firstLetterGroup = names.GroupBy(n => n[0]).Select(grp => new { grp.Key, Items = string.Join(", ", grp.Select(x => x))});

var bySize = names.OrderBy(n => n.Length);
var byLetter = names.OrderBy(n => n);

Console.WriteLine(string.Join("\n", byLetter));

/* patientrecords - Table
 * fname, lname, age, height, weight, bp
 * John Snow 25 198 89 165
 * Kate White 22 123 65 120
 * 
 * select fname, lname, age from patientrecords - sql
 * from p in _db.patientrecords select new { p.fname, p.lname, p.age } - linq to sql
 * _db.patientrecords.Select(p => new { p.fname, p.lname, p.age });
 */