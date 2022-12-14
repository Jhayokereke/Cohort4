/*
 * LINQ - Language Integrated Query
 * 
 * Projection - Return a collection/group/item in a different format
 * Select - Return a single collection/item based in a new format
 * SelectMany - 
 */

List<string> names = new()
{
    "Bola", "Shade", "Robert", "Ronaldo", "Messi", "Asafa"
};

var projectedNames = names.Select(x => new { Name = x, Size = x.Length });

var query = from x in names
            select new { Name = x, Size = x.Length };

var groupOfNames = names.SelectMany(x => x);

Console.WriteLine(string.Join("\n", groupOfNames));